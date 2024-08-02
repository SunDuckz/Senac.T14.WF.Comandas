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
        private bool ehNovo;
        public FrmUsuarios()
        {
            InitializeComponent();
            //metodo que lista os Usuarios
            listarUsuarios();
        }

        private void listarUsuarios()
        {
            // Primeira Etapa
            // conectar no Banco
            using (var banco = new AppDbContext())
            {
                // Segunda Etapa
                // Mesmo que "SELECT * FROM usuarios"
                var usuarios = banco.Usuarios.ToList();

                //Terceira etapa
                //Popular a tabela na tela DataGridView
                dgvUsuarios.DataSource = usuarios;


            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // metodo que irá inserir o usuario no banco
            if (ehNovo)
                CriarUsuario();

            else
                AtualizarUsuario();

            desabilitarCampos();
            listarUsuarios();
            limparCampos();
        }

        private void limparCampos()
        {
            txtId.TextButton = string.Empty;
            txtSenha.TextButton = string.Empty;
            txtEmail.TextButton = string.Empty;
            txtNome.TextButton = string.Empty;
        }

        private void AtualizarUsuario()
        { // consulta um usuario na tabela usando o ID da tela
            using (var banco = new AppDbContext())
            {
                var usuario = banco
                    .Usuarios
                    .Where(e => e.id == int.Parse(txtId.TextButton))
                    .FirstOrDefault();

                usuario.name = txtNome.TextButton;
                usuario.email = txtEmail.TextButton;
                usuario.senha = txtSenha.TextButton;
                banco.SaveChanges();

            }
        }

        private void CriarUsuario()
        {
            //acessar o banco
            using (var banco = new AppDbContext())
            {
                //criar um novo usuario
                var novoUsuario = new Usuario();
                //atribuimos as propriedads ao usúario
                novoUsuario.name = txtNome.TextButton;
                novoUsuario.email = txtEmail.TextButton;
                novoUsuario.senha = txtSenha.TextButton;
                //salvar as alterações(INSERT INTO usuarios)
                banco.Usuarios.Add(novoUsuario);
                banco.SaveChanges();

                //exibir caixa de mensagem!;
                MessageBox.Show("Usuário cadastrado com sucesso!");
            }



        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            ehNovo = true;
            HabilitarCampos();

        }

        private void HabilitarCampos()
        {
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            txtSenha.Enabled = true;
        }
        private void desabilitarCampos()
        {
            txtNome.Enabled = false;
            txtEmail.Enabled = false;
            txtSenha.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            // indica que esta editando um usuario
            ehNovo = false;
            HabilitarCampos();
        }
        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            CarregarUsuarios();
        }


        private void CarregarUsuarios()
        {
            //conectar no banco
            using (var banco = new AppDbContext())
            {
                // Realizar uma consulta na tabela usuarios
                var usuarios = banco.Usuarios.ToList();
                // popular os dados do grid (dataGridView)
                dgvUsuarios.DataSource = usuarios;

            }
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //verifica se o indice da linha é Maior ou igual a 0
            if (e.RowIndex >= 0)
            {
                //obter dados da linha
                var id = dgvUsuarios.Rows[e.RowIndex].Cells["id"].Value.ToString();
                var nome = dgvUsuarios.Rows[e.RowIndex].Cells["name"].Value.ToString();
                var email = dgvUsuarios.Rows[e.RowIndex].Cells["email"].Value.ToString();
                var senha = dgvUsuarios.Rows[e.RowIndex].Cells["Senha"].Value.ToString();

                txtId.TextButton = id;
                txtNome.TextButton = nome;
                txtEmail.TextButton = email;
                txtSenha.TextButton = senha;
            }
        }
    }
}
