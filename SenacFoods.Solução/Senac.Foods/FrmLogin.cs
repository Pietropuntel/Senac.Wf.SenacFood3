using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Senac.Foods
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //true,false
            bool loginValido = ValidarLogin(txtLogin.Text, txtSenha.Text);
            // se true
            if (loginValido)
            {
                this.Hide();
                var formPrincipal = new FrmPrincipal(txtLogin.Text, txtSenha.Text);
                formPrincipal.Show();
            }
        }
        private bool ValidarLogin(string nome, string senha)
        {
            bool usuarioValido = false;
            using (var banco = new ComandaDBContext())
            {

                var usuario = banco
                    .Usuarios
                    .FirstOrDefault(u => u.Email == nome.ToLower() && u.Senha == senha);
                if (usuario is not null)
                    usuarioValido = true;

            }
            // se nome é igual a admin e senha é igual a 123
            if (usuarioValido)
            { //Returna verdadeiro
                return true;
            }
            else
            {  //Exibe mensagem de erro
                MessageBox.Show("Login ou senha inválidos");
            } //Retorna false
            return false;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtLogin_Enter(object sender, EventArgs e)
        {
            if (txtLogin.Text == "Usuário")
            {
                txtLogin.Text = "";
                txtLogin.ForeColor = Color.White;
            }
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            if (txtSenha.Text == "Senha")
            {
                txtSenha.Text = "";
                txtSenha.ForeColor = Color.White;
            }
        }

        private void btnEntrar_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                object btnEntrarClick = button.PerformClick();

            }
        }

        internal class button
        {
            internal static object PerformClick()
            {
                throw new NotImplementedException();
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnEntrar_Click(sender, e);
            }
        }
    }
}