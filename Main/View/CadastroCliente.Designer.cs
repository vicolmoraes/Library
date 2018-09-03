namespace Main.View
{
    partial class CadastroCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textNomeCliente = new System.Windows.Forms.TextBox();
            this.textTelefoneCliente = new System.Windows.Forms.TextBox();
            this.textCpfCliente = new System.Windows.Forms.TextBox();
            this.btnCadastraCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Clientes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "CPF";
            // 
            // textNomeCliente
            // 
            this.textNomeCliente.Location = new System.Drawing.Point(141, 93);
            this.textNomeCliente.Name = "textNomeCliente";
            this.textNomeCliente.Size = new System.Drawing.Size(321, 20);
            this.textNomeCliente.TabIndex = 4;
            // 
            // textTelefoneCliente
            // 
            this.textTelefoneCliente.Location = new System.Drawing.Point(141, 137);
            this.textTelefoneCliente.Name = "textTelefoneCliente";
            this.textTelefoneCliente.Size = new System.Drawing.Size(321, 20);
            this.textTelefoneCliente.TabIndex = 5;
            this.textTelefoneCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textTelefoneCliente_KeyPress);
            // 
            // textCpfCliente
            // 
            this.textCpfCliente.Location = new System.Drawing.Point(141, 188);
            this.textCpfCliente.Name = "textCpfCliente";
            this.textCpfCliente.Size = new System.Drawing.Size(321, 20);
            this.textCpfCliente.TabIndex = 6;
            this.textCpfCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCpfCliente_KeyPress);
            // 
            // btnCadastraCliente
            // 
            this.btnCadastraCliente.Location = new System.Drawing.Point(207, 227);
            this.btnCadastraCliente.Name = "btnCadastraCliente";
            this.btnCadastraCliente.Size = new System.Drawing.Size(96, 23);
            this.btnCadastraCliente.TabIndex = 7;
            this.btnCadastraCliente.Text = "Cadastrar!";
            this.btnCadastraCliente.UseVisualStyleBackColor = true;
            this.btnCadastraCliente.Click += new System.EventHandler(this.btnCadastraCliente_Click);
            // 
            // CadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 262);
            this.Controls.Add(this.btnCadastraCliente);
            this.Controls.Add(this.textCpfCliente);
            this.Controls.Add(this.textTelefoneCliente);
            this.Controls.Add(this.textNomeCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CadastroCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textNomeCliente;
        private System.Windows.Forms.TextBox textTelefoneCliente;
        private System.Windows.Forms.TextBox textCpfCliente;
        private System.Windows.Forms.Button btnCadastraCliente;
    }
}