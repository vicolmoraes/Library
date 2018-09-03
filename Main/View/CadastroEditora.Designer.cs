namespace Main.View
{
    partial class CadastroEditora
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
            this.textBoxNomeEditora = new System.Windows.Forms.TextBox();
            this.textBoxTelefoneEditora = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCadastroEditora = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Editoras";
            // 
            // textBoxNomeEditora
            // 
            this.textBoxNomeEditora.Location = new System.Drawing.Point(145, 104);
            this.textBoxNomeEditora.Name = "textBoxNomeEditora";
            this.textBoxNomeEditora.Size = new System.Drawing.Size(345, 20);
            this.textBoxNomeEditora.TabIndex = 1;
            // 
            // textBoxTelefoneEditora
            // 
            this.textBoxTelefoneEditora.Location = new System.Drawing.Point(145, 166);
            this.textBoxTelefoneEditora.Name = "textBoxTelefoneEditora";
            this.textBoxTelefoneEditora.Size = new System.Drawing.Size(345, 20);
            this.textBoxTelefoneEditora.TabIndex = 2;
            this.textBoxTelefoneEditora.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTelefoneEditora_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome da Editora";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefone da Editora";
            // 
            // buttonCadastroEditora
            // 
            this.buttonCadastroEditora.Location = new System.Drawing.Point(231, 217);
            this.buttonCadastroEditora.Name = "buttonCadastroEditora";
            this.buttonCadastroEditora.Size = new System.Drawing.Size(96, 23);
            this.buttonCadastroEditora.TabIndex = 5;
            this.buttonCadastroEditora.Text = "Cadastrar!";
            this.buttonCadastroEditora.UseVisualStyleBackColor = true;
            this.buttonCadastroEditora.Click += new System.EventHandler(this.buttonCadastroEditora_Click);
            // 
            // CadastroEditora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 262);
            this.Controls.Add(this.buttonCadastroEditora);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTelefoneEditora);
            this.Controls.Add(this.textBoxNomeEditora);
            this.Controls.Add(this.label1);
            this.Name = "CadastroEditora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroEditora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNomeEditora;
        private System.Windows.Forms.TextBox textBoxTelefoneEditora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCadastroEditora;
    }
}