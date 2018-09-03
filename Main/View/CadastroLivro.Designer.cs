namespace Main.View
{
    partial class CadastroLivro
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
            this.textBoxNomeLivro = new System.Windows.Forms.TextBox();
            this.textBoxPreco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCadastroLivro = new System.Windows.Forms.Button();
            this.comboBoxNomeEditora = new System.Windows.Forms.ComboBox();
            this.editoraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.livrariaDBDataSet3 = new Main.livrariaDBDataSet3();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxEdicao = new System.Windows.Forms.TextBox();
            this.textBoxAutor = new System.Windows.Forms.TextBox();
            this.editoraTableAdapter = new Main.livrariaDBDataSet3TableAdapters.EditoraTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.textEstoque = new System.Windows.Forms.TextBox();
            this.livrariaDBDataSet10 = new Main.livrariaDBDataSet10();
            this.editoraBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.editoraTableAdapter1 = new Main.livrariaDBDataSet10TableAdapters.EditoraTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.editoraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrariaDBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrariaDBDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editoraBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Livros";
            // 
            // textBoxNomeLivro
            // 
            this.textBoxNomeLivro.Location = new System.Drawing.Point(145, 104);
            this.textBoxNomeLivro.Name = "textBoxNomeLivro";
            this.textBoxNomeLivro.Size = new System.Drawing.Size(345, 20);
            this.textBoxNomeLivro.TabIndex = 1;
            // 
            // textBoxPreco
            // 
            this.textBoxPreco.Location = new System.Drawing.Point(145, 323);
            this.textBoxPreco.Name = "textBoxPreco";
            this.textBoxPreco.Size = new System.Drawing.Size(336, 20);
            this.textBoxPreco.TabIndex = 2;
            this.textBoxPreco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPreco_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome do Livro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nome da Editora";
            // 
            // buttonCadastroLivro
            // 
            this.buttonCadastroLivro.Location = new System.Drawing.Point(221, 546);
            this.buttonCadastroLivro.Name = "buttonCadastroLivro";
            this.buttonCadastroLivro.Size = new System.Drawing.Size(96, 23);
            this.buttonCadastroLivro.TabIndex = 5;
            this.buttonCadastroLivro.Text = "Cadastrar!";
            this.buttonCadastroLivro.UseVisualStyleBackColor = true;
            this.buttonCadastroLivro.Click += new System.EventHandler(this.buttonCadastroLivro_Click);
            // 
            // comboBoxNomeEditora
            // 
            this.comboBoxNomeEditora.DataSource = this.editoraBindingSource1;
            this.comboBoxNomeEditora.DisplayMember = "NomeEditora";
            this.comboBoxNomeEditora.FormattingEnabled = true;
            this.comboBoxNomeEditora.Location = new System.Drawing.Point(145, 170);
            this.comboBoxNomeEditora.Name = "comboBoxNomeEditora";
            this.comboBoxNomeEditora.Size = new System.Drawing.Size(336, 21);
            this.comboBoxNomeEditora.TabIndex = 6;
            this.comboBoxNomeEditora.ValueMember = "IdEditora";
            this.comboBoxNomeEditora.SelectedIndexChanged += new System.EventHandler(this.comboBoxNomeEditora_SelectedIndexChanged);
            // 
            // editoraBindingSource
            // 
            this.editoraBindingSource.DataMember = "Editora";
            this.editoraBindingSource.DataSource = this.livrariaDBDataSet3;
            // 
            // livrariaDBDataSet3
            // 
            this.livrariaDBDataSet3.DataSetName = "livrariaDBDataSet3";
            this.livrariaDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Categoria";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Preço";
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.AutoCompleteCustomSource.AddRange(new string[] {
            "Ficção",
            "Romance",
            "Aventura",
            "Policial",
            "Drama",
            "Terror",
            "Didático",
            "Enciclopédia",
            "Economia",
            "Auto-ajuda",
            "Revista",
            "Direito",
            "Medicina"});
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Items.AddRange(new object[] {
            "ficção",
            "terror",
            "drama",
            "religioso",
            "didático"});
            this.comboBoxCategoria.Location = new System.Drawing.Point(145, 252);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(336, 21);
            this.comboBoxCategoria.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 390);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Edição";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 458);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Autor";
            // 
            // textBoxEdicao
            // 
            this.textBoxEdicao.Location = new System.Drawing.Point(145, 390);
            this.textBoxEdicao.Name = "textBoxEdicao";
            this.textBoxEdicao.Size = new System.Drawing.Size(345, 20);
            this.textBoxEdicao.TabIndex = 12;
            // 
            // textBoxAutor
            // 
            this.textBoxAutor.Location = new System.Drawing.Point(145, 457);
            this.textBoxAutor.Name = "textBoxAutor";
            this.textBoxAutor.Size = new System.Drawing.Size(345, 20);
            this.textBoxAutor.TabIndex = 13;
            // 
            // editoraTableAdapter
            // 
            this.editoraTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 510);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Estoque";
            // 
            // textEstoque
            // 
            this.textEstoque.Location = new System.Drawing.Point(145, 510);
            this.textEstoque.Name = "textEstoque";
            this.textEstoque.Size = new System.Drawing.Size(345, 20);
            this.textEstoque.TabIndex = 15;
            this.textEstoque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEstoque_KeyPress);
            // 
            // livrariaDBDataSet10
            // 
            this.livrariaDBDataSet10.DataSetName = "livrariaDBDataSet10";
            this.livrariaDBDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // editoraBindingSource1
            // 
            this.editoraBindingSource1.DataMember = "Editora";
            this.editoraBindingSource1.DataSource = this.livrariaDBDataSet10;
            // 
            // editoraTableAdapter1
            // 
            this.editoraTableAdapter1.ClearBeforeFill = true;
            // 
            // CadastroLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 581);
            this.Controls.Add(this.textEstoque);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxAutor);
            this.Controls.Add(this.textBoxEdicao);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxCategoria);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxNomeEditora);
            this.Controls.Add(this.buttonCadastroLivro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPreco);
            this.Controls.Add(this.textBoxNomeLivro);
            this.Controls.Add(this.label1);
            this.Name = "CadastroLivro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Livro";
            this.Load += new System.EventHandler(this.CadastroLivro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.editoraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrariaDBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrariaDBDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editoraBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNomeLivro;
        private System.Windows.Forms.TextBox textBoxPreco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCadastroLivro;
        private System.Windows.Forms.ComboBox comboBoxNomeEditora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxEdicao;
        private System.Windows.Forms.TextBox textBoxAutor;
        private livrariaDBDataSet3 livrariaDBDataSet3;
        private System.Windows.Forms.BindingSource editoraBindingSource;
        private livrariaDBDataSet3TableAdapters.EditoraTableAdapter editoraTableAdapter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textEstoque;
        private livrariaDBDataSet10 livrariaDBDataSet10;
        private System.Windows.Forms.BindingSource editoraBindingSource1;
        private livrariaDBDataSet10TableAdapters.EditoraTableAdapter editoraTableAdapter1;
    }
}