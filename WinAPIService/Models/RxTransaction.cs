using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mirth.Models
{
    public class RxTransaction
    {
		public string CustomerRXID { get; set; }
		public double BarCode { get; set; }
		public int StoreNumber { get; set; }
		public string CustomerNDC { get; set; }
		public decimal RXQuantity { get; set; }
		public int PMSID { get; set; }
		public string CheckedDateTime { get; set; }
		public string FillNumber { get; set; }
		public string EditVersion { get; set; }
		public string PartialFill { get; set; }
        public int UpdateStatusID { get; set; }
    }
}
