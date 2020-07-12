using Restaurant.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Entities.Tables.Base
{
    public class EntityBase : IEntity
    {
        public Guid Id{ get; set; }

        public string Ekleyen { get; set; }
        public DateTime EklenmeTarihi { get; set; }

        public string Duzenleyen { get; set; }

        public DateTime DuzenlenmeTarihi { get; set; }

        public string Aciklama { get; set; }
    }
}
