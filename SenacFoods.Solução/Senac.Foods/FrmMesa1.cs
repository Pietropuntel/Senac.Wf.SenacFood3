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
    public partial class FrmMesa1 : Form
    {
        public FrmMesa1()
        {
            InitializeComponent();
        }

        private void FrmMesa1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            new FrmMesaCad().ShowDialog();
            BuscarMesa();
        }

        private void BuscarMesa()
        {
            using (var bd = new ComandaDBContext())
            {
                var cardapios = bd.CardapioItems.AsQueryable();
                if (!string.IsNullOrEmpty(txtPesquisa.Text))
                {
                    // filtrar cardapios pelo titulo
                    cardapios = cardapios.Where(c => c.Titulo.Contains(txtPesquisa.Text) ||
                                                      c.Descricao.Contains(txtPesquisa.Text));
                }
                dataGridView1.DataSource = cardapios.ToList();
            }
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
