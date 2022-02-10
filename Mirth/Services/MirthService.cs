using Mirth.Helper;
using Mirth.Models;
using Mirth.Repository;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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
                var automationRxEvents = await _xmlFileReader.GetXMLFileContent();

                foreach(var item in automationRxEvents)
                {
                    CVSModel cvsModel = RxMapperHelper.MapCVSModel(item.RxTransaction);

                    string res = await InvokeServiceHelper.PostCVSAPI(cvsModel);

                    _responseModel =JsonConvert.DeserializeObject<ResponseModel>(res);

                    HandleDatabaseOperation(item.RxTransaction);
                }                
            }
            catch (Exception ex)
            {
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

                return statusUpdate.UpdateStatusID;
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
                pmsMessageLog.Status = pmsMessageLog.Status == "false" ? GetStatus().ToString() : pmsMessageLog.Status;                

                if (pmsMessageLog.UpdateStatusID != null)  
                {
                    if (pmsMessageLog.Status != "true")
                    {
                        if (pmsMessageLog.NumberOfAttempt == 1)
                        {
                            _pmsMessageLogsRepository.Insert(pmsMessageLog);                            
                        }
                        else
                        {
                            _pmsMessageLogsRepository.UpdatePMSMessageLog(pmsMessageLog);                            
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
    }
}
