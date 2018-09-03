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
    public partial class CadastroLivro : Form
    {
        public CadastroLivro()
        {
            InitializeComponent();
            comboBoxCategoria.SelectedItem = "terror";
        }

        private void buttonCadastroLivro_Click(object sender, EventArgs e)
        {
            LivroController liController = new LivroController();

            Livro livro = new Livro();
            livro.NomeLivro = textBoxNomeLivro.Text;
            livro.Autor = textBoxAutor.Text;
            livro.Preco = double.Parse(textBoxPreco.Text);
            livro.Edicao = textBoxEdicao.Text;
            livro.Categoria = comboBoxCategoria.SelectedItem.ToString();
            livro.Estoque = int.Parse(textEstoque.Text);
            livro.IdEditora = int.Parse(comboBoxNomeEditora.SelectedValue.ToString());

            liController.Requisicao(buttonCadastroLivro.Text, livro);
        }

        private void CadastroLivro_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'livrariaDBDataSet10.Editora'. Você pode movê-la ou removê-la conforme necessário.
            this.editoraTableAdapter1.Fill(this.livrariaDBDataSet10.Editora);
           
        }

        private void comboBoxNomeEditora_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textEstoque_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Somente números são permitidos");
                e.Handled = true;
            }
        }

        private void textBoxPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                MessageBox.Show("Somente números são permitidos");

                e.Handled = true;
            }
        }
    }
}
