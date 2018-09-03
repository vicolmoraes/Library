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
    public partial class CadastroCliente : Form
    {
        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastraCliente_Click(object sender, EventArgs e)
        {
            ClienteController clienteCon = new ClienteController();
            Cliente cliente = new Cliente();
            cliente.NomeCliente = textNomeCliente.Text;
            cliente.TelefoneCliente = textTelefoneCliente.Text;
            cliente.CPF = textCpfCliente.Text;

            clienteCon.Requisicao(btnCadastraCliente.Text, cliente);
        }

        private void textTelefoneCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Somente números são permitidos");
                e.Handled = true;
            }
        }

        private void textCpfCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Somente números são permitidos");
                e.Handled = true;
            }
        }
    }
}
