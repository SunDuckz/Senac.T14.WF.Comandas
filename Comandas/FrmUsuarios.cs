using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comandas
{
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // metodo que irá inserir o usuario no banco
            CriarUsuario();

            //AtualizarUsuario();
        }

        private void CriarUsuario()
        {
            //acessar o banco
            using (var banco = new AppDbContext())
            {
                //criar um novo usuario
                var novoUsuario = new Usuario();
                //atribuimos as propriedads ao usúario
                novoUsuario.name = "guilherme'";
                novoUsuario.email = "gui.bampi1@gmail.com";
                novoUsuario.senha = "123";
                //salvar as alterações(INSERT INTO usuarios)
                banco.Usuarios.Add(novoUsuario);
                banco.SaveChanges();

                //exibir caixa de mensagem!;
                MessageBox.Show("Usuário cadastrado com sucesso!");
            }



        }
    }
}
