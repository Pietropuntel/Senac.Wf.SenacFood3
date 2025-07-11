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
    {   private readonly CardapioItem _cardapioItem;
        public FrmCardapioCad()
        {
            InitializeComponent();
        }

        public FrmCardapioCad(CardapioItem cardapioItem)
        {
            _cardapioItem = cardapioItem;
               InitializeComponent();
            // carregar os dados do cardapio selecionado
            CarregarDadosDaTela();
        }

        private void CarregarDadosDaTela()
        {
            // popular os campos de texto e chekbox 
            if (_cardapioItem != null)
            {
                txtTitulo.Text = _cardapioItem.Titulo;
                txtDescricao.Text = _cardapioItem.Descricao;
                txtPreco.Text = _cardapioItem.Preco.ToString("F2");
                chkPossuiPreparo.Checked = _cardapioItem.PossuiPreparo;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (_cardapioItem == null)
            {
                InserirCardapio();
            }
            else 
            {
                AtualizarCardapio();
            }
                
        }

        private void AtualizarCardapio()
        {
            using (var banco = new ComandaDBContext())
            {
                string titulo = txtTitulo.Text;
                string descricao = txtDescricao.Text;
                decimal.TryParse(txtPreco.Text, out var preco);
                bool possuiPreparo = chkPossuiPreparo.Checked;
                // Atualizar o cardapio
                var cardapioItem = banco.CardapioItems.First(x => x.Id == _cardapioItem.Id);
                cardapioItem.Titulo = titulo;
                cardapioItem.Descricao = descricao;
                cardapioItem.Preco = preco;
                cardapioItem.PossuiPreparo = possuiPreparo;
                //salvar as alteraçoesno banco
                banco.CardapioItems.Update(cardapioItem);
                banco.SaveChanges();
                MessageBox.Show("Cardapio salvo com sucesso!",
                "Sucesso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                this.Close();
            }

        }


        private void InserirCardapio()
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
                "Sucesso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            this.Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
