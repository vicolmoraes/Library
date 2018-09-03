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
    public partial class ManutencaoItem : Form
    {
        private int id;
        private int idLivro;
        private int idPedido;
        public ManutencaoItem(int id,int idLivro,int idPedido,int quantidade)
        {
            InitializeComponent();
           txtQuantidade.Text = quantidade.ToString();
            this.id = id;
            this.idLivro = idLivro;
            this.idPedido = idPedido;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            ItemController itemCon = new ItemController();
            LivroController livroc = new LivroController();
            Item item = new Item();
            item.Quantidade =Convert.ToInt32( txtQuantidade.Text);
            item.IdItem = this.id;
            item.IdItem = this.idLivro;
            item.IdPedido = this.idPedido;
            Livro livro1 = livroc.ObterEstoquePorId(item.IdLivro);
            int estoque = livro1.Estoque;

            itemCon.Requisicao(btnAlterar.Text, item);

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ItemController itemCon = new ItemController();
            Item item = new Item();
            item.IdItem = this.id;
            itemCon.Requisicao(btnExcluir.Text, item);
        
    }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Somente números são permitidos");
                e.Handled = true;
            }
        }

        
    }
}
