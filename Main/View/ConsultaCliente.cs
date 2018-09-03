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
    public partial class ConsultaCliente : Form
    {
        public ConsultaCliente()
        {
            InitializeComponent();
        }

        private void ConsultaCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'livrariaDBDataSet21.Cliente'. Você pode movê-la ou removê-la conforme necessário.
           // this.clienteTableAdapter1.Fill(this.livrariaDBDataSet21.Cliente);
            // TODO: esta linha de código carrega dados na tabela 'livrariaDBDataSet1.Cliente'. Você pode movê-la ou removê-la conforme necessário.
           // this.clienteTableAdapter.Fill(this.livrariaDBDataSet1.Cliente);

        }



        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            string nomeCliente = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            string telefone = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            string cpf = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();


            ManutencaoCliente manutCli = new ManutencaoCliente(id, telefone, nomeCliente, cpf);
            manutCli.ShowDialog(this);
        }

        private void ConsultaCliente_Activated(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'livrariaDBDataSet21.Cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter1.Fill(this.livrariaDBDataSet21.Cliente);
            // TODO: esta linha de código carrega dados na tabela 'livrariaDBDataSet1.Cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.livrariaDBDataSet1.Cliente);
        }

        private void dataGridView1_MouseEnter(object sender, EventArgs e)
        {
            lblLegenda.Visible = true;
        }

        private void dataGridView1_MouseLeave(object sender, EventArgs e)
        {
            lblLegenda.Visible = false;
        }
    }
}
