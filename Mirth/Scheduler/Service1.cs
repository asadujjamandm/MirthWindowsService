﻿using Mirth.Helper;
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
    public partial class Service1 : ServiceBase
    {
        public Thread worker = null;
        private int ScheduleTime = Convert.ToInt32(ConfigurationSettings.AppSettings["ThreadTime"]);
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            ThreadStart start = new ThreadStart(Working);
            worker = new Thread(start);
            worker.Start();
        }

        private void Working()
        {            
            try
            {
                while (true)
                {
                    MirthService mirthService = new MirthService();

                    mirthService.ProcessXMLMessage().Wait();

                    Thread.Sleep(ScheduleTime * 60 * 1000);
                }
            }
            catch(Exception ex)
            {
                Logger.PrintLog(ex.Message, "Error");
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
                Logger.PrintLog(ex.Message, "Error");
                throw ex;
            }            
        }
    }
}
