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
    
    public partial class CPCAnnexureI
    {
        public System.Guid Id { get; set; }
        public Nullable<int> SrNo { get; set; }
        public Nullable<System.Guid> CashHandedOverCPCStaffAId { get; set; }
        public Nullable<System.Guid> CashHandedOverCPCStaffBId { get; set; }
        public Nullable<System.Guid> CashHandedOverCITStaffAId { get; set; }
        public Nullable<System.Guid> CashHandedOverCITStaffBId { get; set; }
        public Nullable<System.Guid> SignatureCPCHandingOverCashAId { get; set; }
        public Nullable<System.Guid> SignatureCPCHandingOverCashBId { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.Guid CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public Nullable<System.Guid> UpdatedBy { get; set; }
        public Nullable<System.DateTime> DateOfCollection { get; set; }
    }
}
