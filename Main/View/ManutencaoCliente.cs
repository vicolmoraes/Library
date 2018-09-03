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
    public partial class ManutencaoCliente : Form
    {
        private int id;
        public ManutencaoCliente(int id, string telefoneCliente, string nomeCliente, string cpfCliente)
        {
            InitializeComponent();
            this.id = id;
            textNome.Text = nomeCliente;
            txtTelefone.Text = telefoneCliente;
            textCpf.Text = cpfCliente;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            ClienteController ediCon = new ClienteController();
            Cliente cliente = new Cliente();
            cliente.NomeCliente = textNome.Text;
            cliente.TelefoneCliente = txtTelefone.Text;
            cliente.CPF = textCpf.Text;
            cliente.IdCliente= this.id;
            ediCon.Requisicao(btnAlterar.Text, cliente);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ClienteController ediCon = new ClienteController();
            Cliente cliente = new Cliente();
            cliente.IdCliente = this.id;
            ediCon.Requisicao(btnExcluir.Text, cliente);
        }

        private void textCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                MessageBox.Show("Somente números são permitidos");

                e.Handled = true;
            }
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                MessageBox.Show("Somente números são permitidos");

                e.Handled = true;
            }
        }
    }
}
