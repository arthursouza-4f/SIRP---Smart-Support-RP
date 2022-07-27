using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asm.Models.BaseDB
{
    public class VendasModel
    {
        public int ID { get; set; }

        public String NomeItem { get; set; }

        public int QuantidadeVendida { get; set; }

        public decimal PrecoVendido { get; set; }

        public DateTime DataDaVenda { get; set; }
    }
}