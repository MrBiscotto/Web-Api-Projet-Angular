﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GroupeA07.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class bddEntities : DbContext
    {
        public bddEntities()
            : base("name=bddEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<auctioned_object> auctioned_object { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<member> member { get; set; }
        public virtual DbSet<moderator> moderator { get; set; }
        public virtual DbSet<seller_user> seller_user { get; set; }
        public virtual DbSet<sold_object> sold_object { get; set; }
    }
}
