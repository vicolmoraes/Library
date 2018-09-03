using Main.Model;
using Main.View;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main.Controller
{
    class PedidoController
    {
        private LivrariaModelContainer dataBase = new LivrariaModelContainer();

        public void Requisicao(String operacao, Pedido pedido)
        {
            if (operacao.Equals("Cadastrar!")|| operacao.Equals("Finalizar!"))
            {
                var erros = Validacao.Valida(pedido);

                if (erros.Count() == 0)
                {
                    try
                    {
                        

                        dataBase.Pedido.Add(pedido);
                        dataBase.SaveChanges();
                        MessageBox.Show("Pedido Cadastrado com Sucesso!!!");
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
                var erros = Validacao.Valida(pedido);
                if (erros.Count() == 0)
                {
                    try
                    {
                        dataBase.Entry(pedido).State = EntityState.Modified;
                        dataBase.SaveChanges();
                        MessageBox.Show("Pedido Alterada com Sucesso!!!");

                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Não foi possível Alterar!\n" + e.Message);
                    }

                    ManutencaoPedido.ActiveForm.Close();

                }
                else
                {
                    foreach (var e in erros)
                        MessageBox.Show(e.ToString());
                }

            }
            else if (operacao.Equals("Excluir"))
            {
                if (MessageBox.Show("Deseja realmente excluir este pedido?", "Atenção", MessageBoxButtons.YesNo,
                     MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {

                        pedido = dataBase.Pedido.Find(pedido.IdPedido);
                        dataBase.Pedido.Remove(pedido);
                        dataBase.SaveChanges();
                        MessageBox.Show("Pedido excluida com sucesso");
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Não foi possível excluir!!! Uma ou mais tabelas dependem destas informações" + e.Message);
                    }
                    ManutencaoPedido.ActiveForm.Close();
                }
            }
        }
        public void AlterarValor(int idpedido, double valorTotal)
        {
            string strConnection = @"Data Source = localhost; Initial Catalog = livrariaDB; Integrated Security = True";
            double total = valorTotal;
            int meuId = idpedido;
            string strSQL = " UPDATE Pedido SET ValorPedido = @total   WHERE IdPedido= @meuId";
            SqlConnection dConnection = new SqlConnection(strConnection);
            SqlCommand cmdAlterar = new SqlCommand(strSQL, dConnection);
            cmdAlterar.Parameters.AddWithValue("@meuId", meuId);
            cmdAlterar.Parameters.AddWithValue("@total", total);
            try
            {
                dConnection.Open();
                cmdAlterar.ExecuteNonQuery();
                MessageBox.Show("Dados Alterados com sucesso.");
            }
            //Trata a exceção
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                //fecha a conexao 
                dConnection.Close();
            }
        }

    }
}
