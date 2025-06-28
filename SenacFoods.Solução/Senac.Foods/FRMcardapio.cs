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
    public partial class FRMcardapio : Form
    {
        public FRMcardapio()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void FRMcardapio_Load(object sender, EventArgs e)
        {
            BuscarCardapio();
        }

        private void BuscarCardapio()
        {
            using (var bd = new ComandaDBContext())
            {
                var cardapios = bd.CardapioItems.ToList();
                dataGridView1.DataSource = cardapios;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new FrmCardapioCad().ShowDialog();
        }
    }
}
