
using Microsoft.EntityFrameworkCore;

namespace Comandas
{   //classe que representa o banco de dados
    public class AppDbContext : DbContext
    {
        //propriedade que representa a tabela Usuarios
        public DbSet<Usuario> Usuarios { get; set; }

        //propriedade que representa a tabela Cardapios
        public DbSet<Cardapio> Cardapios { get; set; }

        // métodos que configura informando para o Entity Framework que o banco será SQLite
        protected override void OnConfiguring(DbContextOptionsBuilder
       optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=comandas.db");
        }
    }

}
