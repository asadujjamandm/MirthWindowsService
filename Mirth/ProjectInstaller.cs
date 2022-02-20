using CusWinAPISvcWindow;
using CusWinAPISvcWindow.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Mirth
{
    [RunInstaller(true)]
    public partial class ProjectInstaller : System.Configuration.Install.Installer
    {
        WinAPIConfigProperties winAPIConfigProp;

        public ProjectInstaller()
        {
            InitializeComponent();
        }

        public override void Install(IDictionary stateSaver)
        {
            base.Install(stateSaver);

            string path = Context.Parameters["targetDir"];

            WinAPIConfigProperties winAPIConfigProp = new WinAPIConfigProperties();

            DatabaseForm dbForm = new DatabaseForm(ref winAPIConfigProp);
            dbForm.ShowDialog();
            log(winAPIConfigProp.ServerName);
            log(winAPIConfigProp.DataSource);
            log(winAPIConfigProp.LoginName);
            log(winAPIConfigProp.Password); 
            log(winAPIConfigProp.Frequency.ToString());
            log(winAPIConfigProp.SourcePath);
            log(winAPIConfigProp.DestinationPath);
            log(winAPIConfigProp.CVSAPIUrl);

           
        }

        private void log(string text)
        {
            string path = @"C:\log.text";

            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(text);
            }
        }
    }
}
