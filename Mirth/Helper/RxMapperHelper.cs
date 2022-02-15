using Mirth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mirth.Helper
{
    public static class RxMapperHelper
    {
        public static CVSModel MapCVSModel(RxTransaction rxTransaction)
        {
            try
            {
                CVSModel cvsModel = new CVSModel();

                cvsModel.rxVialBarcode = rxTransaction.BarCode.ToString();
                cvsModel.rphEmployeeID = rxTransaction.PMSID;
                cvsModel.verifyDateTime = rxTransaction.CheckedDateTime;
                cvsModel.drugNDCFilled = rxTransaction.CustomerNDC;
                cvsModel.drugQtyDispensed = rxTransaction.RXQuantity;
                cvsModel.rxNumber = rxTransaction.CustomerRXID;
                cvsModel.cvsStoreNumber = rxTransaction.StoreNumber;
                cvsModel.fillNumber = rxTransaction.FillNumber;
                cvsModel.editVersion = rxTransaction.EditVersion;
                cvsModel.partialFill = rxTransaction.PartialFill;

                return cvsModel;

                Logger.log.Info("MapCVSModel() Mapping CVS Model has been Completed");
            }
            catch (Exception ex)
            {
                Logger.log.Error("ProcessXMLMessage() " + ex.Message);
                throw ex;
            }            
        }
    }
}
