using Main.Controller;
using Main.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main.View
{
    public partial class CadastroPedidoItem : Form

    { 
        PedidoController controla = new PedidoController();
        Pedido a = new Pedido();
        Item item = new Item();
        public CadastroPedidoItem()
        {   
            InitializeComponent();
            labelData.Text = DateTime.Now.ToString("dd/MM/yyyy");
 
        }

        private void AberturaItem_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'livrariaDBDataSet24joinview.JoinVIEW'. Você pode movê-la ou removê-la conforme necessário.
            //this.joinVIEWTableAdapter1.Fill(this.livrariaDBDataSet24joinview.JoinVIEW);
            // TODO: esta linha de código carrega dados na tabela 'livrariaDBDataSet23.JoinVIEW'. Você pode movê-la ou removê-la conforme necessário.
            //  this.joinVIEWTableAdapter.Fill(this.livrariaDBDataSet23.JoinVIEW);
            // TODO: esta linha de código carrega dados na tabela 'livrariaDBDataSet19.Cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.livrariaDBDataSet19.Cliente);
            // TODO: esta linha de código carrega dados na tabela 'livrariaDBDataSet18.Livro'. Você pode movê-la ou removê-la conforme necessário.
            this.livroTableAdapter2.Fill(this.livrariaDBDataSet18.Livro);

        }
        private void cadastraPedido1_Click(object sender, EventArgs e)
        {
            
            a.DataPedido = DateTime.Parse(labelData.Text);
            a.IdCliente = int.Parse(comboBoxNomePedido.SelectedValue.ToString());
            
            controla.Requisicao(cadastraPedido1.Text, a);

        }


        private void buttonCadastroPedido_Click(object sender, EventArgs e)
        {
            
            ItemController itemc = new ItemController();
            LivroController livroc = new LivroController();

            item.IdPedido = a.IdPedido;
            item.Quantidade = int.Parse(textQuantidade.Text);
            item.IdLivro = int.Parse(comboBoxLivro.SelectedValue.ToString());
            Livro livro1 = livroc.ObterEstoquePorId(item.IdLivro);
            int estoque = livro1.Estoque;

            if (estoque >= item.Quantidade)
            {
                livroc.AlterarEstoque(item.Quantidade, estoque, item.IdLivro);

                Livro livro = livroc.ObterPrecoPorId(item.IdLivro);
                double valor = livro.Preco;
                labelValorTotal.Text = (Convert.ToDouble(labelValorTotal.Text) + (valor * item.Quantidade)).ToString();

                itemc.Requisicao(buttonCadastroPedido.Text, item);
               if (item.IdPedido != 0)
                    this.joinVIEWTableAdapter1.FillByjoin(this.livrariaDBDataSet24joinview.JoinVIEW) ;
            }
            else if (item.IdPedido != 0) MessageBox.Show("Estoque Insuficiente!! \nO estoque é de " + estoque + " livros");

        }

 
        private void buttonFinalizar_Click(object sender, EventArgs e)
        {
            PedidoController pedidoc = new PedidoController();
            pedidoc.AlterarValor(a.IdPedido, Convert.ToDouble(labelValorTotal.Text));
            MessageBox.Show("Sua compra tem o valor de " + labelValorTotal.Text + " reais");
            CadastroPedidoItem.ActiveForm.Close();

        }

        private void textQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Somente números são permitidos");
                e.Handled = true;
            }
        }

        private void cadastraPedido1_MouseEnter(object sender, EventArgs e)
        {
            labelLegenda.Visible = true;
        }

        private void cadastraPedido1_MouseLeave(object sender, EventArgs e)
        {
            labelLegenda.Visible = false;
        }
    }
}
