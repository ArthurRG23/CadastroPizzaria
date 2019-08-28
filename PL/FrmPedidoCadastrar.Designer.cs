namespace PL
{
    partial class FrmPedidoCadastrar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedidoCadastrar));
            this.abasPedidos = new System.Windows.Forms.TabControl();
            this.tabSelecionarCliente = new System.Windows.Forms.TabPage();
            this.btnNovoCliente = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.Grid = new System.Windows.Forms.DataGridView();
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
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabInserirProduto = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSelecionarCliente = new System.Windows.Forms.Button();
            this.txtCodCliente = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtClientePedido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtObsPedido = new System.Windows.Forms.TextBox();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.labelValorTotal = new System.Windows.Forms.Label();
            this.GridItemVenda = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscarProduto = new System.Windows.Forms.Button();
            this.abasPedidos.SuspendLayout();
            this.tabSelecionarCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.tabInserirProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridItemVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // abasPedidos
            // 
            this.abasPedidos.Controls.Add(this.tabSelecionarCliente);
            this.abasPedidos.Controls.Add(this.tabInserirProduto);
            this.abasPedidos.Location = new System.Drawing.Point(3, 0);
            this.abasPedidos.Name = "abasPedidos";
            this.abasPedidos.SelectedIndex = 0;
            this.abasPedidos.Size = new System.Drawing.Size(825, 414);
            this.abasPedidos.TabIndex = 1;
            // 
            // tabSelecionarCliente
            // 
            this.tabSelecionarCliente.Controls.Add(this.btnNovoCliente);
            this.tabSelecionarCliente.Controls.Add(this.btnIncluir);
            this.tabSelecionarCliente.Controls.Add(this.Grid);
            this.tabSelecionarCliente.Controls.Add(this.txtPesquisar);
            this.tabSelecionarCliente.Controls.Add(this.btnPesquisar);
            this.tabSelecionarCliente.Controls.Add(this.label1);
            this.tabSelecionarCliente.Location = new System.Drawing.Point(4, 22);
            this.tabSelecionarCliente.Name = "tabSelecionarCliente";
            this.tabSelecionarCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tabSelecionarCliente.Size = new System.Drawing.Size(817, 388);
            this.tabSelecionarCliente.TabIndex = 0;
            this.tabSelecionarCliente.Text = "Cliente";
            this.tabSelecionarCliente.UseVisualStyleBackColor = true;
            // 
            // btnNovoCliente
            // 
            this.btnNovoCliente.Location = new System.Drawing.Point(697, 354);
            this.btnNovoCliente.Name = "btnNovoCliente";
            this.btnNovoCliente.Size = new System.Drawing.Size(83, 23);
            this.btnNovoCliente.TabIndex = 3;
            this.btnNovoCliente.Text = "Novo Cliente";
            this.btnNovoCliente.UseVisualStyleBackColor = true;
            this.btnNovoCliente.Click += new System.EventHandler(this.btnNovoCliente_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(616, 354);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 2;
            this.btnIncluir.Text = "Selecionar";
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
            this.Grid.Location = new System.Drawing.Point(2, 65);
            this.Grid.MultiSelect = false;
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(814, 283);
            this.Grid.TabIndex = 27;
            this.Grid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellContentDoubleClick);
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
            this.ColumnCPF.HeaderText = "CPF";
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
            this.ColumnEnderecoNumero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.ColumnEnderecoNumero.HeaderText = "Número";
            this.ColumnEnderecoNumero.Name = "ColumnEnderecoNumero";
            this.ColumnEnderecoNumero.ReadOnly = true;
            this.ColumnEnderecoNumero.Width = 5;
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
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(141, 26);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(539, 20);
            this.txtPesquisar.TabIndex = 0;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(697, 25);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 1;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Nome/Telefone:";
            // 
            // tabInserirProduto
            // 
            this.tabInserirProduto.Controls.Add(this.button2);
            this.tabInserirProduto.Controls.Add(this.button1);
            this.tabInserirProduto.Controls.Add(this.btnSelecionarCliente);
            this.tabInserirProduto.Controls.Add(this.txtCodCliente);
            this.tabInserirProduto.Controls.Add(this.label13);
            this.tabInserirProduto.Controls.Add(this.txtClientePedido);
            this.tabInserirProduto.Controls.Add(this.label2);
            this.tabInserirProduto.Controls.Add(this.txtValorTotal);
            this.tabInserirProduto.Controls.Add(this.label14);
            this.tabInserirProduto.Controls.Add(this.txtObsPedido);
            this.tabInserirProduto.Controls.Add(this.lblValorTotal);
            this.tabInserirProduto.Controls.Add(this.labelValorTotal);
            this.tabInserirProduto.Controls.Add(this.GridItemVenda);
            this.tabInserirProduto.Controls.Add(this.btnBuscarProduto);
            this.tabInserirProduto.Location = new System.Drawing.Point(4, 22);
            this.tabInserirProduto.Name = "tabInserirProduto";
            this.tabInserirProduto.Padding = new System.Windows.Forms.Padding(3);
            this.tabInserirProduto.Size = new System.Drawing.Size(817, 388);
            this.tabInserirProduto.TabIndex = 1;
            this.tabInserirProduto.Text = "Produtos";
            this.tabInserirProduto.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(685, 348);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 32);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(513, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "Finalizar Pedido";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSelecionarCliente
            // 
            this.btnSelecionarCliente.Location = new System.Drawing.Point(552, 17);
            this.btnSelecionarCliente.Name = "btnSelecionarCliente";
            this.btnSelecionarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnSelecionarCliente.TabIndex = 8;
            this.btnSelecionarCliente.Text = "Selecionar";
            this.btnSelecionarCliente.UseVisualStyleBackColor = true;
            this.btnSelecionarCliente.Click += new System.EventHandler(this.btnSelecionarCliente_Click);
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodCliente.Location = new System.Drawing.Point(65, 18);
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.ReadOnly = true;
            this.txtCodCliente.Size = new System.Drawing.Size(50, 22);
            this.txtCodCliente.TabIndex = 6;
            this.txtCodCliente.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(14, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 16);
            this.label13.TabIndex = 5;
            this.label13.Text = "Código";
            // 
            // txtClientePedido
            // 
            this.txtClientePedido.Enabled = false;
            this.txtClientePedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientePedido.Location = new System.Drawing.Point(190, 18);
            this.txtClientePedido.Name = "txtClientePedido";
            this.txtClientePedido.ReadOnly = true;
            this.txtClientePedido.Size = new System.Drawing.Size(356, 22);
            this.txtClientePedido.TabIndex = 119;
            this.txtClientePedido.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(139, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Cliente";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Enabled = false;
            this.txtValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotal.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtValorTotal.Location = new System.Drawing.Point(717, 301);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.ReadOnly = true;
            this.txtValorTotal.Size = new System.Drawing.Size(95, 20);
            this.txtValorTotal.TabIndex = 118;
            this.txtValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 312);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 13);
            this.label14.TabIndex = 117;
            this.label14.Text = "Observação Pedido";
            // 
            // txtObsPedido
            // 
            this.txtObsPedido.Location = new System.Drawing.Point(14, 328);
            this.txtObsPedido.Name = "txtObsPedido";
            this.txtObsPedido.Size = new System.Drawing.Size(408, 20);
            this.txtObsPedido.TabIndex = 2;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Location = new System.Drawing.Point(736, 335);
            this.lblValorTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(0, 13);
            this.lblValorTotal.TabIndex = 115;
            // 
            // labelValorTotal
            // 
            this.labelValorTotal.AutoSize = true;
            this.labelValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorTotal.Location = new System.Drawing.Point(643, 302);
            this.labelValorTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelValorTotal.Name = "labelValorTotal";
            this.labelValorTotal.Size = new System.Drawing.Size(68, 15);
            this.labelValorTotal.TabIndex = 114;
            this.labelValorTotal.Text = "Valor Total:";
            // 
            // GridItemVenda
            // 
            this.GridItemVenda.AllowUserToAddRows = false;
            this.GridItemVenda.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GridItemVenda.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.GridItemVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridItemVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.ColumnCategoria,
            this.ColumnPreco});
            this.GridItemVenda.Location = new System.Drawing.Point(1, 58);
            this.GridItemVenda.Name = "GridItemVenda";
            this.GridItemVenda.ReadOnly = true;
            this.GridItemVenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.GridItemVenda.Size = new System.Drawing.Size(815, 237);
            this.GridItemVenda.TabIndex = 113;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Red;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Produto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // ColumnCategoria
            // 
            this.ColumnCategoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnCategoria.HeaderText = "Categoria";
            this.ColumnCategoria.Name = "ColumnCategoria";
            this.ColumnCategoria.ReadOnly = true;
            // 
            // ColumnPreco
            // 
            this.ColumnPreco.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColumnPreco.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColumnPreco.HeaderText = "Valor Unitário";
            this.ColumnPreco.Name = "ColumnPreco";
            this.ColumnPreco.ReadOnly = true;
            // 
            // btnBuscarProduto
            // 
            this.btnBuscarProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarProduto.Image")));
            this.btnBuscarProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarProduto.Location = new System.Drawing.Point(692, 15);
            this.btnBuscarProduto.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarProduto.Name = "btnBuscarProduto";
            this.btnBuscarProduto.Size = new System.Drawing.Size(110, 27);
            this.btnBuscarProduto.TabIndex = 1;
            this.btnBuscarProduto.Text = "Inserir Produto";
            this.btnBuscarProduto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarProduto.UseVisualStyleBackColor = true;
            this.btnBuscarProduto.Click += new System.EventHandler(this.btnBuscarProduto_Click);
            // 
            // FrmPedidoCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 414);
            this.Controls.Add(this.abasPedidos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPedidoCadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Pedido";
            this.Load += new System.EventHandler(this.FrmPedidoCadastrar_Load);
            this.abasPedidos.ResumeLayout(false);
            this.tabSelecionarCliente.ResumeLayout(false);
            this.tabSelecionarCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.tabInserirProduto.ResumeLayout(false);
            this.tabInserirProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridItemVenda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl abasPedidos;
        private System.Windows.Forms.TabPage tabSelecionarCliente;
        private System.Windows.Forms.TabPage tabInserirProduto;
        private System.Windows.Forms.Button btnNovoCliente;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodCliente;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtClientePedido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtObsPedido;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label labelValorTotal;
        private System.Windows.Forms.DataGridView GridItemVenda;
        private System.Windows.Forms.Button btnBuscarProduto;
        private System.Windows.Forms.Button btnSelecionarCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPreco;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
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