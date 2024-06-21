using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Comandas
{
    public class Usuario
    {
        //propriedades da classe
        //colunas da tabela Usu
        [Key] // Chave primária
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // auto incremento
        public int id { get; set; }
        [Required]
        public string name { get; set; } = string.Empty;
        [Required]
        public string email { get; set; } = string.Empty;
        [Required]
        public string senha { get; set; } = string.Empty;


    }
}
