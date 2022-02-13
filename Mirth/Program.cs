using Mirth.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace Mirth
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new WindowsAPIService()
            };
            ServiceBase.Run(ServicesToRun);
            //for (long i = 0; i < 100000; i++)
            //{
            //    Logger.log.Error("hello " + i);
            //}

            //MirthService mirthService = new MirthService();

            //mirthService.ProcessXMLMessage().Wait();
        }
    }
}
