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
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class GA_UMCEntities : DbContext
    {
        public GA_UMCEntities()
            : base("name=GA_UMCEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<PR_ContractLiquite> PR_ContractLiquite { get; set; }
        public virtual DbSet<PR_InputDataToManage> PR_InputDataToManage { get; set; }
    
        public virtual ObjectResult<sp_Get_All_Staff_Result> sp_Get_All_Staff(string deptCode)
        {
            var deptCodeParameter = deptCode != null ?
                new ObjectParameter("deptCode", deptCode) :
                new ObjectParameter("deptCode", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_Get_All_Staff_Result>("sp_Get_All_Staff", deptCodeParameter);
        }
    
        public virtual ObjectResult<sp_Get_All_Staff_2_Result> sp_Get_All_Staff_2()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_Get_All_Staff_2_Result>("sp_Get_All_Staff_2");
        }
    }
}