using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL
{
    public partial class FrmProdutoSelecionar : Form
    {
        public Produto produto = new Produto();
        public int ProdutoSelecionadoPedido;

        public FrmProdutoSelecionar(Acao acao)
        {
            InitializeComponent();
            
            if( acao == Acao.Inserir)
            {
                btnInserirPedido.Visible = true;
                btnAlterar.Visible = false;
                btnIncluir.Visible = false;
                btnExcluir.Visible = false;
                nudQuantidade.Visible = false;
                labelQuantidade.Visible = false;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Grid.Rows.Clear();

            string[] filtros = { txtNome.Text, cboCategoria.Text };

            List<Produto> Produtos = PizzariaBLL.BuscarProdutoDAL(filtros);

            foreach (var produto in Produtos)
            {
                string[] linhaProduto = { produto.CodProduto.ToString(), produto.DescricaoProduto, produto.Categoria, produto.Preco };
                Grid.Rows.Add(linhaProduto);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            FrmProdutoCadastrar frmProdutoCadastrar = new FrmProdutoCadastrar(Acao.Inserir);
            frmProdutoCadastrar.ShowDialog();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            int ProdutoSelecionado = int.Parse(Grid.CurrentRow.Cells["ColumnID"].Value.ToString());
            
            FrmProdutoCadastrar frmProdutoCadastrar = new FrmProdutoCadastrar(ProdutoSelecionado);
            var result = frmProdutoCadastrar.ShowDialog();

            if (result == DialogResult.OK)
            {
                Grid.Rows.Clear();
                string[] linhaProduto = { frmProdutoCadastrar.produto.CodProduto.ToString(), frmProdutoCadastrar.produto.DescricaoProduto, frmProdutoCadastrar.produto.Preco };
                Grid.Rows.Add(linhaProduto);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma Exclusão?", "Excluir Produto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int ProdutoSelecionado = int.Parse(Grid.CurrentRow.Cells["ColumnID"].Value.ToString());

                PizzariaBLL.ExcluirProdutoBLL(ProdutoSelecionado);

                Grid.Rows.RemoveAt(Grid.CurrentRow.Index);
            }
        }


        private void btnInserirPedido_Click(object sender, EventArgs e)
        {
            int ProdutoSelecionadoPedido = int.Parse(Grid.CurrentRow.Cells["ColumnID"].Value.ToString());

            produto = PizzariaBLL.BuscarProdutoBLL(ProdutoSelecionadoPedido);
            
            this.DialogResult = DialogResult.OK;
        }

        private void Grid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAlterar_Click(null, null);
        }
    }
}
