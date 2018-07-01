using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class Retirada
    {
        public int RetiradaId { get; set; }

        public Material MaterialRetirado { get; set; }

        public Funcionario FuncionarioRetirada { get; set; }

        public int QuantidadeRetirada { get; set; }

        public DateTime DataRetirada { get; set; }

    }
}
