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
    public partial class ConsultarPedidoItem : Form
    {
        public ConsultarPedidoItem()
        {
            InitializeComponent();
        }

        private void ConsultarPedidoItem_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'livrariaDBDataSet22.Item'. Você pode movê-la ou removê-la conforme necessário.
          // this.itemTableAdapter.Fill(this.livrariaDBDataSet22.Item);
            // TODO: esta linha de código carrega dados na tabela 'livrariaDBDataSet7.Pedido'. Você pode movê-la ou removê-la conforme necessário.
            //this.pedidoTableAdapter.Fill(this.livrariaDBDataSet7.Pedido);

        }

        private void dataGridPedido_DoubleClick(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridPedido.SelectedRows[0].Cells[0].Value.ToString());
            int idCliente = Convert.ToInt32(dataGridPedido.SelectedRows[0].Cells[1].Value.ToString());
            DateTime data = Convert.ToDateTime(dataGridPedido.SelectedRows[0].Cells[2].Value.ToString());
            double valor = Convert.ToDouble(dataGridPedido.SelectedRows[0].Cells[3].Value.ToString());
            ManutencaoPedido manutPe = new ManutencaoPedido(id, idCliente, data, valor);
            manutPe.ShowDialog(this);
        }

        private void dataGridItem_DoubleClick(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridItem.SelectedRows[0].Cells[0].Value.ToString());
            int idLivro = Convert.ToInt32(dataGridItem.SelectedRows[0].Cells[1].Value.ToString());
            int idPedido = Convert.ToInt32(dataGridItem.SelectedRows[0].Cells[2].Value.ToString());
            int quantidade = Convert.ToInt32(dataGridItem.SelectedRows[0].Cells[3].Value.ToString());
            ManutencaoItem manutItem = new ManutencaoItem(id, idLivro, idPedido, quantidade);
            manutItem.ShowDialog(this);
        }

        private void ConsultarPedidoItem_Activated(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'livrariaDBDataSet22.Item'. Você pode movê-la ou removê-la conforme necessário.
            this.itemTableAdapter.Fill(this.livrariaDBDataSet22.Item);
            // TODO: esta linha de código carrega dados na tabela 'livrariaDBDataSet7.Pedido'. Você pode movê-la ou removê-la conforme necessário.
           this.pedidoTableAdapter.Fill(this.livrariaDBDataSet7.Pedido);

        }

        private void dataGridPedido_MouseEnter(object sender, EventArgs e)
        {
            lblLegenda.Visible = true;
        }

        private void dataGridPedido_MouseLeave(object sender, EventArgs e)
        {
            lblLegenda.Visible = false;
        }

        private void dataGridItem_MouseEnter(object sender, EventArgs e)
        {
            lblLegenda.Visible = true;
        }

        private void dataGridItem_MouseLeave(object sender, EventArgs e)
        {
            lblLegenda.Visible = false;
        }
    }
}
