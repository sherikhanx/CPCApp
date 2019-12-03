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
    
    public partial class CPCProjectBranch
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CPCProjectBranch()
        {
            this.CPCAnnexureIIs = new HashSet<CPCAnnexureII>();
            this.CPCAnnexureIIIs = new HashSet<CPCAnnexureIII>();
            this.CPCOrderBookingDetails = new HashSet<CPCOrderBookingDetail>();
            this.CPCSortedCashes = new HashSet<CPCSortedCash>();
            this.CPCUnsortedCashes = new HashSet<CPCUnsortedCash>();
            this.CPCAnnexureIDetails = new HashSet<CPCAnnexureIDetail>();
            this.CPCVaultCustodians = new HashSet<CPCVaultCustodian>();
        }
    
        public System.Guid Id { get; set; }
        public string BranchName { get; set; }
        public string BranchCode { get; set; }
        public string Address { get; set; }
        public Nullable<System.Guid> CityId { get; set; }
        public Nullable<System.Guid> RegionId { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public string Phone { get; set; }
        public string ContactPerson { get; set; }
        public Nullable<System.Guid> CPHId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CPCAnnexureII> CPCAnnexureIIs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CPCAnnexureIII> CPCAnnexureIIIs { get; set; }
        public virtual CPCCashProcessingHouse CPCCashProcessingHouse { get; set; }
        public virtual CPCCity CPCCity { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CPCOrderBookingDetail> CPCOrderBookingDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CPCSortedCash> CPCSortedCashes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CPCUnsortedCash> CPCUnsortedCashes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CPCAnnexureIDetail> CPCAnnexureIDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CPCVaultCustodian> CPCVaultCustodians { get; set; }
    }
}
