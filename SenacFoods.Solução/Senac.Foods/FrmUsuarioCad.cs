using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Senac.Foods
{
    public partial class FrmUsuarioCad : Form
    {
        Usuario? _usuario;
        public FrmUsuarioCad()
        {
            InitializeComponent();
        }

        public FrmUsuarioCad(Usuario usuario)
        {
            _usuario =usuario;
            InitializeComponent();
            // carregar os dados do cardapio selecionado
            CarregarDadosDaTela();
        }

        private void CarregarDadosDaTela()
        {
            // popular os campos de texto e chekbox 
            if (_usuario != null)
            {
                txtNomeDoUsuario.Text = _usuario.Nome;
                txtEmail.Text = _usuario.Email;
                txtSenha.Text = _usuario.Senha ;
                txtConfirmacaoDeSenha.Text = _usuario._Senha;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (Usuario == null)
            {
                InserirUsuario();
            }
            else
            {
                AtualizarUsuario();
            }

        }

        private void AtualizarUsuario()
        {
            using (var banco = new UsuarioContext())
            {
                string titulo = txtTitulo.Text;
                string descricao = txtDescricao.Text;
                decimal.TryParse(txtPreco.Text, out var preco);
                bool possuiPreparo = chkPossuiPreparo.Checked;
                // Atualizar o cardapio
                var FrmUsuario = banco.Usuarios.First(x => x.Id == _cardapioItem.Id);
                FrmUsuario.Titulo = titulo;
                FrmUsuario.Descricao = descricao;
                FrmUsuario.Preco = preco;
                FrmUsuario.PossuiPreparo = possuiPreparo;
                //salvar as alteraçoesno banco
                banco.Usuarios.Update(FrmUsuario);
                banco.SaveChanges();
                MessageBox.Show("Cardapio salvo com sucesso!",
                "Sucesso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                this.Close();
            }

        }
    }

}
