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
    
        public virtual DbSet<CPCAnnexureI> CPCAnnexureIs { get; set; }
        public virtual DbSet<CPCAnnexureIDetail> CPCAnnexureIDetails { get; set; }
        public virtual DbSet<CPCDenomination> CPCDenominations { get; set; }
        public virtual DbSet<CPCDepartment> CPCDepartments { get; set; }
        public virtual DbSet<CPCEmployee> CPCEmployees { get; set; }
        public virtual DbSet<CPCProject> CPCProjects { get; set; }
        public virtual DbSet<CPCProjectBranch> CPCProjectBranches { get; set; }
        public virtual DbSet<Vew_CPCAnnexureI> Vew_CPCAnnexureI { get; set; }
        public virtual DbSet<CPCAnnexureIII> CPCAnnexureIIIs { get; set; }
        public virtual DbSet<CPCAnnexureIIIDescriptionCash> CPCAnnexureIIIDescriptionCashes { get; set; }
    }
}
