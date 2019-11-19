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
    
    public partial class CPCCashInTransit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CPCCashInTransit()
        {
            this.CPCCashInTransitChilds = new HashSet<CPCCashInTransitChild>();
        }
    
        public System.Guid Id { get; set; }
        public string CustomerToBeBilled { get; set; }
        public int ShipmentReceiptNumber { get; set; }
        public string Collection { get; set; }
        public Nullable<System.DateTime> CollectionDateTime { get; set; }
        public Nullable<System.DateTime> DeliveryDateTime { get; set; }
        public string Delivery { get; set; }
        public string VehicleNumber { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string AcCode { get; set; }
        public string WaitingTime { get; set; }
        public Nullable<int> NumberOfPlasticLeadSeals { get; set; }
        public Nullable<int> NumberOfBags { get; set; }
        public Nullable<int> DaysInVault { get; set; }
        public Nullable<int> NumberOfWagePackets { get; set; }
        public Nullable<int> NumberOfAdditionalService { get; set; }
        public Nullable<System.Guid> ConsignedByNameA { get; set; }
        public Nullable<System.Guid> ConsignedByNameB { get; set; }
        public Nullable<System.Guid> AcceptedByNameA { get; set; }
        public Nullable<System.Guid> AcceptedByNameB { get; set; }
        public Nullable<System.Guid> ReceivedByNameA { get; set; }
        public Nullable<System.Guid> ReceivedByNameB { get; set; }
        public Nullable<int> DetailDenomination5000 { get; set; }
        public Nullable<int> DetailDenomination1000 { get; set; }
        public Nullable<int> DetailDenomination500 { get; set; }
        public Nullable<int> DetailDenomination100 { get; set; }
        public Nullable<int> DetailDenomination50 { get; set; }
        public Nullable<int> DetailDenomination20 { get; set; }
        public Nullable<int> DetailDenomination10 { get; set; }
        public Nullable<int> DetailDenomination5 { get; set; }
        public Nullable<int> DetailDenomination2 { get; set; }
        public Nullable<int> DetailDenomination1 { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.Guid CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public Nullable<System.Guid> UpdatedBy { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CPCCashInTransitChild> CPCCashInTransitChilds { get; set; }
    }
}
