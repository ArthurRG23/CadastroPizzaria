using DTO;
using BLL;
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
    public partial class FrmClienteCadastrar : Form
    {
        public Cliente cliente = new Cliente();

        public FrmClienteCadastrar()
        {
            InitializeComponent();
        }

        public FrmClienteCadastrar(int CodigoCliente)
        {
            InitializeComponent();

            if (CodigoCliente != 0)
            {
                cliente = PizzariaBLL.BuscarClienteBLL(CodigoCliente);

                mskCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                mskTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                mskCelular.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                mskAdicional.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

                txtNome.Text = cliente.Nome;
                mskCPF.Text = cliente.CPF;
                mskTelefone.Text = cliente.Telefone;
                mskCelular.Text = cliente.Celular;
                mskAdicional.Text = cliente.TelAdicional;
                txtEndereco.Text = cliente.Endereco;
                txtNumero.Text = cliente.Numero;
                txtBairro.Text = cliente.Bairro;
                txtComplemento.Text = cliente.Complemento;
                txtCidade.Text = cliente.Cidade;
                cbUF.Text = cliente.UF;
                mskCEP.Text = cliente.CEP;
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (cliente == null)
                cliente = new Cliente();
            //Removendo máscara para salvar no banco o atributo bruto
            mskCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mskTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mskCelular.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mskAdicional.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            cliente.Nome = txtNome.Text;
            cliente.CPF = mskCPF.Text;
            cliente.Telefone = mskTelefone.Text;
            cliente.Celular = mskCelular.Text;
            cliente.TelAdicional = mskAdicional.Text;
            cliente.Endereco = txtEndereco.Text;
            cliente.Numero = txtNumero.Text;
            cliente.Bairro = txtBairro.Text;
            cliente.Complemento = txtComplemento.Text;
            cliente.Cidade = txtCidade.Text;
            cliente.UF = cbUF.Text;
            cliente.CEP = mskCEP.Text;

            if (cliente.Id == 0)
                cliente.Id = PizzariaBLL.InserirClienteBLL(cliente);
            else
                PizzariaBLL.AtualizarClienteBLL(cliente);

            MessageBox.Show("Cliente Cadastrado com Sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DialogResult = DialogResult.OK;
        }
    }
}
