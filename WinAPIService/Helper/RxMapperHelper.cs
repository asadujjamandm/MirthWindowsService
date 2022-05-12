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
        public static CVSModel MapCVSModel(AutomationRxEvent automationRxEvent)
        {
            try
            {
                CVSModel cvsModel = new CVSModel();

                cvsModel.rxVialBarcode = automationRxEvent.RxTransaction.BarCode.ToString();
                cvsModel.rphEmployeeID = automationRxEvent.RxTransaction.PMSID;
                cvsModel.verifyDateTime = automationRxEvent.RxTransaction.CheckedDateTime;
                cvsModel.drugNDCFilled = automationRxEvent.RxTransaction.CustomerNDC;
                cvsModel.drugQtyDispensed = automationRxEvent.RxTransaction.RXQuantity;
                cvsModel.rxNumber = automationRxEvent.RxTransaction.CustomerRXID;
                cvsModel.cvsStoreNumber = automationRxEvent.RxTransaction.StoreNumber;
                cvsModel.fillNumber = automationRxEvent.RxTransaction.FillNumber;
                cvsModel.editVersion = automationRxEvent.RxTransaction.EditVersion;
                cvsModel.partialFillSequence = automationRxEvent.RxTransaction.PartialFill;                

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
