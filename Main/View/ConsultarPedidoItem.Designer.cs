namespace Main.View
{
    partial class ConsultarPedidoItem
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
            this.dataGridPedido = new System.Windows.Forms.DataGridView();
            this.pedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.livrariaDBDataSet7 = new Main.livrariaDBDataSet7();
            this.pedidoTableAdapter = new Main.livrariaDBDataSet7TableAdapters.PedidoTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridItem = new System.Windows.Forms.DataGridView();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.livrariaDBDataSet22 = new Main.livrariaDBDataSet22();
            this.itemTableAdapter = new Main.livrariaDBDataSet22TableAdapters.ItemTableAdapter();
            this.lblLegenda = new System.Windows.Forms.Label();
            this.idItemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idLivroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPedidoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorPedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrariaDBDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrariaDBDataSet22)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridPedido
            // 
            this.dataGridPedido.AllowUserToAddRows = false;
            this.dataGridPedido.AllowUserToDeleteRows = false;
            this.dataGridPedido.AutoGenerateColumns = false;
            this.dataGridPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPedidoDataGridViewTextBoxColumn,
            this.idClienteDataGridViewTextBoxColumn,
            this.dataPedidoDataGridViewTextBoxColumn,
            this.valorPedidoDataGridViewTextBoxColumn});
            this.dataGridPedido.DataSource = this.pedidoBindingSource;
            this.dataGridPedido.Location = new System.Drawing.Point(24, 110);
            this.dataGridPedido.Name = "dataGridPedido";
            this.dataGridPedido.ReadOnly = true;
            this.dataGridPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPedido.Size = new System.Drawing.Size(457, 182);
            this.dataGridPedido.TabIndex = 0;
            this.dataGridPedido.DoubleClick += new System.EventHandler(this.dataGridPedido_DoubleClick);
            this.dataGridPedido.MouseEnter += new System.EventHandler(this.dataGridPedido_MouseEnter);
            this.dataGridPedido.MouseLeave += new System.EventHandler(this.dataGridPedido_MouseLeave);
            // 
            // pedidoBindingSource
            // 
            this.pedidoBindingSource.DataMember = "Pedido";
            this.pedidoBindingSource.DataSource = this.livrariaDBDataSet7;
            // 
            // livrariaDBDataSet7
            // 
            this.livrariaDBDataSet7.DataSetName = "livrariaDBDataSet7";
            this.livrariaDBDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pedidoTableAdapter
            // 
            this.pedidoTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(451, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Consultar ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(215, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Pedido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(737, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Item";
            // 
            // dataGridItem
            // 
            this.dataGridItem.AllowUserToAddRows = false;
            this.dataGridItem.AllowUserToDeleteRows = false;
            this.dataGridItem.AutoGenerateColumns = false;
            this.dataGridItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idItemDataGridViewTextBoxColumn,
            this.idLivroDataGridViewTextBoxColumn,
            this.idPedidoDataGridViewTextBoxColumn1,
            this.quantidadeDataGridViewTextBoxColumn});
            this.dataGridItem.DataSource = this.itemBindingSource;
            this.dataGridItem.Location = new System.Drawing.Point(497, 110);
            this.dataGridItem.Name = "dataGridItem";
            this.dataGridItem.ReadOnly = true;
            this.dataGridItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridItem.Size = new System.Drawing.Size(457, 182);
            this.dataGridItem.TabIndex = 9;
            this.dataGridItem.DoubleClick += new System.EventHandler(this.dataGridItem_DoubleClick);
            this.dataGridItem.MouseEnter += new System.EventHandler(this.dataGridItem_MouseEnter);
            this.dataGridItem.MouseLeave += new System.EventHandler(this.dataGridItem_MouseLeave);
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataMember = "Item";
            this.itemBindingSource.DataSource = this.livrariaDBDataSet22;
            // 
            // livrariaDBDataSet22
            // 
            this.livrariaDBDataSet22.DataSetName = "livrariaDBDataSet22";
            this.livrariaDBDataSet22.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemTableAdapter
            // 
            this.itemTableAdapter.ClearBeforeFill = true;
            // 
            // lblLegenda
            // 
            this.lblLegenda.AutoSize = true;
            this.lblLegenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLegenda.Location = new System.Drawing.Point(356, 308);
            this.lblLegenda.Name = "lblLegenda";
            this.lblLegenda.Size = new System.Drawing.Size(353, 20);
            this.lblLegenda.TabIndex = 10;
            this.lblLegenda.Text = "* Dê um duplo clique para alterar ou excluir";
            // 
            // idItemDataGridViewTextBoxColumn
            // 
            this.idItemDataGridViewTextBoxColumn.DataPropertyName = "IdItem";
            this.idItemDataGridViewTextBoxColumn.HeaderText = "Código do Item";
            this.idItemDataGridViewTextBoxColumn.Name = "idItemDataGridViewTextBoxColumn";
            this.idItemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idLivroDataGridViewTextBoxColumn
            // 
            this.idLivroDataGridViewTextBoxColumn.DataPropertyName = "IdLivro";
            this.idLivroDataGridViewTextBoxColumn.HeaderText = "Código do Livro";
            this.idLivroDataGridViewTextBoxColumn.Name = "idLivroDataGridViewTextBoxColumn";
            this.idLivroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idPedidoDataGridViewTextBoxColumn1
            // 
            this.idPedidoDataGridViewTextBoxColumn1.DataPropertyName = "IdPedido";
            this.idPedidoDataGridViewTextBoxColumn1.HeaderText = "Código do Pedido";
            this.idPedidoDataGridViewTextBoxColumn1.Name = "idPedidoDataGridViewTextBoxColumn1";
            this.idPedidoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            this.quantidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idPedidoDataGridViewTextBoxColumn
            // 
            this.idPedidoDataGridViewTextBoxColumn.DataPropertyName = "IdPedido";
            this.idPedidoDataGridViewTextBoxColumn.HeaderText = "Código do Pedido";
            this.idPedidoDataGridViewTextBoxColumn.Name = "idPedidoDataGridViewTextBoxColumn";
            this.idPedidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            this.idClienteDataGridViewTextBoxColumn.DataPropertyName = "IdCliente";
            this.idClienteDataGridViewTextBoxColumn.HeaderText = "Código do Cliente";
            this.idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            this.idClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataPedidoDataGridViewTextBoxColumn
            // 
            this.dataPedidoDataGridViewTextBoxColumn.DataPropertyName = "DataPedido";
            this.dataPedidoDataGridViewTextBoxColumn.HeaderText = "Data do Pedido";
            this.dataPedidoDataGridViewTextBoxColumn.Name = "dataPedidoDataGridViewTextBoxColumn";
            this.dataPedidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorPedidoDataGridViewTextBoxColumn
            // 
            this.valorPedidoDataGridViewTextBoxColumn.DataPropertyName = "ValorPedido";
            this.valorPedidoDataGridViewTextBoxColumn.HeaderText = "Valor Total do Pedido";
            this.valorPedidoDataGridViewTextBoxColumn.Name = "valorPedidoDataGridViewTextBoxColumn";
            this.valorPedidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ConsultarPedidoItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 337);
            this.Controls.Add(this.lblLegenda);
            this.Controls.Add(this.dataGridItem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridPedido);
            this.Name = "ConsultarPedidoItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultarPedido";
            this.Activated += new System.EventHandler(this.ConsultarPedidoItem_Activated);
            this.Load += new System.EventHandler(this.ConsultarPedidoItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrariaDBDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrariaDBDataSet22)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridPedido;
        private livrariaDBDataSet7 livrariaDBDataSet7;
        private System.Windows.Forms.BindingSource pedidoBindingSource;
        private livrariaDBDataSet7TableAdapters.PedidoTableAdapter pedidoTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridItem;
        private livrariaDBDataSet22 livrariaDBDataSet22;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private livrariaDBDataSet22TableAdapters.ItemTableAdapter itemTableAdapter;
        private System.Windows.Forms.Label lblLegenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataPedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorPedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idItemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLivroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPedidoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
    }
}