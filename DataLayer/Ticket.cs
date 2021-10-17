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
    
    public partial class Ticket
    {
        public string TicketStatusTitle { get; set; }
        public int Id { get; set; }
        public System.DateTime DateShopping { get; set; }
        public string TrackingCode { get; set; }
        public string Subject { get; set; }
        public Nullable<int> ShowTimeId { get; set; }
        public Nullable<System.DateTime> Start { get; set; }
        public Nullable<System.DateTime> End { get; set; }
        public string ConcertTitle { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string HallName { get; set; }
        public string SingerFirstName { get; set; }
        public string SingerLastName { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public Nullable<int> Row { get; set; }
        public Nullable<int> Column { get; set; }
        public string Number { get; set; }
        public int BuyerId { get; set; }
        public Nullable<int> TimeShopping { get; set; }
        public byte TicketStatusId { get; set; }
        public int ChairId { get; set; }
        public Nullable<int> ConcertId { get; set; }
        public string PersianStart { get; set; }
        public string PersianEnd { get; set; }
        public string PersianDateShopping { get; set; }
        public Nullable<int> Price { get; set; }
    }
}