//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DersRehberi.Entities.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DersRehberiEntities : DbContext
    {
        public DersRehberiEntities()
            : base("name=DersRehberiEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Adresler> Adresler { get; set; }
        public virtual DbSet<Branslar> Branslar { get; set; }
        public virtual DbSet<Dereceler> Dereceler { get; set; }
        public virtual DbSet<Dersler> Dersler { get; set; }
        public virtual DbSet<DogruSecenekler> DogruSecenekler { get; set; }
        public virtual DbSet<Ilceler> Ilceler { get; set; }
        public virtual DbSet<IletisimBilgileri> IletisimBilgileri { get; set; }
        public virtual DbSet<Kazanimlar> Kazanimlar { get; set; }
        public virtual DbSet<Kisiler> Kisiler { get; set; }
        public virtual DbSet<KonuAnlatimlari> KonuAnlatimlari { get; set; }
        public virtual DbSet<KonuAnlatimTurleri> KonuAnlatimTurleri { get; set; }
        public virtual DbSet<KonuAnlatimVerileri> KonuAnlatimVerileri { get; set; }
        public virtual DbSet<Konular> Konular { get; set; }
        public virtual DbSet<Ogrenciler> Ogrenciler { get; set; }
        public virtual DbSet<Okullar> Okullar { get; set; }
        public virtual DbSet<Personeller> Personeller { get; set; }
        public virtual DbSet<SecenekAnlatimTurleri> SecenekAnlatimTurleri { get; set; }
        public virtual DbSet<Secenekler> Secenekler { get; set; }
        public virtual DbSet<SecenekVerileri> SecenekVerileri { get; set; }
        public virtual DbSet<Sehirler> Sehirler { get; set; }
        public virtual DbSet<Sinavlar> Sinavlar { get; set; }
        public virtual DbSet<Siniflar> Siniflar { get; set; }
        public virtual DbSet<SoruAnlatimTurleri> SoruAnlatimTurleri { get; set; }
        public virtual DbSet<Sorular> Sorular { get; set; }
        public virtual DbSet<SoruVerileri> SoruVerileri { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TesteBagliSorular> TesteBagliSorular { get; set; }
        public virtual DbSet<Testler> Testler { get; set; }
        public virtual DbSet<Uniteler> Uniteler { get; set; }
        public virtual DbSet<Unvanlar> Unvanlar { get; set; }
        public virtual DbSet<Veliler> Veliler { get; set; }
        public virtual DbSet<Duyurular> Duyurular { get; set; }
    }
}
