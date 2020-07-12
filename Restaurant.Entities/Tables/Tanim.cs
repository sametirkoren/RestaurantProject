using Restaurant.Entities.Enums;
using Restaurant.Entities.Tables.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Entities.Tables
{
    public class Tanim : EntityBase
    {
        public string Adi { get; set; }

        public TanimTip TanimTip { get; set; }
    }
}
