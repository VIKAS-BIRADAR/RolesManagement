﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RoleManagement.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class RolesManagementEntities1 : DbContext
    {
        public RolesManagementEntities1()
            : base("name=RolesManagementEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<RoleType> RoleTypes { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
    
        public virtual int spDeleteRole(Nullable<int> r_id)
        {
            var r_idParameter = r_id.HasValue ?
                new ObjectParameter("R_id", r_id) :
                new ObjectParameter("R_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spDeleteRole", r_idParameter);
        }
    
        public virtual ObjectResult<spGetRole_Result> spGetRole()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetRole_Result>("spGetRole");
        }
    
        public virtual ObjectResult<spGetRoles_Result> spGetRoles()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetRoles_Result>("spGetRoles");
        }
    
        public virtual ObjectResult<spGetRoleType_Result> spGetRoleType()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetRoleType_Result>("spGetRoleType");
        }
    
        public virtual int spInsertRole(string r_Name, Nullable<int> r_RoleTypeId, Nullable<System.DateTime> r_EffectiveFrom, Nullable<bool> r_isActive, Nullable<System.DateTime> r_CreateDate, Nullable<System.DateTime> r_ModifyDate)
        {
            var r_NameParameter = r_Name != null ?
                new ObjectParameter("R_Name", r_Name) :
                new ObjectParameter("R_Name", typeof(string));
    
            var r_RoleTypeIdParameter = r_RoleTypeId.HasValue ?
                new ObjectParameter("R_RoleTypeId", r_RoleTypeId) :
                new ObjectParameter("R_RoleTypeId", typeof(int));
    
            var r_EffectiveFromParameter = r_EffectiveFrom.HasValue ?
                new ObjectParameter("R_EffectiveFrom", r_EffectiveFrom) :
                new ObjectParameter("R_EffectiveFrom", typeof(System.DateTime));
    
            var r_isActiveParameter = r_isActive.HasValue ?
                new ObjectParameter("R_isActive", r_isActive) :
                new ObjectParameter("R_isActive", typeof(bool));
    
            var r_CreateDateParameter = r_CreateDate.HasValue ?
                new ObjectParameter("R_CreateDate", r_CreateDate) :
                new ObjectParameter("R_CreateDate", typeof(System.DateTime));
    
            var r_ModifyDateParameter = r_ModifyDate.HasValue ?
                new ObjectParameter("R_ModifyDate", r_ModifyDate) :
                new ObjectParameter("R_ModifyDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spInsertRole", r_NameParameter, r_RoleTypeIdParameter, r_EffectiveFromParameter, r_isActiveParameter, r_CreateDateParameter, r_ModifyDateParameter);
        }
    
        public virtual int spUpdateRole(Nullable<int> r_id, string r_Name, Nullable<int> r_RoleTypeId, Nullable<System.DateTime> r_EffectiveFrom, Nullable<bool> r_isActive, Nullable<System.DateTime> r_CreateDate, Nullable<System.DateTime> r_ModifyDate)
        {
            var r_idParameter = r_id.HasValue ?
                new ObjectParameter("R_id", r_id) :
                new ObjectParameter("R_id", typeof(int));
    
            var r_NameParameter = r_Name != null ?
                new ObjectParameter("R_Name", r_Name) :
                new ObjectParameter("R_Name", typeof(string));
    
            var r_RoleTypeIdParameter = r_RoleTypeId.HasValue ?
                new ObjectParameter("R_RoleTypeId", r_RoleTypeId) :
                new ObjectParameter("R_RoleTypeId", typeof(int));
    
            var r_EffectiveFromParameter = r_EffectiveFrom.HasValue ?
                new ObjectParameter("R_EffectiveFrom", r_EffectiveFrom) :
                new ObjectParameter("R_EffectiveFrom", typeof(System.DateTime));
    
            var r_isActiveParameter = r_isActive.HasValue ?
                new ObjectParameter("R_isActive", r_isActive) :
                new ObjectParameter("R_isActive", typeof(bool));
    
            var r_CreateDateParameter = r_CreateDate.HasValue ?
                new ObjectParameter("R_CreateDate", r_CreateDate) :
                new ObjectParameter("R_CreateDate", typeof(System.DateTime));
    
            var r_ModifyDateParameter = r_ModifyDate.HasValue ?
                new ObjectParameter("R_ModifyDate", r_ModifyDate) :
                new ObjectParameter("R_ModifyDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spUpdateRole", r_idParameter, r_NameParameter, r_RoleTypeIdParameter, r_EffectiveFromParameter, r_isActiveParameter, r_CreateDateParameter, r_ModifyDateParameter);
        }
    
        public virtual int UpdateData(Nullable<int> r_id, string r_Name, Nullable<int> r_RoleTypeId, Nullable<System.DateTime> r_EffectiveFrom, Nullable<int> r_isActive, Nullable<System.DateTime> r_CreateDate, Nullable<System.DateTime> r_ModifyDate)
        {
            var r_idParameter = r_id.HasValue ?
                new ObjectParameter("R_id", r_id) :
                new ObjectParameter("R_id", typeof(int));
    
            var r_NameParameter = r_Name != null ?
                new ObjectParameter("R_Name", r_Name) :
                new ObjectParameter("R_Name", typeof(string));
    
            var r_RoleTypeIdParameter = r_RoleTypeId.HasValue ?
                new ObjectParameter("R_RoleTypeId", r_RoleTypeId) :
                new ObjectParameter("R_RoleTypeId", typeof(int));
    
            var r_EffectiveFromParameter = r_EffectiveFrom.HasValue ?
                new ObjectParameter("R_EffectiveFrom", r_EffectiveFrom) :
                new ObjectParameter("R_EffectiveFrom", typeof(System.DateTime));
    
            var r_isActiveParameter = r_isActive.HasValue ?
                new ObjectParameter("R_isActive", r_isActive) :
                new ObjectParameter("R_isActive", typeof(int));
    
            var r_CreateDateParameter = r_CreateDate.HasValue ?
                new ObjectParameter("R_CreateDate", r_CreateDate) :
                new ObjectParameter("R_CreateDate", typeof(System.DateTime));
    
            var r_ModifyDateParameter = r_ModifyDate.HasValue ?
                new ObjectParameter("R_ModifyDate", r_ModifyDate) :
                new ObjectParameter("R_ModifyDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateData", r_idParameter, r_NameParameter, r_RoleTypeIdParameter, r_EffectiveFromParameter, r_isActiveParameter, r_CreateDateParameter, r_ModifyDateParameter);
        }
    
        public virtual int UpdateRoleData(Nullable<int> r_id, string r_Name, Nullable<int> r_isActive)
        {
            var r_idParameter = r_id.HasValue ?
                new ObjectParameter("R_id", r_id) :
                new ObjectParameter("R_id", typeof(int));
    
            var r_NameParameter = r_Name != null ?
                new ObjectParameter("R_Name", r_Name) :
                new ObjectParameter("R_Name", typeof(string));
    
            var r_isActiveParameter = r_isActive.HasValue ?
                new ObjectParameter("R_isActive", r_isActive) :
                new ObjectParameter("R_isActive", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateRoleData", r_idParameter, r_NameParameter, r_isActiveParameter);
        }
    
        public virtual int spSaveRole(Nullable<int> r_id, string r_Name, Nullable<int> r_RoleTypeId, Nullable<System.DateTime> r_EffectiveFrom)
        {
            var r_idParameter = r_id.HasValue ?
                new ObjectParameter("R_id", r_id) :
                new ObjectParameter("R_id", typeof(int));
    
            var r_NameParameter = r_Name != null ?
                new ObjectParameter("R_Name", r_Name) :
                new ObjectParameter("R_Name", typeof(string));
    
            var r_RoleTypeIdParameter = r_RoleTypeId.HasValue ?
                new ObjectParameter("R_RoleTypeId", r_RoleTypeId) :
                new ObjectParameter("R_RoleTypeId", typeof(int));
    
            var r_EffectiveFromParameter = r_EffectiveFrom.HasValue ?
                new ObjectParameter("R_EffectiveFrom", r_EffectiveFrom) :
                new ObjectParameter("R_EffectiveFrom", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spSaveRole", r_idParameter, r_NameParameter, r_RoleTypeIdParameter, r_EffectiveFromParameter);
        }
    
        public virtual ObjectResult<spGetRolesData_Result> spGetRolesData()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetRolesData_Result>("spGetRolesData");
        }
    
        public virtual ObjectResult<spGetRole1_Result> spGetRole1()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetRole1_Result>("spGetRole1");
        }
    }
}
