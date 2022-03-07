using WinAPIService.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mirth.Contracts
{
    public interface IPMSMessageLogsRepository : IDisposable
    {
        IEnumerable<PMSMessageLog> GetPMSMessageLog();
        PMSMessageLog GetPMSMessageLogByCustomerRxId(string customerRxID);
        void Insert(PMSMessageLog pmsMessageLog);        
        void UpdatePMSMessageLog(PMSMessageLog pmsMessageLog);        
    }
}
