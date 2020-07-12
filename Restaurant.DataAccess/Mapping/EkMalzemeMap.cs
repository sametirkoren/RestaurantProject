using Restaurant.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.DataAccess.Mapping
{
    public class EkMalzemeMap : EntityTypeConfiguration<EkMalzeme>
    {
        public EkMalzemeMap()
        {
            Property(c => c.Adi).HasMaxLength(50);
            Property(c => c.Fiyat).HasPrecision(10, 2);


            ToTable("EkMalzemeler");
            Property(c => c.Adi).HasColumnName("Adi");
            Property(c => c.Fiyat).HasColumnName("Fiyat");
            Property(c => c.UrunId).HasColumnName("UrunId");
        }
    }
}
