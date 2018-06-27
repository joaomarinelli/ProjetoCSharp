using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("Materiais")]
    public class Material
    {
        public int MaterialId { get; set; }

        public string MaterialNome { get; set; }

        public string MaterialDesc { get; set; }

        [Required(ErrorMessage ="Campo obrigatorio")]
        public int QuantidadeCadastrada { get; set; }

        public Armazem Local_Armazem { get; set; }
    }
}
