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
    public partial class ConsultaEditora : Form
    {
        public ConsultaEditora()
        {
            InitializeComponent();
        }

        private void ConsultaEditora_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'livrariaDBDataSet.Editora'. Você pode movê-la ou removê-la conforme necessário.
             // this.editoraTableAdapter.Fill(this.livrariaDBDataSet.Editora);

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            string nomeEditora = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            string telefone = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            

            ManutencaoEditora manutEdi = new ManutencaoEditora(id, telefone, nomeEditora);
            manutEdi.ShowDialog(this);
        }

        private void ConsultaEditora_Activated(object sender, EventArgs e)
        {
            this.editoraTableAdapter.Fill(this.livrariaDBDataSet.Editora);

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
