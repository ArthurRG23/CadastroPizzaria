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
    public partial class FrmClienteSelecionar : Form
    {
        public FrmClienteSelecionar(Acao acao)
        {
            InitializeComponent();

            if (acao == Acao.Inserir)
            {
                btnInserirPedido.Visible = true;
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            FrmClienteCadastrar frmClienteCadastrar = new FrmClienteCadastrar(0);
            var result = frmClienteCadastrar.ShowDialog();


            if (result == DialogResult.OK)
            {
                string[] linhaCliente = { frmClienteCadastrar.cliente.Id.ToString(), frmClienteCadastrar.cliente.Nome, frmClienteCadastrar.cliente.CPF, frmClienteCadastrar.cliente.Telefone, frmClienteCadastrar.cliente.Celular, frmClienteCadastrar.cliente.TelAdicional, frmClienteCadastrar.cliente.Endereco, frmClienteCadastrar.cliente.Numero, frmClienteCadastrar.cliente.Bairro, frmClienteCadastrar.cliente.Complemento, frmClienteCadastrar.cliente.Cidade, frmClienteCadastrar.cliente.UF, frmClienteCadastrar.cliente.CEP };
                Grid.Rows.Add(linhaCliente);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Grid.Rows.Clear();

            string[] filtros = { txtPesquisar.Text };

            List<Cliente> Clientes = PizzariaBLL.BuscarClienteDAL(filtros);

            foreach (var cliente in Clientes)
            {
                string[] linhaCliente = { cliente.Id.ToString(), cliente.Nome, cliente.CPF, cliente.Telefone, cliente.Celular, cliente.TelAdicional, cliente.Endereco, cliente.Numero, cliente.Bairro, cliente.Complemento, cliente.Cidade, cliente.UF, cliente.CEP };
                Grid.Rows.Add(linhaCliente);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            int CodigoClienteLinhaSelecionada = int.Parse(Grid.CurrentRow.Cells["ColumnID"].Value.ToString());

            FrmClienteCadastrar frmClienteCadastrar = new FrmClienteCadastrar(CodigoClienteLinhaSelecionada);
            var result = frmClienteCadastrar.ShowDialog();

            if (result == DialogResult.OK)
            {
                Grid.Rows.Clear();
                string[] linhaCliente = { frmClienteCadastrar.cliente.Id.ToString(), frmClienteCadastrar.cliente.Nome, frmClienteCadastrar.cliente.CPF, frmClienteCadastrar.cliente.Telefone, frmClienteCadastrar.cliente.Celular, frmClienteCadastrar.cliente.TelAdicional, frmClienteCadastrar.cliente.Endereco, frmClienteCadastrar.cliente.Numero, frmClienteCadastrar.cliente.Bairro, frmClienteCadastrar.cliente.Complemento, frmClienteCadastrar.cliente.Cidade, frmClienteCadastrar.cliente.UF, frmClienteCadastrar.cliente.CEP };
                Grid.Rows.Add(linhaCliente);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma Exclusão?", "Excluir Ciente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int CodigoClienteLinhaSelecionada = int.Parse(Grid.CurrentRow.Cells["ColumnID"].Value.ToString());

                PizzariaBLL.ExcluirClienteBLL(CodigoClienteLinhaSelecionada);

                Grid.Rows.RemoveAt(Grid.CurrentRow.Index);
            }
        }

        private void Grid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAlterar_Click(null, null);
        }
    }
}
