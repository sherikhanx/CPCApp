//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CPC.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class CPCOrderBookingDetail
    {
        public System.Guid Id { get; set; }
        public System.Guid OrderbookingId { get; set; }
        public Nullable<System.Guid> ProjectBranchId { get; set; }
        public Nullable<System.Guid> DenominationId { get; set; }
        public Nullable<int> NoOfBundles { get; set; }
        public Nullable<int> TotalAmount { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.Guid CreatedBy { get; set; }
        public Nullable<System.Guid> CashProcessingCellId { get; set; }
        public Nullable<byte> CashCollectionPoint { get; set; }
        public Nullable<byte> CashDeliveryPoint { get; set; }
    
        public virtual CPCOrderBooking CPCOrderBooking { get; set; }
        public virtual CPCProjectBranch CPCProjectBranch { get; set; }
    }
}
