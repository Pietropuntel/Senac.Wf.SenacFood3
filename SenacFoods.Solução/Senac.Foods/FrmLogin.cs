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
                    .FirstOrDefault(u => u. Email == nome.ToLower() && u.Senha == senha);
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
    }
}
