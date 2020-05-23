using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIBLIOTECA.CAMADAS.DAL
{
    public class Clientes
    {
        private string strCon = Conexao.getConexao();

        public List<MODEL.Clientes> Select()
        {
            List<MODEL.Clientes> lstClientes = new List<MODEL.Clientes>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Clientes";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Clientes cliente = new MODEL.Clientes();
                    cliente.id = Convert.ToInt32(dados[0].ToString()); //dados["id"]
                    cliente.nome = dados["nome"].ToString();
                    cliente.curso = dados["curso"].ToString();
                    cliente.dias = Convert.ToInt32(dados["dias"].ToString());
                    cliente.multa = Convert.ToSingle(dados["multa"].ToString());
                    lstClientes.Add(cliente);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na execução do comando select de clientes");
            }
            finally
            {
                conexao.Close();
            }
            return lstClientes;
        }


        public MODEL.Clientes SelectByID(int id)
        {
            MODEL.Clientes cliente = new MODEL.Clientes();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * FROM Clientes WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id); 
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader();
                if (dados.Read())
                {
                    cliente.id = Convert.ToInt32(dados[0].ToString());
                    cliente.nome = dados["nome"].ToString();
                    cliente.curso = dados["curso"].ToString();
                    cliente.dias = Convert.ToInt32(dados["dias"].ToString());
                    cliente.multa = Convert.ToSingle(dados["multa"].ToString());
                }

            }
            catch
            {
                Console.WriteLine("Deu erro na execução do comando select de clientes por id");
            }
            finally
            {
                conexao.Close();
            }
            return cliente;
        }

        public void Insert(MODEL.Clientes cliente)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Clientes values (@nome, @curso, @dia, @multa);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", cliente.nome);
            cmd.Parameters.AddWithValue("@curso", cliente.curso);
            cmd.Parameters.AddWithValue("@dia", cliente.dias);
            cmd.Parameters.AddWithValue("@multa", cliente.multa);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro inserção de clientes...");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(MODEL.Clientes cliente)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "UPDATE Clientes SET nome=@nome, curso=@curso, dias=@dia, multa=@multa ";
            sql += " WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", cliente.id);
            cmd.Parameters.AddWithValue("@nome", cliente.nome);
            cmd.Parameters.AddWithValue("@curso", cliente.curso);
            cmd.Parameters.AddWithValue("@dia", cliente.dias);
            cmd.Parameters.AddWithValue("@multa", cliente.multa);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro atualização-update de clientes...");
            }
            finally
            {
                conexao.Close();
            }
        }


        public void Delete(int idCliente)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "DELETE FROM Clientes  WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", idCliente);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro remoção  de clientes...");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
