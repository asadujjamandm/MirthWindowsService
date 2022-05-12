using Mirth.Contracts;
using Mirth.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinAPIService.Repository;

namespace Mirth.Repository
{
    public class PMSMessageLogsRepository : IPMSMessageLogsRepository
    {
        private BaseRepository<PMSMessageLog> _basePMSRepository;
        private BaseRepository<StatusUpdate> _baseStatusUpdateRepository;
        private int _maxCount = Convert.ToInt32(ConfigurationSettings.AppSettings["MAX_CVS_API_CALL"]);

        public PMSMessageLogsRepository()
        {
            _basePMSRepository = new BaseRepository<PMSMessageLog>();
            _baseStatusUpdateRepository = new BaseRepository<StatusUpdate>();
        }        

        public IEnumerable<PMSMessageLog> GetPMSMessageLog()
        {
            try
            {
                return _basePMSRepository.GetAll().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public PMSMessageLog GetPMSMessageLogByCustomerRxId(AutomationRxEvent automationRxEvent)
        {
            try
            {
                var pmsMessageLog = _basePMSRepository.FindByCondition(x=> x.RxNumber == automationRxEvent.RxTransaction.CustomerRXID && x.BatchID == automationRxEvent.MessageHeader.ID).FirstOrDefault();                    
                
                return pmsMessageLog;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }        

        public async Task Insert(PMSMessageLog pmsMessageLog)
        {
            try
            {
                _basePMSRepository.Add(pmsMessageLog);
                await _basePMSRepository.Save();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }        

        public async Task UpdatePMSMessageLog(PMSMessageLog pMSMessageLog)
        {
            try
            {
                var extPMSMessageLog = _basePMSRepository.FindByCondition(x => x.BatchID == pMSMessageLog.BatchID && x.RxNumber == pMSMessageLog.RxNumber).FirstOrDefault();

                //extPMSMessageLog.NumberOfAttempt++;
                extPMSMessageLog.Status = pMSMessageLog.Status;
                extPMSMessageLog.LastTriedTime = DateTime.Now;
                //if(extPMSMessageLog.NumberOfAttempt <= _maxCount)
                    await _basePMSRepository.Update(extPMSMessageLog);
                //await _basePMSRepository.Save();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void Dispose()
        {
            _basePMSRepository.Dispose();
            _baseStatusUpdateRepository.Dispose();
        }
    }
}
