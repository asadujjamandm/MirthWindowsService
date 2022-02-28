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
        private string _targetDirectory;

        public ProjectInstaller()
        {
            InitializeComponent();
        }


        public override void Install(IDictionary stateSaver)
        {
            try
            {
                base.Install(stateSaver);                            
                log(DateTime.Now.ToString());                
                
                this._targetDirectory = Context.Parameters["targetDirectory"];

                log(_targetDirectory);

                
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

                if (!string.IsNullOrEmpty(_targetDirectory))
                {
                    UpdateConfigFile();
                }

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
            //UpdateConfigFile();
            base.Commit(stateSaver);            
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
            try
            {
                string path = Path.Combine(_targetDirectory, "Mirth.exe.config");
                log(path);
                //string path = @"C:\Program Files(x86)\Parata\Windows API Service\Mirth.exe.config";
                XmlDocument doc = new XmlDocument();
                doc.Load(path);
                XmlNode threadTime = doc.SelectSingleNode("/configuration/appSettings/add[@key='ThreadTime']");
                threadTime.Attributes[1].Value = _winAPIConfigProp.Frequency.ToString();

                XmlNode Source = doc.SelectSingleNode("/configuration/appSettings/add[@key='Source']");
                Source.Attributes[1].Value = _winAPIConfigProp.SourcePath;

                XmlNode Destination = doc.SelectSingleNode("/configuration/appSettings/add[@key='Destination']");
                Destination.Attributes[1].Value = _winAPIConfigProp.DestinationPath;

                //XmlNode Type = doc.SelectSingleNode("/configuration/appSettings/add[@key='Type']");
                //Type.Attributes[1].Value = _winAPIConfigProp.Type;

                XmlNode CVS_API_URL = doc.SelectSingleNode("/configuration/appSettings/add[@key='CVS_API_URL']");
                CVS_API_URL.Attributes[1].Value = _winAPIConfigProp.CVSAPIUrl;

                XmlNode connectionString = doc.SelectSingleNode("/configuration/connectionStrings/add[@name='BacktalkDBEntities']");
                string dataConnfig = String.Format("data source={0};initial catalog={1};user id={2};password={3};", _winAPIConfigProp.ServerName, _winAPIConfigProp.DataSource, _winAPIConfigProp.LoginName, _winAPIConfigProp.Password);
                string connString = "metadata=res://*/Repository.BacktalkDB.csdl|res://*/Repository.BacktalkDB.ssdl|res://*/Repository.BacktalkDB.msl;provider=System.Data.SqlClient;provider connection string=\"" 
                                    + dataConnfig 
                                    + "MultipleActiveResultSets=True;App=EntityFramework\"";
                connectionString.Attributes[1].Value = connString;

                log(connString);

                doc.Save(path);
            }
            catch (Exception ex)
            {
                log(ex.Message);
                throw ex;
            }            
        }
    }
}
