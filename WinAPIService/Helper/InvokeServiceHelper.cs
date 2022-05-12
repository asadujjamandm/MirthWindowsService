using Mirth.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Mirth.Helper
{
    public static class InvokeServiceHelper
    {
        private static string CVS_API_URL = ConfigurationSettings.AppSettings["CVS_API_URL"];
        private static int responseTimeout = int.Parse(ConfigurationSettings.AppSettings["CVS_API_Response_Timeout"]);
        public static string PostCVSAPI(CVSModel cvsModel, string id)
        {
            try
            {                
                var httpRequest = (HttpWebRequest)WebRequest.Create(CVS_API_URL);
                httpRequest.Method = "POST";

                httpRequest.Accept = "application/json";
                httpRequest.ContentType = "application/json";
                httpRequest.Timeout = responseTimeout;

                httpRequest.Headers.Add("version", "1.0");                
                httpRequest.Headers.Add("msgType", "CHECKED");
                httpRequest.Headers.Add("appName", "Backtalk");
                httpRequest.Headers.Add("appMsgId", id);                

                var json = JsonConvert.SerializeObject(cvsModel);

                using (var streamWriter = new StreamWriter(httpRequest.GetRequestStream()))
                {
                    streamWriter.Write(json);
                }
                Logger.log.Info("PostCVSAPI() calling cvs API");
                Logger.log.Info(httpRequest.Headers.AllKeys);
                var httpResponse = (HttpWebResponse)(httpRequest.GetResponse());
                var result = "";
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    result = streamReader.ReadToEnd();
                    Logger.log.Info("PostCVSAPI() Got response from CVS API "+ result);
                    return result;
                }                
            }
            catch (Exception ex)
            {
                Logger.log.Error("PostCVSAPI() " + ex.Message);
                return "false";
            }
        }
    }
}
