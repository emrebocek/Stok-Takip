﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjeOdevi.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ProjeOdeviDbEntities : DbContext
    {
        public ProjeOdeviDbEntities()
            : base("name=ProjeOdeviDbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Tbl_Bolum> Tbl_Bolum { get; set; }
        public virtual DbSet<Tbl_Firma> Tbl_Firma { get; set; }
        public virtual DbSet<Tbl_HazirPcParcalari> Tbl_HazirPcParcalari { get; set; }
        public virtual DbSet<Tbl_Kategori> Tbl_Kategori { get; set; }
        public virtual DbSet<Tbl_Kullanici> Tbl_Kullanici { get; set; }
        public virtual DbSet<Tbl_Rol> Tbl_Rol { get; set; }
        public virtual DbSet<Tbl_Stok> Tbl_Stok { get; set; }
        public virtual DbSet<Tbl_Urun> Tbl_Urun { get; set; }
        public virtual DbSet<Tbl_Zimmet> Tbl_Zimmet { get; set; }
    }
}