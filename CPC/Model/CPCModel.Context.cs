﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SOSTechCPCEntities : DbContext
    {
        public SOSTechCPCEntities()
            : base("name=SOSTechCPCEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AppUser> AppUsers { get; set; }
        public virtual DbSet<CPCAnnexureI> CPCAnnexureIs { get; set; }
        public virtual DbSet<CPCAnnexureII> CPCAnnexureIIs { get; set; }
        public virtual DbSet<CPCAnnexureIIDetail> CPCAnnexureIIDetails { get; set; }
        public virtual DbSet<CPCAnnexureIII> CPCAnnexureIIIs { get; set; }
        public virtual DbSet<CPCAnnexureIIIDetail> CPCAnnexureIIIDetails { get; set; }
        public virtual DbSet<CPCCashInTransit> CPCCashInTransits { get; set; }
        public virtual DbSet<CPCCashInTransitChild> CPCCashInTransitChilds { get; set; }
        public virtual DbSet<CPCCashInTransitDenomination> CPCCashInTransitDenominations { get; set; }
        public virtual DbSet<CPCCashProcessingHouse> CPCCashProcessingHouses { get; set; }
        public virtual DbSet<CPCCity> CPCCities { get; set; }
        public virtual DbSet<CPCDenomination> CPCDenominations { get; set; }
        public virtual DbSet<CPCDepartment> CPCDepartments { get; set; }
        public virtual DbSet<CPCEmployee> CPCEmployees { get; set; }
        public virtual DbSet<CPCOrderBookingDetail> CPCOrderBookingDetails { get; set; }
        public virtual DbSet<CPCOrderBooking> CPCOrderBookings { get; set; }
        public virtual DbSet<CPCProject> CPCProjects { get; set; }
        public virtual DbSet<CPCProjectBranch> CPCProjectBranches { get; set; }
        public virtual DbSet<CPCSortedCash> CPCSortedCashes { get; set; }
        public virtual DbSet<CPCSortedCashDetail> CPCSortedCashDetails { get; set; }
        public virtual DbSet<CPCUnsortedCash> CPCUnsortedCashes { get; set; }
        public virtual DbSet<CPCUnsortedCashDetail> CPCUnsortedCashDetails { get; set; }
        public virtual DbSet<Vew_Orderbookings> Vew_Orderbookings { get; set; }
        public virtual DbSet<CPCAnnexureIDetail> CPCAnnexureIDetails { get; set; }
        public virtual DbSet<Vew_CPCAnnexureI> Vew_CPCAnnexureI { get; set; }
        public virtual DbSet<CPCVaultCustodian> CPCVaultCustodians { get; set; }
        public virtual DbSet<CPCVaultCustodianDetail> CPCVaultCustodianDetails { get; set; }
    }
}
