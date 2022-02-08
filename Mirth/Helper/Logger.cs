using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mirth.Helper
{
    public static class Logger
    {
        private static string path = "C:\\Sample.txt";

        public static void PrintLog(string msg, string type ="info")
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(path, true))
                {
                    writer.WriteLine(String.Format(type + " " + DateTime.Now.ToString() + " " + msg));
                }                
            }
            catch (Exception ex)
            {
                using (StreamWriter writer = new StreamWriter(path, true))
                {
                    writer.WriteLine(String.Format("Error" + " " + DateTime.Now.ToString() + " " + ex.Message));
                }
            }
        }
    }
}
