﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UMCLocker
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class UMCLOCKEREntities : DbContext
    {
        public UMCLOCKEREntities()
            : base("name=UMCLOCKEREntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Dept> Depts { get; set; }
        public virtual DbSet<history> histories { get; set; }
        public virtual DbSet<Locker> Lockers { get; set; }
        public virtual DbSet<Pos> Pos { get; set; }
        public virtual DbSet<Sho> Shoes { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }
        public virtual DbSet<Member> Members { get; set; }
    }
}
