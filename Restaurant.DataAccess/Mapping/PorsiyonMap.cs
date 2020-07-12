using Restaurant.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.DataAccess.Mapping
{
    public class PorsiyonMap : EntityTypeConfiguration<Porsiyon>
    {
        public PorsiyonMap()
        {
            Property(c => c.Adi).HasMaxLength(50);
            Property(c => c.Fiyat).HasPrecision(10, 2);
            Property(c => c.EkMalzemeCarpan).HasPrecision(4, 2);


            ToTable("Porsiyonlar");
            Property(c => c.Adi).HasColumnName("Adi");
            Property(c => c.EkMalzemeCarpan).HasColumnName("Adi");
            Property(c => c.Fiyat).HasColumnName("Fiyat");
            Property(c => c.BirimId).HasColumnName("BirimId");
            Property(c => c.UrunId).HasColumnName("UrunId");

        }
    }
}
