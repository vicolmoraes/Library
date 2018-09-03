using Main.Model;
using Main.View;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main.Controller
{
    class ClienteController
    {
        private LivrariaModelContainer dataBase = new LivrariaModelContainer();

        public void Requisicao(String operacao, Cliente cliente)
        {
            if (operacao.Equals("Cadastrar!"))
            {
                var erros = Validacao.Valida(cliente);

                if (erros.Count() == 0)
                {
                    try
                    {

                        dataBase.Cliente.Add(cliente);
                        dataBase.SaveChanges();
                        MessageBox.Show("Cliente Cadastrado com Sucesso!!!");
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Não foi possível Cadastrar!\n" + e.Message);
                    }
                }
                else
                {
                    foreach (var e in erros)
                        MessageBox.Show(e.ToString());
                }
            }
            else if (operacao.Equals("Alterar"))
            {
                var erros = Validacao.Valida(cliente);
                if (erros.Count() == 0)
                {
                    try
                    {
                        dataBase.Entry(cliente).State = EntityState.Modified;
                        dataBase.SaveChanges();
                        MessageBox.Show("Cliente Alterada com Sucesso!!!");

                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Não foi possível Alterar!\n" + e.Message);
                    }

                    ManutencaoCliente.ActiveForm.Close();

                }
                else
                {
                    foreach (var e in erros)
                        MessageBox.Show(e.ToString());
                }

            }
            else if (operacao.Equals("Excluir"))
            {
                if (MessageBox.Show("Deseja realmente excluir este cliente?", "Atenção", MessageBoxButtons.YesNo,
                     MessageBoxIcon.Question) == DialogResult.Yes)
                { 
                        try
                        {

                            cliente = dataBase.Cliente.Find(cliente.IdCliente);
                            dataBase.Cliente.Remove(cliente);
                            dataBase.SaveChanges();
                            MessageBox.Show("Cliente excluida com sucesso");
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("Não foi possível excluir!!! Uma ou mais tabelas dependem destas informações" + e.Message);
                        }
                    
                    ManutencaoCliente.ActiveForm.Close();
                }
            }
            }
    }
}
