using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIBLIOTECA.CAMADAS.DAL
{
    public class Itens
    {
        private string strCon = Conexao.getConexao();

        public List<MODEL.Itens> Select()
        {
            List<MODEL.Itens> lstItens = new List<MODEL.Itens>();
            SqlConnection conexao = new SqlConnection(strCon); 
            string sql = "SELECT * FROM Itens;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Itens item = new MODEL.Itens();
                    item.id = Convert.ToInt32(dados["id"].ToString());
                    item.emprestimoID = Convert.ToInt32(dados["emprestimoID"].ToString());
                    item.livroID = Convert.ToInt32(dados["livroID"].ToString());
                    item.entrega = Convert.ToDateTime(dados["entrega"].ToString());

                    //recuperar livro
                    CAMADAS.BLL.Livros bllLiv = new BLL.Livros();
                    CAMADAS.MODEL.Livros livro = bllLiv.SelectByID(item.livroID)[0];
                    item.livro = livro.titulo; 

                    lstItens.Add(item);
                }
            }
            catch
            {
                Console.WriteLine("Erro listar Itens de emprestimo");
            }
            finally
            {
                conexao.Close();
            }
            return lstItens;
        }




        public void Insert(MODEL.Itens item)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "INSERT INTO Itens VALUES (@empretismo, @livro, @entrega);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@emprestimo", item.emprestimoID);
            cmd.Parameters.AddWithValue("@livro", item.livroID);
            cmd.Parameters.AddWithValue("@entrega", item.entrega) ;
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro sql inserir Item de emprestimo...");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(MODEL.Itens item)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "UPDATE Itens SET  emprestimoID=@emprestimo, livroID=@livro, entrega=@entrega ";
            sql += " WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", item.id);
            cmd.Parameters.AddWithValue("@emprestimo", item.emprestimoID);
            cmd.Parameters.AddWithValue("@livro", item.livroID);
            cmd.Parameters.AddWithValue("@entrega", item.entrega);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro sql atualizar itens emprestimo...");
            }
            finally
            {
                conexao.Close();
            }

        }

        public void Delete(int idItem)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "DELETE FROM Itens WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", idItem);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro sql Remover Item de Emprestimo...");
            }
            finally
            {
                conexao.Close();
            }
        }

    }
}
