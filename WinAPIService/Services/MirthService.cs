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
using WinAPIService.Repository;

namespace Mirth
{
    public class MirthService
    {

        private XMLFileReader _xmlFileReader;
        private PMSMessageLogsRepository _pmsMessageLogsRepository;
        private StatusUpdatesRepository _statusUpdatesRepository;
        private ResponseModel _responseModel;

        private int _maxCount = Convert.ToInt32(ConfigurationSettings.AppSettings["MAX_CVS_API_CALL"]);

        public MirthService()
        {
            _xmlFileReader = new XMLFileReader();
            _pmsMessageLogsRepository = new PMSMessageLogsRepository();
            _statusUpdatesRepository = new StatusUpdatesRepository();
        }

        public async Task<bool> ProcessXMLMessage()
        {
            try
            {
                Logger.log.Info("####################### Start ###########################");
                Logger.log.Info("Folder scanning has started");

                var automationRxEvents = await _xmlFileReader.GetXMLFileContent();

                Logger.log.Info(automationRxEvents.Count + " File(s) Found in this " + ConfigurationSettings.AppSettings["Source"] + " directory");

                foreach (var item in automationRxEvents)
                {
                    try
                    {                        
                        var pmsMessageLog = GetPMSLogInfo(item);
                        if (pmsMessageLog != null && pmsMessageLog.NumberOfAttempt <= this._maxCount)
                        {

                            CVSModel cvsModel = RxMapperHelper.MapCVSModel(item);

                            string res = InvokeServiceHelper.PostCVSAPI(cvsModel, item.MessageHeader.ID);
                            if (res.ToLower() != "false")
                            {
                                _responseModel = JsonConvert.DeserializeObject<ResponseModel>(res);

                                var dbStatus = await HandleDatabaseOperation(pmsMessageLog);

                                if (this.GetStatus() == true && dbStatus == true)
                                    _xmlFileReader.RemoveFile(item.FilePath);
                            }
                        }
                        else
                        {
                            Logger.log.Info("RxNumber " + pmsMessageLog.RxNumber + " BatchID " + pmsMessageLog.BatchID + " exceded the max limit of calling CVS API, max limit is " + this._maxCount);
                        }
                        pmsMessageLog = null;
                    }
                    catch (Exception ex)
                    {
                        Logger.log.Error("ProcessXMLMessage " + ex.Message);
                        continue;
                    }
                    
                }

                Logger.log.Info("ProcessXMLMessage()  XML file processing Completed");

                Logger.log.Info("####################### End ###########################");
                automationRxEvents = null;
                this.Dispose();

                return true;
            }
            catch (Exception ex)
            {
                this.Dispose();
                Logger.log.Error("ProcessXMLMessage " + ex.Message);
                return false;
            }
        }

        private async Task<bool> HandleDatabaseOperation(PMSMessageLog pmsMessageLog)
        {
            try
            {
                await UpsertDataInPMSMessageLog(pmsMessageLog);
                return true;
            }
            catch (Exception ex)
            {
                Logger.log.Error("HandleDatabaseOperation " + ex.Message);
                return false;
            }
        }

        private PMSMessageLog GetPMSLogInfo(AutomationRxEvent automationRxEvent)
        {
            try
            {
                Logger.log.Info("GetPMSLogInfo() Get existing PMS Log Info from PMSMessageLog Table CustomerRxID: " + automationRxEvent.RxTransaction.CustomerRXID.ToString());
                var pmsMessageLog = _pmsMessageLogsRepository.GetPMSMessageLogByCustomerRxId(automationRxEvent);
                

                if (pmsMessageLog != null)
                {
                    if (pmsMessageLog.NumberOfAttempt >= this._maxCount)
                    {
                        pmsMessageLog.NumberOfAttempt++;
                        return pmsMessageLog;
                    }
                    pmsMessageLog.NumberOfAttempt = pmsMessageLog.Status == "true" ? pmsMessageLog.NumberOfAttempt : pmsMessageLog.NumberOfAttempt + 1;
                }
                else
                {
                    pmsMessageLog = new PMSMessageLog();
                    pmsMessageLog.NumberOfAttempt = 1;
                    pmsMessageLog.RxNumber = automationRxEvent.RxTransaction.CustomerRXID;
                    pmsMessageLog.BatchID = automationRxEvent.MessageHeader.ID;
                }

                return pmsMessageLog;
            }
            catch (Exception ex)
            {
                Logger.log.Error("GetPMSLogInfo " + ex.Message);
                Logger.log.Error("GetPMSLogInfo " + ex.InnerException);
                return null;
            }
        }

        private bool GetStatus()
        {
            try
            {
                if (this._responseModel.responseCode == "00")
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
                return false;
            }
        }

        private async Task<bool> UpsertDataInPMSMessageLog(PMSMessageLog pmsMessageLog)
        {
            try
            {
                var status = GetStatus().ToString();
                pmsMessageLog.LastTriedTime = DateTime.Now;

                if (pmsMessageLog.Status == null)
                    pmsMessageLog.Status = "false";


                if (pmsMessageLog.Status.ToLower() != "true")
                {
                    pmsMessageLog.Status = status;
                    if (pmsMessageLog.NumberOfAttempt == 1)
                    {
                        await _pmsMessageLogsRepository.Insert(pmsMessageLog);
                        Logger.log.Info("Inserted new record in PMSMessageLog Table. BatchID: " + pmsMessageLog.BatchID + " RxNumber: " + pmsMessageLog.RxNumber);
                    }
                    else
                    {
                        _pmsMessageLogsRepository.UpdatePMSMessageLog(pmsMessageLog);
                        Logger.log.Info("Updated PMSMessageLog Table. BatchID: " + pmsMessageLog.BatchID + " RxNumber: " + pmsMessageLog.RxNumber);
                    }
                }
                else
                {
                    Logger.log.Info("Already Sent to PMS.");
                }
                
                return true;
            }
            catch (Exception ex)
            {
                Logger.log.Error("UpsertDataInPMSMessageLog " + ex.Message);
                return false;
            }
        }

        private void Dispose()
        {
            _pmsMessageLogsRepository.Dispose();
            _statusUpdatesRepository.Dispose();
        }
    }
}
