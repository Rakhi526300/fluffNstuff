﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FluffNStuff.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FluffNStuffEntities : DbContext
    {
        public FluffNStuffEntities()
            : base("name=FluffNStuffEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<admintable> admintables { get; set; }
        public virtual DbSet<category> categories { get; set; }
        public virtual DbSet<invoicetable> invoicetables { get; set; }
        public virtual DbSet<ordertable> ordertables { get; set; }
        public virtual DbSet<sub_category> sub_category { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<usertable> usertables { get; set; }
    }
}