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
    
    public partial class CPCDenomination
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CPCDenomination()
        {
            this.CPCAnnexureIDetails = new HashSet<CPCAnnexureIDetail>();
            this.CPCAnnexureIIDetails = new HashSet<CPCAnnexureIIDetail>();
            this.CPCCashInTransitDenominations = new HashSet<CPCCashInTransitDenomination>();
            this.CPCSortedCashDetails = new HashSet<CPCSortedCashDetail>();
            this.CPCUnsortedCashDetails = new HashSet<CPCUnsortedCashDetail>();
            this.CPCVaultCustodianDetails = new HashSet<CPCVaultCustodianDetail>();
            this.CPCVaultConsolidatedDetails = new HashSet<CPCVaultConsolidatedDetail>();
        }
    
        public System.Guid Id { get; set; }
        public Nullable<int> DenominationTitle { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CPCAnnexureIDetail> CPCAnnexureIDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CPCAnnexureIIDetail> CPCAnnexureIIDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CPCCashInTransitDenomination> CPCCashInTransitDenominations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CPCSortedCashDetail> CPCSortedCashDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CPCUnsortedCashDetail> CPCUnsortedCashDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CPCVaultCustodianDetail> CPCVaultCustodianDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CPCVaultConsolidatedDetail> CPCVaultConsolidatedDetails { get; set; }
    }
}
