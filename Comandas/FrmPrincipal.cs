using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace Comandas
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            CriarBancoDeDados();
        }

        // método (visibilidade = private, retorno = void)
        private void CriarBancoDeDados()
        {
            // criar uma variavel do tipo AppDbContext
            // usar a variavel e acessar o contexto
            // executar a migração == F5
            using (var banco = new AppDbContext())
            {
                // executa a migração (CREATE TABLE Usuarios)
                banco.Database.Migrate();
            }




        }

        //evento de clique
        private void btnCardapio_Click(object sender, EventArgs e)
        {
            //criar o formulario e o exibe
            new FrmCardapio().ShowDialog();
        }

        private void btnComanda_Click(object sender, EventArgs e)
        {
            new FrmComanda().ShowDialog();
        }

        private void btnPedidoCozinha_Click(object sender, EventArgs e)
        {
            new FrmPedidoCozinha().ShowDialog();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            new FrmUsuarios().ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //encerra o aplicativo
            Application.Exit();
        }

    }
}