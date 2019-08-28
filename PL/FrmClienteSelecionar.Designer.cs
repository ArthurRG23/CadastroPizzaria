namespace PL
{
    partial class FrmClienteSelecionar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClienteSelecionar));
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInserirPedido = new System.Windows.Forms.Button();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAdicional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEnderecoNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEnderecoBairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEnderecoComplemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEnderecoCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(670, 336);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 23;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(579, 336);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 22;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(488, 336);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 21;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(397, 336);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 20;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnNome,
            this.ColumnCPF,
            this.ColumnTelefone,
            this.ColumnCelular,
            this.ColumnAdicional,
            this.ColumnEndereco,
            this.ColumnEnderecoNumero,
            this.ColumnEnderecoBairro,
            this.ColumnEnderecoComplemento,
            this.ColumnEnderecoCidade});
            this.Grid.Location = new System.Drawing.Point(5, 47);
            this.Grid.MultiSelect = false;
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(740, 283);
            this.Grid.TabIndex = 19;
            this.Grid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellContentDoubleClick);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(106, 8);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(539, 20);
            this.txtPesquisar.TabIndex = 18;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(662, 7);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 17;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Cliente/Telefone:";
            // 
            // btnInserirPedido
            // 
            this.btnInserirPedido.Location = new System.Drawing.Point(7, 337);
            this.btnInserirPedido.Name = "btnInserirPedido";
            this.btnInserirPedido.Size = new System.Drawing.Size(101, 23);
            this.btnInserirPedido.TabIndex = 41;
            this.btnInserirPedido.Text = "Inserir no Pedido";
            this.btnInserirPedido.UseVisualStyleBackColor = true;
            this.btnInserirPedido.Visible = false;
            // 
            // ColumnID
            // 
            this.ColumnID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Red;
            this.ColumnID.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.ReadOnly = true;
            this.ColumnID.Width = 43;
            // 
            // ColumnNome
            // 
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.ReadOnly = true;
            // 
            // ColumnCPF
            // 
            this.ColumnCPF.HeaderText = "CNPJ";
            this.ColumnCPF.Name = "ColumnCPF";
            this.ColumnCPF.ReadOnly = true;
            // 
            // ColumnTelefone
            // 
            this.ColumnTelefone.HeaderText = "Telefone";
            this.ColumnTelefone.Name = "ColumnTelefone";
            this.ColumnTelefone.ReadOnly = true;
            // 
            // ColumnCelular
            // 
            this.ColumnCelular.HeaderText = "Celular";
            this.ColumnCelular.Name = "ColumnCelular";
            this.ColumnCelular.ReadOnly = true;
            // 
            // ColumnAdicional
            // 
            this.ColumnAdicional.HeaderText = "Outros";
            this.ColumnAdicional.Name = "ColumnAdicional";
            this.ColumnAdicional.ReadOnly = true;
            // 
            // ColumnEndereco
            // 
            this.ColumnEndereco.HeaderText = "Endereço";
            this.ColumnEndereco.Name = "ColumnEndereco";
            this.ColumnEndereco.ReadOnly = true;
            // 
            // ColumnEnderecoNumero
            // 
            this.ColumnEnderecoNumero.HeaderText = "Número";
            this.ColumnEnderecoNumero.Name = "ColumnEnderecoNumero";
            this.ColumnEnderecoNumero.ReadOnly = true;
            // 
            // ColumnEnderecoBairro
            // 
            this.ColumnEnderecoBairro.HeaderText = "Bairro";
            this.ColumnEnderecoBairro.Name = "ColumnEnderecoBairro";
            this.ColumnEnderecoBairro.ReadOnly = true;
            // 
            // ColumnEnderecoComplemento
            // 
            this.ColumnEnderecoComplemento.HeaderText = "Complemento";
            this.ColumnEnderecoComplemento.Name = "ColumnEnderecoComplemento";
            this.ColumnEnderecoComplemento.ReadOnly = true;
            // 
            // ColumnEnderecoCidade
            // 
            this.ColumnEnderecoCidade.HeaderText = "Cidade";
            this.ColumnEnderecoCidade.Name = "ColumnEnderecoCidade";
            this.ColumnEnderecoCidade.ReadOnly = true;
            // 
            // FrmClienteSelecionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 363);
            this.Controls.Add(this.btnInserirPedido);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmClienteSelecionar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInserirPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCelular;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAdicional;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEnderecoNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEnderecoBairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEnderecoComplemento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEnderecoCidade;
    }
}