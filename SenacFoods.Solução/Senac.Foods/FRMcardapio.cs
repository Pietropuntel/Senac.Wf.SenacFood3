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
        CardapioItem? cardapioSelecionado;
        public FRMcardapio()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        // clique do editar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (cardapioSelecionado != null)
            {
                // abrir o formulário de edição
                var frmCardapioEdit = new FrmCardapioCad(cardapioSelecionado);
                frmCardapioEdit.ShowDialog();
                BuscarCardapio();
            }
        }
      

        private void FRMcardapio_Load(object sender, EventArgs e)
        {
            BuscarCardapio();
        }

        private void BuscarCardapio()
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

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            new FrmCardapioCad().ShowDialog();
            BuscarCardapio();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            // chamar o método de buscar cardapio
            BuscarCardapio();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // pegar o cardapio selecionado
                cardapioSelecionado = dataGridView1.Rows[e.RowIndex].DataBoundItem as CardapioItem;
                btnEditar.Enabled = true;

            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(cardapioSelecionado != null)
            {                 // confirmar a exclusão
                var confirmResult = MessageBox.Show("Você tem certeza que deseja excluir este item do cardápio?",
                                                     "Confirmação de Exclusão",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    using (var banco = new ComandaDBContext())
                    {
                        // remover o cardapio selecionado
                        banco.CardapioItems.Remove(cardapioSelecionado);
                        banco.SaveChanges();
                        MessageBox.Show("Item do cardápio excluído com sucesso!", "Sucesso",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BuscarCardapio();
                        cardapioSelecionado = null;
                    }
                }
            }
            else
            {
                MessageBox.Show("Nenhum item selecionado para exclusão.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
