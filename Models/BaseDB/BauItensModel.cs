using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asm.Models.BaseDB
{
    public class BauItens
    {
        public int ID { get; set; }

        public String NomeItem { get; set; }

        public int QuantidadeItem { get; set; }

        public DateTime DataAlteracaoBau { get; set; }

        public int CodigoDaAlteracao { get; set; }
    }
}