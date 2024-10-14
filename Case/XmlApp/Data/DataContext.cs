using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
using XmlApp.Models.Fields;

namespace XmlApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<SBIFBilgileri> SBIFBilgileri { get; set; }
        public DbSet<GenelBilgiler> GenelBilgiler { get; set; }
        public DbSet<FaturaBilgileri> FaturaBilgileri { get; set; }
        public DbSet<MalKalemBilgileri> MalKalemBilgileri { get; set; }
        public DbSet<TalepEdilenIsleticiHizmetleri> TalepEdilenIsleticiHizmetleri { get; set; }
        public DbSet<SbifBilgiFisi> SbifBilgiFisi { get; set; }
        public DbSet<MalKalem> MalKalemler { get; set; }
        public DbSet<Fatura> Faturalar { get; set; }
        public DbSet<KarsiFirmaBilgisi> KarsiFirmaBilgileri { get; set; }
        public DbSet<SevkiyatSekli> SevkiyatSekli { get; set; }
        public DbSet<TeslimAdresi> TeslimAdresi { get; set; }
        public DbSet<IslemKonusuBilgileri> IslemKonusuBilgileri { get; set; }
        public DbSet<IslemTuruBilgileri> IslemTuruBilgileri { get; set; }
        public DbSet<IslemYonuBilgileri> IslemYonuBilgileri { get; set; }
        public DbSet<GumrukMudurluguOnayi> gumrukMudurluguOnayi { get; set; }
        public DbSet<GumrukMuhafazaMudurluguOnayi> gumrukMuhafazaMudurluguOnayi { get; set; }
        public DbSet<SbifGumrukBilgileri> sbifGumrukBilgileri { get; set; }
        public DbSet<FonDekont> FonDekont { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SBIFBilgileri>()
                .HasOne(s => s.GenelBilgiler);

            modelBuilder.Entity<SBIFBilgileri>()
                .HasOne(s => s.FaturaBilgileri);

            modelBuilder.Entity<SBIFBilgileri>()
                .HasOne(s => s.MalKalemBilgileri);

            modelBuilder.Entity<SBIFBilgileri>()
                .HasOne(s => s.TalepEdilenIsleticiHizmetleri);

            modelBuilder.Entity<SBIFBilgileri>()
                .HasOne(s => s.SbifBilgiFisi);

            modelBuilder.Entity<SBIFBilgileri>()
               .HasOne(s => s.SbifGumrukBilgileri);

            modelBuilder.Entity<KarsiFirmaBilgisi>(entity =>
            {
                entity.HasKey(e => e.AdiUnvani);
                entity.ToTable("KarsiFirmaBilgileri");
            });

            modelBuilder.Entity<TeslimAdresi>(entity =>
            {
                entity.HasKey(e => e.AdiTicaretUnvani);

                entity.ToTable("TeslimAdresi");

            });
            modelBuilder.Entity<SBIFBilgileri>()
       .HasOne(s => s.SbifBilgiFisi)
       .WithMany()
       .HasForeignKey(s => s.SbifBilgiFisiId);

            modelBuilder.Entity<SBIFBilgileri>()
                    .HasOne(s => s.SbifGumrukBilgileri)
                    .WithMany()
                    .HasForeignKey(s => s.SbifGumrukBilgileriId);


        }
    }
}
