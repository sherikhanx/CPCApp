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
    
    public partial class CPCSortedCashDetail
    {
        public System.Guid Id { get; set; }
        public System.Guid DenominationId { get; set; }
        public System.Guid SortedCashId { get; set; }
        public int NumberOfBundles { get; set; }
        public int TotalValue { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.Guid CreatedBy { get; set; }
    
        public virtual CPCDenomination CPCDenomination { get; set; }
        public virtual CPCSortedCash CPCSortedCash { get; set; }
    }
}
