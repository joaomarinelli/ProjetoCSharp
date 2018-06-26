using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Retirada
    {
        [Key]
        public int RetiradaId { get; set; }

        [Display(Name ="Material a ser retirado")]
        public Material MaterialRetirado { get; set; }
        [Display(Name = "Funcionario")]
        public Funcionario FuncionarioRetirada { get; set; }
        [Display(Name = "Quantidade a ser retirado")]
        [Required]
        public int QuantidadeRetirada { get; set; }

        public DateTime DataRetirada { get; set; }
    }
}
