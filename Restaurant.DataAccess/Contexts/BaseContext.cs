using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.DataAccess.Contexts
{
    public class BaseContext<TContext> : DbContext where TContext : DbContext , new()
    {
        private static string ConnectionString = "";
        public BaseContext():base(ConnectionString)
        {

        }
        public BaseContext(string connectionString) : base(connectionString)
        {
            Configuration.LazyLoadingEnabled = false;
        }
    }
}
