using WinAPIService.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mirth.Models;

namespace Mirth.Contracts
{
    public interface IStatusUpdatesRepository : IDisposable
    {
        IEnumerable<StatusUpdate> GetStatusUpdates();
        StatusUpdate GetStatusUpdatesByID(int statusID);              
    }
}
