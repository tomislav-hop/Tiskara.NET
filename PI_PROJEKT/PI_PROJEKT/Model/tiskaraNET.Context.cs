﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PI_PROJEKT.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class tiskaraNETEntities : DbContext
    {
        public tiskaraNETEntities()
            : base("name=tiskaraNETEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<artikli> artikli { get; set; }
        public DbSet<izdatnica> izdatnica { get; set; }
        public DbSet<korisnici> korisnici { get; set; }
        public DbSet<narudzbenica> narudzbenica { get; set; }
        public DbSet<oprema> oprema { get; set; }
        public DbSet<poslovni_partner> poslovni_partner { get; set; }
        public DbSet<primka> primka { get; set; }
        public DbSet<racun> racun { get; set; }
        public DbSet<stavke_izdatnice> stavke_izdatnice { get; set; }
        public DbSet<stavke_narudzbenice> stavke_narudzbenice { get; set; }
        public DbSet<stavke_primke> stavke_primke { get; set; }
        public DbSet<stavke_racuna> stavke_racuna { get; set; }
        public DbSet<vrsta_artikla> vrsta_artikla { get; set; }
    }
}
