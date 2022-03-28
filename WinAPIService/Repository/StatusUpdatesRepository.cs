using Mirth.Contracts;
using Mirth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinAPIService.Repository;

namespace Mirth.Repository
{
    public class StatusUpdatesRepository : IStatusUpdatesRepository
    {        
        private BaseRepository<StatusUpdate> _baseStatusUpdateRepository;

        public StatusUpdatesRepository()
        {
            _baseStatusUpdateRepository = new BaseRepository<StatusUpdate>();
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

        public void Dispose()
        {
            _baseStatusUpdateRepository.Dispose();
        }
    }
}
