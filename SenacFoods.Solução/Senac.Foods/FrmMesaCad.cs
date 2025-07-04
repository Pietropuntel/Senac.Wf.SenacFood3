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
    public partial class FrmMesaCad : Form
    {
        public FrmMesaCad()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarMesa1();
        }

        private void SalvarMesa1()
        {
            // conectar
            using (var banco = new ComandaDBContext())
            {
                // captar dados da tel9a
                int numero = int.Parse(txtNumeroMesa.Text);
                // criar um novo cardapio
                var cardapio = new Mesa()
                {
                 NumeroMesa  = numero  
                };
                // adicionar cardapio   // salvar as alterações no banco de dados
                banco.Mesas.Add(cardapio);
                banco.SaveChanges();
            }
            MessageBox.Show("Cardapio salvo com sucesso!",
                "Sucesso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            this.Close();
        }

        private void txtNumeroMesa_TextChanged(object sender, EventArgs e)
        {
            BuscarMesa();
        }

        private void BuscarMesa()
        {
            using (var bd = new ComandaDBContext())
            {
            var mesa = bd.Mesas.AsQueryable();
            dataGridView1.DataSource = mesa.ToList();
             
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
}
