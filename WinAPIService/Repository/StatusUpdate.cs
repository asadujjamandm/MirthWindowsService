//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WinAPIService.Repository
{
    using System;
    using System.Collections.Generic;
    
    public partial class StatusUpdate
    {
        public int UpdateStatusID { get; set; }
        public decimal BatchID { get; set; }
        public Nullable<int> PouchNumber { get; set; }
        public string RxNumber { get; set; }
        public string NDC { get; set; }
        public string Barcode { get; set; }
        public decimal RXQuantity { get; set; }
        public Nullable<int> StoreNumber { get; set; }
        public string FillNumber { get; set; }
        public string EditVersion { get; set; }
        public string PartialFill { get; set; }
        public bool Checked { get; set; }
        public int CheckedBy { get; set; }
        public System.DateTime CheckedDateTime { get; set; }
        public bool XMLGenerated { get; set; }
        public bool CVSAcknowlogement { get; set; }
    }
}
