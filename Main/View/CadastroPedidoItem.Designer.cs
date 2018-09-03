namespace Main.View
{
    partial class CadastroPedidoItem
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textQuantidade = new System.Windows.Forms.TextBox();
            this.comboBoxLivro = new System.Windows.Forms.ComboBox();
            this.livroBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.livrariaDBDataSet18 = new Main.livrariaDBDataSet18();
            this.livroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonCadastroPedido = new System.Windows.Forms.Button();
            this.buttonFinalizar = new System.Windows.Forms.Button();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeLivro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.joinVIEWBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.livrariaDBDataSet24joinview = new Main.livrariaDBDataSet24joinview();
            this.itemBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.livrariaDBDataSet17 = new Main.livrariaDBDataSet17();
            this.itemBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.livroBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.itemTableAdapter3 = new Main.livrariaDBDataSet17TableAdapters.ItemTableAdapter();
            this.livroTableAdapter2 = new Main.livrariaDBDataSet18TableAdapters.LivroTableAdapter();
            this.labelValorTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxNomePedido = new System.Windows.Forms.ComboBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.livrariaDBDataSet19 = new Main.livrariaDBDataSet19();
            this.labelData = new System.Windows.Forms.Label();
            this.cadastraPedido1 = new System.Windows.Forms.Button();
            this.clienteTableAdapter = new Main.livrariaDBDataSet19TableAdapters.ClienteTableAdapter();
            this.livrariaDBDataSet23 = new Main.livrariaDBDataSet23();
            this.joinVIEWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.joinVIEWTableAdapter = new Main.livrariaDBDataSet23TableAdapters.JoinVIEWTableAdapter();
            this.joinVIEWTableAdapter1 = new Main.livrariaDBDataSet24joinviewTableAdapters.JoinVIEWTableAdapter();
            this.labelLegenda = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.livroBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrariaDBDataSet18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.joinVIEWBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrariaDBDataSet24joinview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrariaDBDataSet17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrariaDBDataSet19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrariaDBDataSet23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.joinVIEWBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cadastrar Itens";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(276, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Livro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Quantidade";
            // 
            // textQuantidade
            // 
            this.textQuantidade.Location = new System.Drawing.Point(36, 282);
            this.textQuantidade.Name = "textQuantidade";
            this.textQuantidade.Size = new System.Drawing.Size(100, 20);
            this.textQuantidade.TabIndex = 9;
            this.textQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textQuantidade_KeyPress);
            // 
            // comboBoxLivro
            // 
            this.comboBoxLivro.DataSource = this.livroBindingSource2;
            this.comboBoxLivro.DisplayMember = "NomeLivro";
            this.comboBoxLivro.FormattingEnabled = true;
            this.comboBoxLivro.Location = new System.Drawing.Point(169, 281);
            this.comboBoxLivro.Name = "comboBoxLivro";
            this.comboBoxLivro.Size = new System.Drawing.Size(248, 21);
            this.comboBoxLivro.TabIndex = 10;
            this.comboBoxLivro.ValueMember = "IdLivro";
            // 
            // livroBindingSource2
            // 
            this.livroBindingSource2.DataMember = "Livro";
            this.livroBindingSource2.DataSource = this.livrariaDBDataSet18;
            // 
            // livrariaDBDataSet18
            // 
            this.livrariaDBDataSet18.DataSetName = "livrariaDBDataSet18";
            this.livrariaDBDataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonCadastroPedido
            // 
            this.buttonCadastroPedido.Location = new System.Drawing.Point(483, 279);
            this.buttonCadastroPedido.Name = "buttonCadastroPedido";
            this.buttonCadastroPedido.Size = new System.Drawing.Size(62, 23);
            this.buttonCadastroPedido.TabIndex = 18;
            this.buttonCadastroPedido.Text = "Incluir!";
            this.buttonCadastroPedido.UseVisualStyleBackColor = true;
            this.buttonCadastroPedido.Click += new System.EventHandler(this.buttonCadastroPedido_Click);
            // 
            // buttonFinalizar
            // 
            this.buttonFinalizar.Location = new System.Drawing.Point(226, 570);
            this.buttonFinalizar.Name = "buttonFinalizar";
            this.buttonFinalizar.Size = new System.Drawing.Size(106, 23);
            this.buttonFinalizar.TabIndex = 19;
            this.buttonFinalizar.Text = "Finalizar!";
            this.buttonFinalizar.UseVisualStyleBackColor = true;
            this.buttonFinalizar.Click += new System.EventHandler(this.buttonFinalizar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.quantidadeDataGridViewTextBoxColumn,
            this.NomeLivro,
            this.Preco});
            this.dataGridView1.DataSource = this.joinVIEWBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(113, 328);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(356, 173);
            this.dataGridView1.TabIndex = 20;
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade de livros";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            this.quantidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // NomeLivro
            // 
            this.NomeLivro.DataPropertyName = "NomeLivro";
            this.NomeLivro.HeaderText = "NomeLivro";
            this.NomeLivro.Name = "NomeLivro";
            this.NomeLivro.ReadOnly = true;
            // 
            // Preco
            // 
            this.Preco.DataPropertyName = "Preco";
            this.Preco.HeaderText = "Preco";
            this.Preco.Name = "Preco";
            this.Preco.ReadOnly = true;
            // 
            // joinVIEWBindingSource1
            // 
            this.joinVIEWBindingSource1.DataMember = "JoinVIEW";
            this.joinVIEWBindingSource1.DataSource = this.livrariaDBDataSet24joinview;
            // 
            // livrariaDBDataSet24joinview
            // 
            this.livrariaDBDataSet24joinview.DataSetName = "livrariaDBDataSet24joinview";
            this.livrariaDBDataSet24joinview.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemBindingSource3
            // 
            this.itemBindingSource3.DataMember = "Item";
            this.itemBindingSource3.DataSource = this.livrariaDBDataSet17;
            // 
            // livrariaDBDataSet17
            // 
            this.livrariaDBDataSet17.DataSetName = "livrariaDBDataSet17";
            this.livrariaDBDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemTableAdapter3
            // 
            this.itemTableAdapter3.ClearBeforeFill = true;
            // 
            // livroTableAdapter2
            // 
            this.livroTableAdapter2.ClearBeforeFill = true;
            // 
            // labelValorTotal
            // 
            this.labelValorTotal.AutoSize = true;
            this.labelValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelValorTotal.Location = new System.Drawing.Point(392, 520);
            this.labelValorTotal.Name = "labelValorTotal";
            this.labelValorTotal.Size = new System.Drawing.Size(25, 25);
            this.labelValorTotal.TabIndex = 25;
            this.labelValorTotal.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(108, 520);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "Valor da compra:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(249, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Pedido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "Nome do Cliente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(448, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 16);
            this.label7.TabIndex = 29;
            this.label7.Text = "Data";
            // 
            // comboBoxNomePedido
            // 
            this.comboBoxNomePedido.DataSource = this.clienteBindingSource;
            this.comboBoxNomePedido.DisplayMember = "NomeCliente";
            this.comboBoxNomePedido.FormattingEnabled = true;
            this.comboBoxNomePedido.Location = new System.Drawing.Point(169, 75);
            this.comboBoxNomePedido.Name = "comboBoxNomePedido";
            this.comboBoxNomePedido.Size = new System.Drawing.Size(248, 21);
            this.comboBoxNomePedido.TabIndex = 30;
            this.comboBoxNomePedido.ValueMember = "IdCliente";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.livrariaDBDataSet19;
            // 
            // livrariaDBDataSet19
            // 
            this.livrariaDBDataSet19.DataSetName = "livrariaDBDataSet19";
            this.livrariaDBDataSet19.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData.Location = new System.Drawing.Point(512, 75);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(16, 16);
            this.labelData.TabIndex = 31;
            this.labelData.Text = "--";
            // 
            // cadastraPedido1
            // 
            this.cadastraPedido1.BackColor = System.Drawing.SystemColors.Control;
            this.cadastraPedido1.Location = new System.Drawing.Point(236, 122);
            this.cadastraPedido1.Name = "cadastraPedido1";
            this.cadastraPedido1.Size = new System.Drawing.Size(96, 23);
            this.cadastraPedido1.TabIndex = 32;
            this.cadastraPedido1.Text = "Cadastrar!";
            this.cadastraPedido1.UseVisualStyleBackColor = false;
            this.cadastraPedido1.Click += new System.EventHandler(this.cadastraPedido1_Click);
            this.cadastraPedido1.MouseEnter += new System.EventHandler(this.cadastraPedido1_MouseEnter);
            this.cadastraPedido1.MouseLeave += new System.EventHandler(this.cadastraPedido1_MouseLeave);
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // livrariaDBDataSet23
            // 
            this.livrariaDBDataSet23.DataSetName = "livrariaDBDataSet23";
            this.livrariaDBDataSet23.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // joinVIEWBindingSource
            // 
            this.joinVIEWBindingSource.DataMember = "JoinVIEW";
            this.joinVIEWBindingSource.DataSource = this.livrariaDBDataSet23;
            // 
            // joinVIEWTableAdapter
            // 
            this.joinVIEWTableAdapter.ClearBeforeFill = true;
            // 
            // joinVIEWTableAdapter1
            // 
            this.joinVIEWTableAdapter1.ClearBeforeFill = true;
            // 
            // labelLegenda
            // 
            this.labelLegenda.AutoSize = true;
            this.labelLegenda.Location = new System.Drawing.Point(142, 166);
            this.labelLegenda.Name = "labelLegenda";
            this.labelLegenda.Size = new System.Drawing.Size(289, 13);
            this.labelLegenda.TabIndex = 33;
            this.labelLegenda.Text = "* Cliente não encontrado? Faça o cadastro na aba cliente !!";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(312, 520);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 25);
            this.label8.TabIndex = 34;
            this.label8.Text = "R$";
            // 
            // CadastroPedidoItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(593, 615);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelLegenda);
            this.Controls.Add(this.cadastraPedido1);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.comboBoxNomePedido);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelValorTotal);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonFinalizar);
            this.Controls.Add(this.buttonCadastroPedido);
            this.Controls.Add(this.comboBoxLivro);
            this.Controls.Add(this.textQuantidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CadastroPedidoItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Pedido e Item";
            this.Load += new System.EventHandler(this.AberturaItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.livroBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrariaDBDataSet18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.joinVIEWBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrariaDBDataSet24joinview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrariaDBDataSet17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrariaDBDataSet19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrariaDBDataSet23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.joinVIEWBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textQuantidade;
        private System.Windows.Forms.ComboBox comboBoxLivro;
        private System.Windows.Forms.Button buttonCadastroPedido;
        private System.Windows.Forms.Button buttonFinalizar;
        private System.Windows.Forms.BindingSource livroBindingSource;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private System.Windows.Forms.BindingSource itemBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource itemBindingSource2;
        private System.Windows.Forms.BindingSource livroBindingSource1;
        private livrariaDBDataSet17 livrariaDBDataSet17;
        private System.Windows.Forms.BindingSource itemBindingSource3;
        private livrariaDBDataSet17TableAdapters.ItemTableAdapter itemTableAdapter3;
        private livrariaDBDataSet18 livrariaDBDataSet18;
        private System.Windows.Forms.BindingSource livroBindingSource2;
        private livrariaDBDataSet18TableAdapters.LivroTableAdapter livroTableAdapter2;
        private System.Windows.Forms.Label labelValorTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxNomePedido;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Button cadastraPedido1;
        private livrariaDBDataSet19 livrariaDBDataSet19;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private livrariaDBDataSet19TableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private livrariaDBDataSet23 livrariaDBDataSet23;
        private System.Windows.Forms.BindingSource joinVIEWBindingSource;
        private livrariaDBDataSet23TableAdapters.JoinVIEWTableAdapter joinVIEWTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeLivro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco;
        private livrariaDBDataSet24joinview livrariaDBDataSet24joinview;
        private System.Windows.Forms.BindingSource joinVIEWBindingSource1;
        private livrariaDBDataSet24joinviewTableAdapters.JoinVIEWTableAdapter joinVIEWTableAdapter1;
        private System.Windows.Forms.Label labelLegenda;
        private System.Windows.Forms.Label label8;
    }
}