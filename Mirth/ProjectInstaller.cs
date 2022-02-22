using CusWinAPISvcWindow;
using CusWinAPISvcWindow.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Configuration.Install;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Xml;

namespace Mirth
{
    [RunInstaller(true)]
    public partial class ProjectInstaller : System.Configuration.Install.Installer
    {
        private WinAPIConfigProperties _winAPIConfigProp;

        public ProjectInstaller()
        {
            InitializeComponent();
        }


        public override void Install(IDictionary stateSaver)
        {
            try
            {
                log(DateTime.Now.ToString());
                string path1 = Context.Parameters["targetDir"];
                log(path1);

                base.Install(stateSaver);                


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
                _winAPIConfigProp = winAPIConfigProp;
                //UpdateConfigFile(winAPIConfigProp);

                //XmlDocument doc = new XmlDocument();
                //doc.Load(path);
                //XmlNode threadTime = doc.SelectSingleNode("/configuration/appSettings/add[@key='ThreadTime']");
                //threadTime.Attributes[1].Value = winAPIConfigProp.Frequency.ToString();

                //XmlNode Source = doc.SelectSingleNode("/configuration/appSettings/add[@key='Source']");
                //Source.Attributes[1].Value = winAPIConfigProp.SourcePath;

                //XmlNode Destination = doc.SelectSingleNode("/configuration/appSettings/add[@key='Destination']");
                //Destination.Attributes[1].Value = winAPIConfigProp.DestinationPath;

                //XmlNode Type = doc.SelectSingleNode("/configuration/appSettings/add[@key='Type']");
                //Type.Attributes[1].Value = winAPIConfigProp.Type;

                //XmlNode CVS_API_URL = doc.SelectSingleNode("/configuration/appSettings/add[@key='CVS_API_URL']");
                //CVS_API_URL.Attributes[1].Value = winAPIConfigProp.CVSAPIUrl;

                //XmlNode connectionString = doc.SelectSingleNode("/configuration/connectionStrings/add[@name='BacktalkDBEntities']");
                //connectionString.Attributes[1].Value = "metadata=res://*/Repository.BacktalkDB.csdl|res://*/Repository.BacktalkDB.ssdl|res://*/Repository.BacktalkDB.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=" + winAPIConfigProp.ServerName + ";initial catalog=" + winAPIConfigProp.DataSource + ";user id=" + winAPIConfigProp.LoginName + ";password=" + winAPIConfigProp.Password + ";MultipleActiveResultSets=True;App=EntityFramework&quot;";

                //doc.Save(path);
            }
            catch (Exception ex)
            {
                log(ex.Message);
                throw ex;
            }                       

        }

        public override void Commit(IDictionary stateSaver)
        {
            log("Commit");
            base.Commit(stateSaver);

            UpdateConfigFile();
        }

        private void log(string text)
        {
            string path = @"C:\log.text";

            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(text);
            }
        }
        private void UpdateConfigFile()
        {
            //string path = Context.Parameters["targetDir"];

            string path = @"C:\Program Files(x86)\Parata\Windows API Service\Mirth.exe.config";
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            XmlNode threadTime = doc.SelectSingleNode("/configuration/appSettings/add[@key='ThreadTime']");
            threadTime.Attributes[1].Value = _winAPIConfigProp.Frequency.ToString();

            XmlNode Source = doc.SelectSingleNode("/configuration/appSettings/add[@key='Source']");
            Source.Attributes[1].Value = _winAPIConfigProp.SourcePath;

            XmlNode Destination = doc.SelectSingleNode("/configuration/appSettings/add[@key='Destination']");
            Destination.Attributes[1].Value = _winAPIConfigProp.DestinationPath;

            XmlNode Type = doc.SelectSingleNode("/configuration/appSettings/add[@key='Type']");
            Type.Attributes[1].Value = _winAPIConfigProp.Type;

            XmlNode CVS_API_URL = doc.SelectSingleNode("/configuration/appSettings/add[@key='CVS_API_URL']");
            CVS_API_URL.Attributes[1].Value = _winAPIConfigProp.CVSAPIUrl;

            XmlNode connectionString = doc.SelectSingleNode("/configuration/connectionStrings/add[@name='BacktalkDBEntities']");
            connectionString.Attributes[1].Value = "metadata=res://*/Repository.BacktalkDB.csdl|res://*/Repository.BacktalkDB.ssdl|res://*/Repository.BacktalkDB.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=" + _winAPIConfigProp.ServerName + ";initial catalog=" + _winAPIConfigProp.DataSource + ";user id=" + _winAPIConfigProp.LoginName + ";password=" + _winAPIConfigProp.Password + ";MultipleActiveResultSets=True;App=EntityFramework&quot;";

            doc.Save(path);
        }
    }
}
