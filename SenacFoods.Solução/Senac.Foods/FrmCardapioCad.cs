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
    public partial class FrmCardapioCad : Form
    {
        public FrmCardapioCad()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarCardapio();
        }

        private void SalvarCardapio()
        {
            // conectar
            using (var banco = new ComandaDBContext())
            {
                // captar dados da tela
                string titulo = txtTitulo.Text;
                string descricao = txtDescricao.Text;
                decimal.TryParse(txtPreco.Text, out decimal preco);
                bool possuiPreparo = chkPossuiPreparo.Checked;
                // criar um novo cardapio
                var cardapio = new CardapioItem()
                {
                    Titulo = titulo,
                    Descricao = descricao,
                    Preco = preco,
                    PossuiPreparo = possuiPreparo
                };
                // adicionar cardapio   // salvar as alterações no banco de dados
                banco.CardapioItems.Add(cardapio);
                banco.SaveChanges();
            }
            MessageBox.Show("Cardapio salvo com sucesso!",
                "Sucesso" ,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            this.Close();
        }
    }
}
