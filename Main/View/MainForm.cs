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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void cadastrarEditora_Click(object sender, EventArgs e)
        {
            CadastroEditora cadEditora = new CadastroEditora();
            
            cadEditora.ShowDialog(this);
            
        }

        private void cadastrarLivro_Click(object sender, EventArgs e)
        {
            CadastroLivro cadLivro = new CadastroLivro();
            cadLivro.ShowDialog(this);

        }

        private void cadastrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CadastroCliente cadastra = new CadastroCliente();
            cadastra.ShowDialog(this);
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroPedidoItem pedido = new CadastroPedidoItem();
            pedido.ShowDialog(this);
    
        }

        private void consultarEditora_Click(object sender, EventArgs e)
        {
            ConsultaEditora consulta = new ConsultaEditora();
            consulta.ShowDialog(this);
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaLivro livro = new ConsultaLivro();
            livro.ShowDialog(this);
        }

        private void consultarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ConsultaCliente cliente = new ConsultaCliente();
            cliente.ShowDialog(this);
        }

        private void consultarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ConsultarPedidoItem consulta = new ConsultarPedidoItem();
            consulta.ShowDialog(this);
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sistema para uma Livraria\n Projeto para disciplina de A5LP1", "Sobre",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
