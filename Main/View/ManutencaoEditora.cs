using Main.Controller;
using Main.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main.View
{
    public partial class ManutencaoEditora : Form

    {
        private int id;
        public ManutencaoEditora(int id, string telefone, string nomeEditora)
        {
            InitializeComponent();
            this.id = id;
            txtTelefoneEditora.Text = telefone;
            textNomeEditora.Text = nomeEditora;

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            EditoraController ediCon = new EditoraController();
            Editora editora = new Editora();
            editora.NomeEditora = textNomeEditora.Text;
            editora.TelefoneEditora = txtTelefoneEditora.Text;
            editora.IdEditora = this.id;

            ediCon.Requisicao(btnAlterar.Text, editora);
        }


        private void btnExcluir_Click(object sender, EventArgs e)
        {
            EditoraController ediCon = new EditoraController();
            Editora editora = new Editora();
            editora.IdEditora = this.id;
            ediCon.Requisicao(btnExcluir.Text, editora);
        }

        private void txtTelefoneEditora_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                MessageBox.Show("Somente números são permitidos");

                e.Handled = true;
            }
        }

       
    }
}
