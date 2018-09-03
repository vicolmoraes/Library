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
    class LivroController
    {
        private LivrariaModelContainer dataBase = new LivrariaModelContainer();

        public void Requisicao(String operacao, Livro livro)
        {
            if (operacao.Equals("Cadastrar!"))
            {
                var erros = Validacao.Valida(livro);

                if (erros.Count() == 0)
                {
                    try
                    { 
                        dataBase.Livro.Add(livro);
                        
                        dataBase.SaveChanges();
                        MessageBox.Show("Livro Cadastrada com Sucesso!!!");
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
                var erros = Validacao.Valida(livro);
                if (erros.Count() == 0)
                {
                    try
                    {
                        dataBase.Entry(livro).State = EntityState.Modified;
                        dataBase.SaveChanges();
                        MessageBox.Show("Livro Alterado com Sucesso!!!");

                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Não foi possível Alterar!\n" + e.Message);
                    }

                    ManutencaoLivro.ActiveForm.Close();

                }
                else
                {
                    foreach (var e in erros)
                        MessageBox.Show(e.ToString());
                }

            }

            else if (operacao.Equals("Excluir"))
            {
                if (MessageBox.Show("Deseja realmente excluir este livro?", "Atenção", MessageBoxButtons.YesNo,
                     MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {

                        livro = dataBase.Livro.Find(livro.IdLivro);
                        dataBase.Livro.Remove(livro);
                        dataBase.SaveChanges();
                        MessageBox.Show("Livro excluido com sucesso");
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Não foi possível excluir!!! Uma ou mais tabelas dependem destas informações" + e.Message);
                    }
                    ManutencaoLivro.ActiveForm.Close();
                }
            }
        }


        public Livro ObterPrecoPorId(int id)
        {
            Livro livro = new Livro();

            SqlConnection conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=livrariaDB;Integrated Security=True");

            string sql = "SELECT Preco from Livro WHERE IdLivro=@id";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", id);

            conn.Open();

            SqlDataReader leitor = cmd.ExecuteReader();

            while (leitor.Read())
            {
                livro.Preco = Convert.ToDouble(leitor["Preco"].ToString());
            }
            conn.Close();
            return livro;
        }
        public Livro ObterEstoquePorId(int id)
        {
            Livro livro1 = new Livro();

            SqlConnection conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=livrariaDB;Integrated Security=True");

            string sql = "SELECT Estoque from Livro WHERE IdLivro=@id";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                conn.Open();

                SqlDataReader leitor = cmd.ExecuteReader();

                while (leitor.Read())
                {
                    livro1.Estoque = Convert.ToInt16(leitor["Estoque"].ToString());
                }
            }
            catch (SqlException ex)
            { MessageBox.Show("Error: " + ex.Message); }
            finally
            {
                conn.Close();
            }
                return livro1;
            
        }

        public void AlterarEstoque(int quantidade, int estoque, int item)
        {
            string strConnection = @"Data Source = localhost; Initial Catalog = livrariaDB; Integrated Security = True";
            int novoEstoque = estoque - quantidade;
            int meuId = item;
            string strSQL = " UPDATE Livro SET Estoque = @novoEstoque   WHERE IdLivro= @meuId";
            SqlConnection dConnection = new SqlConnection(strConnection);
            SqlCommand cmdAlterar = new SqlCommand(strSQL, dConnection);
            cmdAlterar.Parameters.AddWithValue("@meuId", meuId);
            cmdAlterar.Parameters.AddWithValue("@novoEstoque", novoEstoque);
            try
            {
                dConnection.Open();
                cmdAlterar.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                dConnection.Close();
            }
        }
    }
}
