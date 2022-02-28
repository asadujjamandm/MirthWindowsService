using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CusWinAPISvcWindow.Models
{
    public class WinAPIConfigProperties
    {
        public bool WindowsAuthentication { get; set; }
        public string ServerName { get; set; }
        public string DataSource { get; set; }
        public string LoginName { get; set; }
        public string Password { get; set; }        
        public int Frequency { get; set; }
        public string SourcePath { get; set; }
        public string DestinationPath { get; set; }
        public string Type { get; set; }
        public string CVSAPIUrl { get; set; }
    }
}
