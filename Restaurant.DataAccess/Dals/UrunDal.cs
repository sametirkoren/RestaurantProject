using Restaurant.DataAccess.Dals.Base;
using Restaurant.DataAccess.Interfaces;
using Restaurant.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.DataAccess.Dals
{
    public class UrunDal : Repository<Urun> , IUrunDal
    {
        public UrunDal(DbContext context) : base(context)
        {
        }
    }
}
