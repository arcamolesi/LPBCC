using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIBLIOTECA.CAMADAS.DAL
{
    public class Emprestimo
    {
        private string strCon = Conexao.getConexao();

        public List<MODEL.Emprestimo> Select()
        {
            List<MODEL.Emprestimo> lstEmprestimo = new List<MODEL.Emprestimo>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * FROM Emprestimo";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Emprestimo emprestimo = new MODEL.Emprestimo();
                    emprestimo.id = Convert.ToInt32(dados["id"].ToString());
                    emprestimo.clienteId = Convert.ToInt32(dados["clienteID"].ToString());
                    emprestimo.data = Convert.ToDateTime(dados["data"].ToString());
                    lstEmprestimo.Add(emprestimo);
                }
            }
            catch
            {
                Console.WriteLine("Erro listar Emprestimo");
            }
            finally
            {
                conexao.Close();
            }
            return lstEmprestimo;
        }


       

        public void Insert(MODEL.Emprestimo emprestimo)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "INSERT INTO Emprestimo VALUES (@clienteID, @data);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@clienteID", emprestimo.clienteId);
            cmd.Parameters.AddWithValue("@data", emprestimo.data);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro sql inserir Emprestimo...");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(MODEL.Emprestimo emprestimo)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "UPDATE Emprestimo SET clienteID=@clienteID, data=@data ";
            sql += " WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", emprestimo.id);
            cmd.Parameters.AddWithValue("@clienteID", emprestimo.clienteId);
            cmd.Parameters.AddWithValue("@data", emprestimo.data);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro sql atualizar Emprestimo...");
            }
            finally
            {
                conexao.Close();
            }

        }

        public void Delete(int idEmpretimo)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "DELETE FROM Emprestimo WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", idEmpretimo);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro sql Remover Emprestimo...");
            }
            finally
            {
                conexao.Close();
            }
        }

    }
}
