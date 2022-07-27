using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asm.Models.BaseDB
{
    public class EmpresasModel
    {
        public int ID { get; set; }

        public String NomeEmpresa { get; set; }

        public int CodigoEmpresa { get; set; }

        public int EmpresaAtivaInativa { get; set; }

        public DateTime DataDaCriacao { get; set; }
    }
}