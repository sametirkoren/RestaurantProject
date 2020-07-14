using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Restaurant.Entities.Tables;
using Restaurant.Entities.Tables.Base;
using Restaurant.DataAccess.Mapping;

namespace Restaurant.DataAccess.Contexts.Restaurant
{
    public class RestaurantContext : BaseContext<RestaurantContext>
    {
        public RestaurantContext()
        {
        }

        public RestaurantContext(string connectionString) : base(connectionString)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<RestaurantContext, RestaruantConfiguration>());   
        }

        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Tanim> Tanimlar { get; set; }
        public DbSet<Porsiyon> Porsiyonlar { get; set; }
        public DbSet<EkMalzeme> EkMalzemeler { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Types<EntityBase>().Configure(c =>
            {
                c.HasKey(e => e.Id);
                c.Property(e => e.Ekleyen).HasMaxLength(30);
                c.Property(e => e.Duzenleyen).HasMaxLength(30);
                c.Property(e => e.Aciklama).HasMaxLength(200);

                c.Property(e => e.Id).HasColumnName("Id");
                c.Property(e => e.Duzenleyen).HasColumnName("Duzenleyen");
                c.Property(e => e.Ekleyen).HasColumnName("Ekleyen");
                c.Property(e => e.Aciklama).HasColumnName("Aciklama");
                c.Property(e => e.DuzenlenmeTarihi).HasColumnName("DuzenlenmeTarihi");
                c.Property(e => e.EklenmeTarihi).HasColumnName("EklenmeTarihi");
            });

            modelBuilder.Entity<Porsiyon>().HasRequired(c => c.Urun).WithMany(c => c.Porsiyonlar).HasForeignKey(c => c.UrunId);
            modelBuilder.Entity<EkMalzeme>().HasRequired(c => c.Urun).WithMany(c => c.EkMalzemeler).HasForeignKey(c => c.UrunId);
            modelBuilder.Entity<Urun>().HasRequired(c => c.UrunGrup).WithOptional().Map(c => c.MapKey("UrunGrupId"));
            modelBuilder.Entity<Porsiyon>().HasRequired(c => c.Birim).WithOptional().Map(c => c.MapKey("BirimId"));


            modelBuilder.Configurations.Add(new UrunMap());
            modelBuilder.Configurations.Add(new TanimMap());
            modelBuilder.Configurations.Add(new PorsiyonMap());
            modelBuilder.Configurations.Add(new EkMalzemeMap());
        }
    }
}
