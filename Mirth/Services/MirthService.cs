using Mirth.Helper;
using Mirth.Models;
using Mirth.Repository;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Mirth
{
    public class MirthService
    {

        private XMLFileReader _xmlFileReader;
        private PMSMessageLogsRepository _pmsMessageLogsRepository;
        private StatusUpdatesRepository _statusUpdatesRepository;
        private ResponseModel _responseModel;

        public MirthService()
        {
            _xmlFileReader = new XMLFileReader();
            _pmsMessageLogsRepository = new PMSMessageLogsRepository();
            _statusUpdatesRepository = new StatusUpdatesRepository();
        }

        public async Task ProcessXMLMessage()
        {
            try
            {
                Logger.log.Info("####################### Start ###########################");
                Logger.log.Info("Folder scanning has started");

                var automationRxEvents = await _xmlFileReader.GetXMLFileContent();

                Logger.log.Info(automationRxEvents.Count + " File(s) Found in this " + ConfigurationSettings.AppSettings["Source"] +" directory");

                foreach (var item in automationRxEvents)
                {
                    CVSModel cvsModel = RxMapperHelper.MapCVSModel(item.RxTransaction);

                    string res = await InvokeServiceHelper.PostCVSAPI(cvsModel);

                    _responseModel =JsonConvert.DeserializeObject<ResponseModel>(res);

                    HandleDatabaseOperation(item.RxTransaction);

                    if(this.GetStatus() == true)
                        _xmlFileReader.RemoveFile(item.FilePath);
                }

                Logger.log.Info("ProcessXMLMessage()  XML file processing Completed");

                Logger.log.Info("####################### End ###########################");

                this.Dispose();
            }
            catch (Exception ex)
            {
                this.Dispose();
                Logger.log.Error("ProcessXMLMessage " + ex.Message);
                throw ex;
            }
        }

        private void HandleDatabaseOperation(RxTransaction rxTransaction)
        {
            try
            {
                var pmsMessageLog = GetPMSLogInfo(rxTransaction);
                UpsertDataInPMSMessageLog(pmsMessageLog, rxTransaction);
                
            }
            catch (Exception ex)
            {
                Logger.log.Error("HandleDatabaseOperation " + ex.Message);
                throw ex;
            }
        }

        private PMSMessageLog GetPMSLogInfo(RxTransaction rxTransaction)
        {
            try
            {
                Logger.log.Info("GetPMSLogInfo() Get existing PMS Log Info from PMSMessageLog Table CustomerRxID: "+ rxTransaction.CustomerRXID.ToString());
                var pmsMessageLog = _pmsMessageLogsRepository.GetPMSMessageLogByCustomerRxId(rxTransaction.CustomerRXID.ToString());

                if(pmsMessageLog != null)
                {
                    pmsMessageLog.NumberOfAttempt = pmsMessageLog.Status == "true" ? pmsMessageLog.NumberOfAttempt : pmsMessageLog.NumberOfAttempt + 1;
                }
                else
                {
                    pmsMessageLog = new PMSMessageLog();
                    pmsMessageLog.NumberOfAttempt = 1;
                }

                return pmsMessageLog;
            }
            catch (Exception ex)
            {
                Logger.log.Error("GetPMSLogInfo " + ex.Message);
                throw ex;
            }
        }

        private bool GetStatus()
        {
            try
            {
                if (this._responseModel.statusCode == "00")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Logger.log.Error("GetStatus " + ex.Message);
                throw ex;
            }                 
        }

        private int GetUpdateStatusIDByRxNumber(RxTransaction rxTransaction)
        {
            try
            {               
                var statusUpdate = _statusUpdatesRepository.GetStatusUpdatesByRxNumber(rxTransaction.CustomerRXID);

                return statusUpdate != null ? statusUpdate.UpdateStatusID : -1;
            }
            catch (Exception ex)
            {
                Logger.log.Error("GetUpdateStatusIDByRxNumber " + ex.Message);
                throw ex;
            }
        }

        private void ModifyStatusUpdate(PMSMessageLog pMSMessageLog)
        {
            try
            {
                StatusUpdate statusUpdate = new StatusUpdate();
                statusUpdate.CVSAcknowlogement = Convert.ToBoolean(pMSMessageLog.Status);
                statusUpdate.UpdateStatusID = pMSMessageLog.UpdateStatusID;

                _statusUpdatesRepository.ModifyStatusUpdates(statusUpdate);                

                Logger.log.Info("ModifyStatusUpdate() Updated Status Table. UpdateStatusID: " + pMSMessageLog.UpdateStatusID + ";" + "CVSAcknowledgementL: " + statusUpdate.CVSAcknowlogement);
            }
            catch (Exception ex)
            {
                Logger.log.Error("ModifyStatusUpdate " + ex.Message);
                throw ex;
            }
        }

        private void UpsertDataInPMSMessageLog(PMSMessageLog pmsMessageLog, RxTransaction rxTransaction)
        {
            try
            {
                pmsMessageLog.UpdateStatusID = GetUpdateStatusIDByRxNumber(rxTransaction);
                var status = GetStatus().ToString();
                pmsMessageLog.LastTriedTime = DateTime.Now;

                if (pmsMessageLog.Status == null)
                    pmsMessageLog.Status = "false";

                if (pmsMessageLog.UpdateStatusID != -1)  
                {
                    if (pmsMessageLog.Status.ToLower() != "true")
                    {
                        pmsMessageLog.Status = status;
                        if (pmsMessageLog.NumberOfAttempt == 1)
                        {
                            _pmsMessageLogsRepository.Insert(pmsMessageLog);
                            Logger.log.Info("Inserted new record in PMSMessageLog Table. UpdateStatusID: " + pmsMessageLog.UpdateStatusID);
                        }
                        else
                        {
                            _pmsMessageLogsRepository.UpdatePMSMessageLog(pmsMessageLog);
                            Logger.log.Info("Updated PMSMessageLog Table. UpdateStatusID: " + pmsMessageLog.UpdateStatusID);
                        }

                        ModifyStatusUpdate(pmsMessageLog);
                        
                    }
                    else
                    {
                        Logger.log.Info("Already Sent to PMS.");
                    }
                }
                else
                {
                    Logger.log.Info("UpdateStatusID not found for the RxNumber: " + rxTransaction.CustomerRXID);
                }

            }
            catch (Exception ex)
            {
                Logger.log.Error("UpsertDataInPMSMessageLog " + ex.Message);
                throw ex;
            }
        }

        private void Dispose()
        {
            _pmsMessageLogsRepository.Dispose();
            _statusUpdatesRepository.Dispose();
        }
    }
}
