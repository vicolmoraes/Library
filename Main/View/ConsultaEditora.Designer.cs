namespace Main.View
{
    partial class ConsultaEditora
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.editoraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.livrariaDBDataSet = new Main.livrariaDBDataSet();
            this.editoraTableAdapter = new Main.livrariaDBDataSetTableAdapters.EditoraTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLegenda = new System.Windows.Forms.Label();
            this.idEditoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeEditoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneEditoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editoraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrariaDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEditoraDataGridViewTextBoxColumn,
            this.nomeEditoraDataGridViewTextBoxColumn,
            this.telefoneEditoraDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.editoraBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(70, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(394, 209);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            this.dataGridView1.MouseEnter += new System.EventHandler(this.dataGridView1_MouseEnter);
            this.dataGridView1.MouseLeave += new System.EventHandler(this.dataGridView1_MouseLeave);
            // 
            // editoraBindingSource
            // 
            this.editoraBindingSource.DataMember = "Editora";
            this.editoraBindingSource.DataSource = this.livrariaDBDataSet;
            // 
            // livrariaDBDataSet
            // 
            this.livrariaDBDataSet.DataSetName = "livrariaDBDataSet";
            this.livrariaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // editoraTableAdapter
            // 
            this.editoraTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Consulta de Editoras";
            // 
            // lblLegenda
            // 
            this.lblLegenda.AutoSize = true;
            this.lblLegenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLegenda.Location = new System.Drawing.Point(84, 265);
            this.lblLegenda.Name = "lblLegenda";
            this.lblLegenda.Size = new System.Drawing.Size(353, 20);
            this.lblLegenda.TabIndex = 11;
            this.lblLegenda.Text = "* Dê um duplo clique para alterar ou excluir";
            // 
            // idEditoraDataGridViewTextBoxColumn
            // 
            this.idEditoraDataGridViewTextBoxColumn.DataPropertyName = "IdEditora";
            this.idEditoraDataGridViewTextBoxColumn.HeaderText = "Código";
            this.idEditoraDataGridViewTextBoxColumn.Name = "idEditoraDataGridViewTextBoxColumn";
            this.idEditoraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeEditoraDataGridViewTextBoxColumn
            // 
            this.nomeEditoraDataGridViewTextBoxColumn.DataPropertyName = "NomeEditora";
            this.nomeEditoraDataGridViewTextBoxColumn.HeaderText = "Nome da Editora";
            this.nomeEditoraDataGridViewTextBoxColumn.Name = "nomeEditoraDataGridViewTextBoxColumn";
            this.nomeEditoraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefoneEditoraDataGridViewTextBoxColumn
            // 
            this.telefoneEditoraDataGridViewTextBoxColumn.DataPropertyName = "TelefoneEditora";
            this.telefoneEditoraDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneEditoraDataGridViewTextBoxColumn.Name = "telefoneEditoraDataGridViewTextBoxColumn";
            this.telefoneEditoraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ConsultaEditora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 294);
            this.Controls.Add(this.lblLegenda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ConsultaEditora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Editoras";
            this.Activated += new System.EventHandler(this.ConsultaEditora_Activated);
            this.Load += new System.EventHandler(this.ConsultaEditora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editoraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrariaDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private livrariaDBDataSet livrariaDBDataSet;
        private System.Windows.Forms.BindingSource editoraBindingSource;
        private livrariaDBDataSetTableAdapters.EditoraTableAdapter editoraTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLegenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEditoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeEditoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneEditoraDataGridViewTextBoxColumn;
    }
}