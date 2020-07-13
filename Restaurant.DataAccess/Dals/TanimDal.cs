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
    public class TanimDal : Repository<Tanim>, ITanimDal
    {
        public TanimDal(DbContext context) : base(context)
        {
        }
    }
}
