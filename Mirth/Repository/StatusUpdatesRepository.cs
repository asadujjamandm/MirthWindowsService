using Mirth.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mirth.Repository
{
    public class StatusUpdatesRepository : IStatusUpdatesRepository
    {        
        private BaseRepository<StatusUpdate> _baseStatusUpdateRepository;

        public StatusUpdatesRepository()
        {
            _baseStatusUpdateRepository = new BaseRepository<StatusUpdate>();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<StatusUpdate> GetStatusUpdates()
        {
            try
            {
                return _baseStatusUpdateRepository.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public StatusUpdate GetStatusUpdatesByID(int statusID)
        {
            try
            {
                var statusUpdate = _baseStatusUpdateRepository.FindByCondition(x => x.UpdateStatusID == statusID).FirstOrDefault();

                return statusUpdate;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public StatusUpdate GetStatusUpdatesByRxNumber(string RxNumber)
        {
            try
            {
                var statusUpdate = _baseStatusUpdateRepository.FindByCondition(x => x.CustomerRXID == RxNumber).FirstOrDefault();

                return statusUpdate;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void ModifyStatusUpdates(StatusUpdate statusUpdate)
        {
            try
            {
                StatusUpdate existingStatusUpdate = _baseStatusUpdateRepository.FindByCondition(x => x.UpdateStatusID == statusUpdate.UpdateStatusID).FirstOrDefault();
                
                existingStatusUpdate.CVSAcknowlogement = true;
                _baseStatusUpdateRepository.Update(existingStatusUpdate);
                _baseStatusUpdateRepository.Save();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }       
    }
}
