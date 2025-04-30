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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
            var formLogin = new FrmLogin();
            formLogin.ShowDialog();
        }

        private void btnCardapios_Click(object sender, EventArgs e)
        {
            var frmCardapio = new FRMcardapio();
            frmCardapio.ShowDialog();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnComanda_Click(object sender, EventArgs e)
        {
            var frmComanda = new FrmComanda();
            frmComanda.ShowDialog();
        }

        private void btnPedidoCozinha_Click(object sender, EventArgs e)
        {
            var frmPedidoCozinha = new FrmPedidoCozinha();
            frmPedidoCozinha.ShowDialog();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            var frmUsuario = new FrmUsuario();
            frmUsuario.ShowDialog();
        }
    }
}
