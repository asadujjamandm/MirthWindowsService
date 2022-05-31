using WinAPIService.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mirth.Models;

namespace Mirth.Contracts
{
    public interface IPMSMessageLogsRepository : IDisposable
    {
        IEnumerable<PMSMessageLog> GetPMSMessageLog();
        PMSMessageLog GetPMSMessageLogByCustomerRxId(AutomationRxEvent automationRxEvent);
        Task Insert(PMSMessageLog pmsMessageLog);        
        void UpdatePMSMessageLog(PMSMessageLog pmsMessageLog);        
    }
}
