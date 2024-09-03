using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comandas
{
    public class Cardapio
    {

        
        [Key] //definir como primary key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //auto incremento
        public int id { get; set; }
        [Required]
        public string titulo { get; set; } = string.Empty;
        [Required]
        public string descricao { get; set; } = string.Empty;
        [Required]
        public decimal preco { get; set; } = decimal.Zero;
        public bool PossuiPreparo {  get; set; } = false;
    }
}
