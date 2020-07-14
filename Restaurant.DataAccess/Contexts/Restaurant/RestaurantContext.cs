﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Restaurant.Entities.Tables;
using Restaurant.Entities.Tables.Base;

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
        }
    }
}
