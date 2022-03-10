using Mirth.Contracts;
using System;
using System.Collections.Generic;
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

        public PMSMessageLog GetPMSMessageLogByCustomerRxId(string customerRxID)
        {
            try
            {
                var pmsMessageLog = _basePMSRepository.GetAll()
                    .Join(_baseStatusUpdateRepository.GetAll()
                    .Where(status => status.RxNumber == customerRxID), pms => pms.UpdateStatusID, status => status.UpdateStatusID, (a,b) => new { PMSMessageLog = a, StatusUpdate = b}).FirstOrDefault();

                
                return pmsMessageLog != null ? pmsMessageLog.PMSMessageLog: null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }        

        public void Insert(PMSMessageLog pmsMessageLog)
        {
            try
            {
                _basePMSRepository.Add(pmsMessageLog);
                _basePMSRepository.Save();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }        

        public void UpdatePMSMessageLog(PMSMessageLog pMSMessageLog)
        {
            try
            {
                var extPMSMessageLog = _basePMSRepository.FindByCondition(x => x.UpdateStatusID == pMSMessageLog.UpdateStatusID).FirstOrDefault();

                extPMSMessageLog.NumberOfAttempt++;
                extPMSMessageLog.Status = pMSMessageLog.Status;
                extPMSMessageLog.LastTriedTime = DateTime.Now;

                _basePMSRepository.Update(extPMSMessageLog);
                _basePMSRepository.Save();
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
