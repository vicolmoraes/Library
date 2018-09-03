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
    public partial class ConsultaLivro : Form
    {
        public ConsultaLivro()
        {
            InitializeComponent();
        }

        private void ConsultaLivro_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'livrariaDBDataSet2.Livro'. Você pode movê-la ou removê-la conforme necessário.
           // this.livroTableAdapter.Fill(this.livrariaDBDataSet2.Livro);

        }

        private void dataGridLivro_DoubleClick(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridLivro.SelectedRows[0].Cells[0].Value.ToString());
            int idEditora = Convert.ToInt32(dataGridLivro.SelectedRows[0].Cells[1].Value.ToString());
            string nomeLivro = dataGridLivro.SelectedRows[0].Cells[2].Value.ToString();
            string categoria = dataGridLivro.SelectedRows[0].Cells[3].Value.ToString();
            double preco = Convert.ToDouble(dataGridLivro.SelectedRows[0].Cells[4].Value.ToString());
            string edicao = dataGridLivro.SelectedRows[0].Cells[5].Value.ToString();
            string autor = dataGridLivro.SelectedRows[0].Cells[6].Value.ToString();
            int estoque = Convert.ToInt32(dataGridLivro.SelectedRows[0].Cells[7].Value.ToString());


            ManutencaoLivro manutLi = new ManutencaoLivro(id, idEditora, nomeLivro, categoria, preco, edicao, autor,estoque);
            manutLi.ShowDialog(this);
        }

        private void ConsultaLivro_Activated(object sender, EventArgs e)
        {
            this.livroTableAdapter.Fill(this.livrariaDBDataSet2.Livro);
        }

        private void dataGridLivro_MouseEnter(object sender, EventArgs e)
        {
            lblLegenda.Visible = true;
        }

        private void dataGridLivro_MouseLeave(object sender, EventArgs e)
        {
            lblLegenda.Visible = false;
        }
    }
}
