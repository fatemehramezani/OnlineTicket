//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Payment
    {
        public int BuyerId { get; set; }
        public string TrackingCode { get; set; }
        public System.DateTime Date { get; set; }
        public string State { get; set; }
        public bool IsSuccess { get; set; }
        public string TraceNo { get; set; }
        public int Id { get; set; }
        public int BankId { get; set; }
        public Nullable<int> Price { get; set; }
        public string RefNum { get; set; }
    }
}