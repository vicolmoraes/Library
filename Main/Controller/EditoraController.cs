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
    class EditoraController
    {
        private LivrariaModelContainer dataBase = new LivrariaModelContainer();

        public void Requisicao(String operacao, Editora editora)
        {
            if (operacao.Equals("Cadastrar!"))
            {
                var erros = Validacao.Valida(editora);
                
                if(erros.Count() == 0) {
                    try 
	                {                 

                        dataBase.Editora.Add(editora);
                        dataBase.SaveChanges();
                        MessageBox.Show("Editora Cadastrada com Sucesso!!!");
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
                var erros = Validacao.Valida(editora);
                if (erros.Count() == 0)
                {
                    try
                    {
                        dataBase.Entry(editora).State = EntityState.Modified;
                        dataBase.SaveChanges();
                        MessageBox.Show("Editora Alterada com Sucesso!!!");

                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Não foi possível Alterar!\n" + e.Message);
                    }

                    ManutencaoEditora.ActiveForm.Close();

                }
                else
                {
                    foreach (var e in erros)
                        MessageBox.Show(e.ToString());
                }

            }
            else if (operacao.Equals("Excluir"))
            {
               if (MessageBox.Show("Deseja realmente excluir esta editora?","Atenção",MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        
                        editora = dataBase.Editora.Find(editora.IdEditora);
                        dataBase.Editora.Remove(editora);
                        dataBase.SaveChanges();
                        MessageBox.Show("Editora excluida com sucesso");
                    }catch(Exception e)
                    {
                        MessageBox.Show("Não foi possível excluir!!! Uma ou mais tabelas dependem destas informações" + e.Message);
                    }
                    ManutencaoEditora.ActiveForm.Close();
                }
            }
        }

    }
}
