using Mirth.Helper;
using Mirth.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mirth
{
    [RunInstaller(true)]
    public partial class WindowsAPIService : ServiceBase
    {
        public Thread worker = null;
        private int ScheduleTime = Convert.ToInt32(ConfigurationSettings.AppSettings["ThreadTime"]);
        public WindowsAPIService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            try
            {
                ThreadStart start = new ThreadStart(Working);
                worker = new Thread(start);
                worker.Start();
            }
            catch (Exception ex)
            {
                Logger.log.Error("OnStart() "+ex.Message);
                throw ex;
            }
            
        }

        private void Working()
        {            
            try
            {
                while (true)
                {
                    MirthService mirthService = new MirthService();

                    mirthService.ProcessXMLMessage().Wait();

                    Thread.Sleep(ScheduleTime * 1000);
                    
                }    
            }
            catch(Exception ex)
            {
                Logger.log.Error("Working() " + ex.Message);
                throw ex;
            }
        }

        protected override void OnStop()
        {
            try
            {
                if (worker != null && worker.IsAlive)
                {
                    worker.Abort();
                }
            }
            catch(Exception ex)
            {
                Logger.log.Error("OnStop() " + ex.Message);
                throw ex;
            }            
        }
    }
}
