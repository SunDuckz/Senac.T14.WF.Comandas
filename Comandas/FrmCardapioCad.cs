using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comandas
{
    public partial class FrmCardapioCad : Form
    { // variavel que indica se esta criando um novo cardapio
      // variavel type bool = (true, false)
        bool ehNovo = false;
        public FrmCardapioCad(bool acao)
        {
            ehNovo = acao;
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // se o form está em  modo de inclusão
            if (ehNovo)
            {
                // Executa o metodo que realiza o INSERT na tabela
                AdicionarCardapio();
            }
            else
            {
                // Senão executa o método que realiza o UPDATE na tabela
                AtualizarCardapio();
            }
            // fecha a tela (frmCardapioCad)
            Close();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void AtualizarCardapio()
        {
            using (var banco = new AppDbContext())
            {
                var cardapio = banco.Cardapios.FirstOrDefault(f => f.id == int.Parse(txtId.TextButton));

                cardapio.titulo = txtTitulo.TextButton;
                cardapio.descricao = txtDescricao.TextButton;
                cardapio.preco = decimal.Parse(txtPreco.TextButton);
                cardapio.PossuiPreparo = cbPossuiPreparo.Checked;
                banco.SaveChanges();
                
            }

        }

        private void AdicionarCardapio()
        {

            // usar o banco de dados
            // cria uma variavel banco que instancia uma conexao com BD (banco de dados)
            using ( var banco = new AppDbContext() )
            {
                var novoCardapio = new Cardapio()
                {
                    titulo = txtTitulo.TextButton,
                    descricao = txtDescricao.TextButton,
                    preco = decimal.Parse(txtPreco.TextButton),
                    PossuiPreparo = cbPossuiPreparo.Checked
                };
                // cria o SQL de INSERT
                banco.Cardapios.Add(novoCardapio);
                //confirma as alterações
                banco.SaveChanges();
            }    
        }


    }
}