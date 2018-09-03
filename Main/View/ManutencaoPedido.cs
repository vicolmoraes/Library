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
    public partial class ManutencaoPedido : Form
    {
        private int id;
        private int idCliente;
        public ManutencaoPedido(int id,int idCliente,DateTime data,double valor)
        {
            InitializeComponent();
            this.id = id;
            this.idCliente = idCliente;
            txtData.Text = data.ToString();
            txtValor.Text = valor.ToString();

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            PedidoController pediCon = new PedidoController();
            Pedido pedido = new Pedido();
            pedido.DataPedido =Convert.ToDateTime( txtData.Text);
            pedido.ValorPedido = Convert.ToDouble(txtValor.Text);
            pedido.IdPedido = this.id;
            pedido.IdCliente = this.idCliente;
            pediCon.Requisicao(btnAlterar.Text, pedido);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            PedidoController pediCon = new PedidoController();
            Pedido pedido = new Pedido();
            pedido.IdPedido = this.id;
            pediCon.Requisicao(btnExcluir.Text, pedido);
        }

        private void txtData_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                MessageBox.Show("Somente números são permitidos");

                e.Handled = true;
            }
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                MessageBox.Show("Somente números são permitidos");

                e.Handled = true;
            }
        }
    }
}
