using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mirth.Models
{
    public class CVSModel
    {
        public String rxVialBarcode { get; set; }
        public int rphEmployeeID { get; set; }
        public String drugNDCFilled { get; set; }
        public decimal drugQtyDispensed { get; set; }
        public string rxNumber { get; set; }
        public int cvsStoreNumber { get; set; }
        public string verifyDateTime { get; set; }
        public String fillNumber { get; set; }
        public String editVersion { get; set; }
        public String partialFill { get; set; }
    }
}
