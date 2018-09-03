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
    public partial class CadastroEditora : Form
    {
        public CadastroEditora()
        {
            InitializeComponent();
           
        }

        private void buttonCadastroEditora_Click(object sender, EventArgs e)
        {
            EditoraController edController = new EditoraController();

            Editora editora = new Editora();
            editora.NomeEditora = textBoxNomeEditora.Text;
            editora.TelefoneEditora = textBoxTelefoneEditora.Text;

            edController.Requisicao(buttonCadastroEditora.Text, editora);
        }

        private void textBoxTelefoneEditora_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Somente números são permitidos");
                e.Handled = true;
            }
        }
    }
}
