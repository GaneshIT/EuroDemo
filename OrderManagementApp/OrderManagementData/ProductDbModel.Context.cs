﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OrderManagementData
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ProductDbEntities : DbContext
    {
        public ProductDbEntities()
            : base("name=ProductDbEntities")
        {
        }
    
        public virtual DbSet<customer> customers { get; set; }
        public virtual DbSet<order> orders { get; set; }
        public virtual DbSet<salesman> salesmen { get; set; }
    }
}
