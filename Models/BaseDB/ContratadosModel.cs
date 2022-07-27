using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asm.Models.BaseDB
{
    public class ContratadosModel
    {
        public int ID { get; set; }

        public string Nome { get; set; }

        public string NomeEmpresa { get; set; }

        public int CodigoEmpresa { get; set; }

        public int AtivoInativo { get; set; }

    }
}