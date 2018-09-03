namespace Main.View
{
    partial class ConsultaLivro
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
            this.dataGridLivro = new System.Windows.Forms.DataGridView();
            this.idLivroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEditoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeLivroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edicaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.livroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.livrariaDBDataSet2 = new Main.livrariaDBDataSet2();
            this.livroTableAdapter = new Main.livrariaDBDataSet2TableAdapters.LivroTableAdapter();
            this.lblLegenda = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLivro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrariaDBDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(409, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Consulta de Livros";
            // 
            // dataGridLivro
            // 
            this.dataGridLivro.AllowUserToAddRows = false;
            this.dataGridLivro.AllowUserToDeleteRows = false;
            this.dataGridLivro.AutoGenerateColumns = false;
            this.dataGridLivro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLivro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idLivroDataGridViewTextBoxColumn,
            this.idEditoraDataGridViewTextBoxColumn,
            this.nomeLivroDataGridViewTextBoxColumn,
            this.categoriaDataGridViewTextBoxColumn,
            this.precoDataGridViewTextBoxColumn,
            this.edicaoDataGridViewTextBoxColumn,
            this.autorDataGridViewTextBoxColumn,
            this.estoqueDataGridViewTextBoxColumn});
            this.dataGridLivro.DataSource = this.livroBindingSource;
            this.dataGridLivro.Location = new System.Drawing.Point(50, 32);
            this.dataGridLivro.Name = "dataGridLivro";
            this.dataGridLivro.ReadOnly = true;
            this.dataGridLivro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridLivro.Size = new System.Drawing.Size(866, 218);
            this.dataGridLivro.TabIndex = 3;
            this.dataGridLivro.DoubleClick += new System.EventHandler(this.dataGridLivro_DoubleClick);
            this.dataGridLivro.MouseEnter += new System.EventHandler(this.dataGridLivro_MouseEnter);
            this.dataGridLivro.MouseLeave += new System.EventHandler(this.dataGridLivro_MouseLeave);
            // 
            // idLivroDataGridViewTextBoxColumn
            // 
            this.idLivroDataGridViewTextBoxColumn.DataPropertyName = "IdLivro";
            this.idLivroDataGridViewTextBoxColumn.HeaderText = "Código do Livro";
            this.idLivroDataGridViewTextBoxColumn.Name = "idLivroDataGridViewTextBoxColumn";
            this.idLivroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idEditoraDataGridViewTextBoxColumn
            // 
            this.idEditoraDataGridViewTextBoxColumn.DataPropertyName = "IdEditora";
            this.idEditoraDataGridViewTextBoxColumn.HeaderText = "Código da Editora";
            this.idEditoraDataGridViewTextBoxColumn.Name = "idEditoraDataGridViewTextBoxColumn";
            this.idEditoraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeLivroDataGridViewTextBoxColumn
            // 
            this.nomeLivroDataGridViewTextBoxColumn.DataPropertyName = "NomeLivro";
            this.nomeLivroDataGridViewTextBoxColumn.HeaderText = "Nome do Livro";
            this.nomeLivroDataGridViewTextBoxColumn.Name = "nomeLivroDataGridViewTextBoxColumn";
            this.nomeLivroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoriaDataGridViewTextBoxColumn
            // 
            this.categoriaDataGridViewTextBoxColumn.DataPropertyName = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.HeaderText = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.Name = "categoriaDataGridViewTextBoxColumn";
            this.categoriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precoDataGridViewTextBoxColumn
            // 
            this.precoDataGridViewTextBoxColumn.DataPropertyName = "Preco";
            this.precoDataGridViewTextBoxColumn.HeaderText = "Preço";
            this.precoDataGridViewTextBoxColumn.Name = "precoDataGridViewTextBoxColumn";
            this.precoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // edicaoDataGridViewTextBoxColumn
            // 
            this.edicaoDataGridViewTextBoxColumn.DataPropertyName = "Edicao";
            this.edicaoDataGridViewTextBoxColumn.HeaderText = "Edição";
            this.edicaoDataGridViewTextBoxColumn.Name = "edicaoDataGridViewTextBoxColumn";
            this.edicaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // autorDataGridViewTextBoxColumn
            // 
            this.autorDataGridViewTextBoxColumn.DataPropertyName = "Autor";
            this.autorDataGridViewTextBoxColumn.HeaderText = "Autor";
            this.autorDataGridViewTextBoxColumn.Name = "autorDataGridViewTextBoxColumn";
            this.autorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estoqueDataGridViewTextBoxColumn
            // 
            this.estoqueDataGridViewTextBoxColumn.DataPropertyName = "Estoque";
            this.estoqueDataGridViewTextBoxColumn.HeaderText = "Estoque";
            this.estoqueDataGridViewTextBoxColumn.Name = "estoqueDataGridViewTextBoxColumn";
            this.estoqueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // livroBindingSource
            // 
            this.livroBindingSource.DataMember = "Livro";
            this.livroBindingSource.DataSource = this.livrariaDBDataSet2;
            // 
            // livrariaDBDataSet2
            // 
            this.livrariaDBDataSet2.DataSetName = "livrariaDBDataSet2";
            this.livrariaDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // livroTableAdapter
            // 
            this.livroTableAdapter.ClearBeforeFill = true;
            // 
            // lblLegenda
            // 
            this.lblLegenda.AutoSize = true;
            this.lblLegenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLegenda.Location = new System.Drawing.Point(330, 269);
            this.lblLegenda.Name = "lblLegenda";
            this.lblLegenda.Size = new System.Drawing.Size(353, 20);
            this.lblLegenda.TabIndex = 11;
            this.lblLegenda.Text = "* Dê um duplo clique para alterar ou excluir";
            // 
            // ConsultaLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 298);
            this.Controls.Add(this.lblLegenda);
            this.Controls.Add(this.dataGridLivro);
            this.Controls.Add(this.label1);
            this.Name = "ConsultaLivro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Livros";
            this.Activated += new System.EventHandler(this.ConsultaLivro_Activated);
            this.Load += new System.EventHandler(this.ConsultaLivro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLivro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrariaDBDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridLivro;
        private livrariaDBDataSet2 livrariaDBDataSet2;
        private System.Windows.Forms.BindingSource livroBindingSource;
        private livrariaDBDataSet2TableAdapters.LivroTableAdapter livroTableAdapter;
        private System.Windows.Forms.Label lblLegenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLivroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEditoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeLivroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edicaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoqueDataGridViewTextBoxColumn;
    }
}