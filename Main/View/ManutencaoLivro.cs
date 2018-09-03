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
    public partial class ManutencaoLivro : Form
    {private int id;
        private int idEditora; 
        public ManutencaoLivro(int id,int idEditora,string nomeLivro, string categoria,double preco,string edicao,string autor,int estoque)
        {
            InitializeComponent();
            this.id = id;
            this.idEditora = idEditora;
            txtNomeLivro.Text = nomeLivro;
            txtCategoria.Text = categoria;
            txtPreco.Text = preco.ToString();
            txtEdicao.Text = edicao;
            txtAutor.Text = autor;
            txtEstoque.Text = estoque.ToString();


        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            LivroController livroCon = new LivroController();
            Livro livro = new Livro();
            livro.NomeLivro = txtNomeLivro.Text;
            livro.Categoria = txtCategoria.Text;
            livro.Preco = Convert.ToDouble( txtPreco.Text);
            livro.Edicao = txtEdicao.Text;
            livro.Autor = txtAutor.Text;
            livro.Estoque= Convert.ToInt32(txtEstoque.Text);
            livro.IdEditora = this.idEditora;
            livro.IdLivro = this.id;

            livroCon.Requisicao(btnAlterar.Text, livro);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            LivroController livroCon = new LivroController();
            Livro livro = new Livro();
            livro.IdLivro = this.id;
            livroCon.Requisicao(btnExcluir.Text, livro);
        }

        private void txtPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                MessageBox.Show("Somente números são permitidos");

                e.Handled = true;
            }
        }

        private void txtEdicao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Somente números são permitidos");
                e.Handled = true;
            }
        }

        private void txtEstoque_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Somente números são permitidos");
                e.Handled = true;
            }
        }
    }
}
