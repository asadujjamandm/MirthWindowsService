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
        public static async Task<string> PostCVSAPI(CVSModel cvsModel)
        {
            try
            {                
                var httpRequest = (HttpWebRequest)WebRequest.Create(CVS_API_URL);
                httpRequest.Method = "POST";

                httpRequest.Accept = "application/json";
                httpRequest.ContentType = "application/json";

                var json = JsonConvert.SerializeObject(cvsModel);

                using (var streamWriter = new StreamWriter(await httpRequest.GetRequestStreamAsync()))
                {
                    streamWriter.Write(json);
                }
                Logger.log.Info("PostCVSAPI() calling cvs API");
                var httpResponse = (HttpWebResponse)(await httpRequest.GetResponseAsync());
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
                throw ex;
            }
        }
    }
}
