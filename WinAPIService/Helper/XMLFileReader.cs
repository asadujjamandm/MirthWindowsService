using Mirth.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Mirth.Helper
{
    public class XMLFileReader
    {
        private string BacktalkInvPath = ConfigurationSettings.AppSettings["Source"];
        private string BacktalkInvArchived = ConfigurationSettings.AppSettings["Destination"];
        private string FileType = ConfigurationSettings.AppSettings["Type"];

        public async Task<List<AutomationRxEvent>> GetXMLFileContent()
        {
            try
            {
                List<string> fileNames = new List<string>();
                fileNames = GetListOfFile();

                var AutomationRxEventList = new List<AutomationRxEvent>();

                foreach (var file in fileNames)
                {
                    try
                    {
                        Logger.log.Info(file + "  Processing");
                        string xmlString = File.ReadAllText(file);

                        XmlSerializer serializer = new XmlSerializer(typeof(AutomationRxEvent), new XmlRootAttribute("AutomationRxEvent"));
                        StringReader stringReader = new StringReader(xmlString);
                        AutomationRxEvent automationRxEvent = (AutomationRxEvent)serializer.Deserialize(stringReader);
                        automationRxEvent.FilePath = file;
                        AutomationRxEventList.Add(automationRxEvent);

                        Logger.log.Info(file + "  Processing Completed.");
                    }
                    catch (Exception ex)
                    {
                        Logger.log.Error(file + " " + ex.Message);
                        continue;
                    }                                        
                }

                return AutomationRxEventList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void RemoveFile(string file)
        {
            try
            {
                string fName = Path.GetFileName(file);
                string destinationFile = String.Concat(this.BacktalkInvArchived,"\\", fName);
                
                if (File.Exists(destinationFile))
                {
                    File.Delete(destinationFile);
                }

                File.Move(file, destinationFile);

                Logger.log.Info(file + " Moved to Archived.");
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<string> GetListOfFile()
        {
            try
            {
                string[] filePaths = Directory.GetFiles(BacktalkInvPath, FileType);

                return filePaths.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
