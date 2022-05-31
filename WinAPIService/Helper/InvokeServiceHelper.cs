using Mirth.Models;
using Newtonsoft.Json;
using System;
using System.Configuration;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;


namespace Mirth.Helper
{
    public static class InvokeServiceHelper
    {
        private static string CVS_API_URL = ConfigurationSettings.AppSettings["CVS_API_URL"];
        private static int responseTimeout = int.Parse(ConfigurationSettings.AppSettings["CVS_API_Response_Timeout"]);
        //private static string HOST = ConfigurationSettings.AppSettings["HOST"];
        //private static string CERT_PATH = ConfigurationSettings.AppSettings["CERT_PATH"];
        //private static string CERT_PASS = ConfigurationSettings.AppSettings["CERT_PASS"];
        //private static bool IsCertificateNeeded = Convert.ToBoolean(ConfigurationSettings.AppSettings["CERTIFICATE_MODE"]);
        //private static bool IS_SSL_REVOCATION_DISABLE = Convert.ToBoolean(ConfigurationSettings.AppSettings["SSL_REVOCATION_DISABLE"]);
        public static string PostCVSAPI(CVSModel cvsModel, string id)
        {
            try
            {
                //ServicePointManager.CheckCertificateRevocationList = false;
                var httpRequest = (HttpWebRequest)WebRequest.CreateHttp(CVS_API_URL);
                                              
                #region Avoid SSL certificate validation
                //if (IS_SSL_REVOCATION_DISABLE)
                //{                    
                //    //httpRequest.ServerCertificateValidationCallback += ValidationServerCertificate;
                //}
                #endregion                                

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
                Logger.log.Info(json);
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
                Logger.log.Error("PostCVSAPI() " + ex.InnerException);
                Logger.log.Error("PostCVSAPI() " + ex.Message);
                Logger.log.Error("PostCVSAPI() " + ex.StackTrace);
                return "false";
            }
        }
    
        public static bool ValidationServerCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            try
            {
                X509Chain ch = new X509Chain();
                ch.ChainPolicy.RevocationMode = X509RevocationMode.NoCheck;

                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
