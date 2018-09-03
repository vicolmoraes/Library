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
    class ItemController
    {
        private LivrariaModelContainer dataBase = new LivrariaModelContainer();

        public void Requisicao(String operacao, Item item)
        {
            if (operacao.Equals("Incluir!"))
            {
                var erros = Validacao.Valida(item);

                if (erros.Count() == 0)
                {
                    try
                    {

                        dataBase.Item.Add(item);
                        dataBase.SaveChanges();
                        MessageBox.Show("Item Cadastrado com Sucesso!!!");
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Não foi possível Cadastrar!\n É necessário cadastrar o cliente antes\n" + e.Message);
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
                var erros = Validacao.Valida(item);
                if (erros.Count() == 0)
                {
                    try
                    {
                        dataBase.Entry(item).State = EntityState.Modified;
                        dataBase.SaveChanges();
                        MessageBox.Show("Item Alterada com Sucesso!!!");

                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Não foi possível Alterar! Não é possível alterar a quantidade do item,\n pois está diretamente ligado ao valor total do PEDIDO\n" + e.Message);
                    }

                    ManutencaoItem.ActiveForm.Close();

                }
                else
                {
                    foreach (var e in erros)
                        MessageBox.Show(e.ToString());
                }

            }
            else if (operacao.Equals("Excluir"))
            {
                if (MessageBox.Show("Deseja realmente excluir este item?", "Atenção", MessageBoxButtons.YesNo,
                     MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {

                        item = dataBase.Item.Find(item.IdPedido);
                        dataBase.Item.Remove(item);
                        dataBase.SaveChanges();
                        MessageBox.Show("Item excluido com sucesso");
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Não foi possível excluir!!! Uma ou mais tabelas dependem destas informações" + e.Message);
                    }
                    ManutencaoItem.ActiveForm.Close();
                }
            }
        }
    }
}
