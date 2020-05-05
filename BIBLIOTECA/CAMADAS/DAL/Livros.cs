using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIBLIOTECA.CAMADAS.DAL
{
    public class Livros
    {
        private string strCon = Conexao.getConexao();

        public List<MODEL.Livros> Select()
        {
            List<MODEL.Livros> lstLivros = new List<MODEL.Livros>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * FROM Livros";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Livros livro = new MODEL.Livros();
                    livro.id = Convert.ToInt32(dados["id"].ToString());
                    livro.titulo = dados["titulo"].ToString();
                    livro.editora = dados["editora"].ToString();
                    livro.autor = dados["autor"].ToString();
                    livro.valor = Convert.ToSingle(dados["valor"].ToString());
                    livro.situacao = Convert.ToInt32(dados["situacao"].ToString());
                    lstLivros.Add(livro);
                }  
            }
            catch {
                Console.WriteLine("Erro listar Banco sql-Livros");
            }
            finally
            {
                conexao.Close(); 
            }
            return lstLivros;          
        }

        public void Insert(MODEL.Livros livro)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "INSERT INTO Livros VALUES (@titulo, @editora, @autor, @valor, @situacao);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@titulo", livro.titulo);
            cmd.Parameters.AddWithValue("@editora", livro.editora);
            cmd.Parameters.AddWithValue("@autor", livro.autor);
            cmd.Parameters.AddWithValue("@valor", livro.valor);
            cmd.Parameters.AddWithValue("@situacao", livro.situacao);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery(); 
            }
            catch
            {
                Console.WriteLine("Erro sql inserir Livros...");
            }
            finally
            {
                conexao.Close(); 
            }
        }

        public void Update(MODEL.Livros livro)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "UPDATE LIVROS SET titulo=@titulo, editora=@editora, autor=@autor, valor=@valor, situacao=@situacao "; 
                   sql += "WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", livro.id); 
            cmd.Parameters.AddWithValue("@titulo", livro.titulo);
            cmd.Parameters.AddWithValue("@editora", livro.editora);
            cmd.Parameters.AddWithValue("@autor", livro.autor);
            cmd.Parameters.AddWithValue("@valor", livro.valor);
            cmd.Parameters.AddWithValue("@situacao", livro.situacao);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro sql atualizar Livros...");
            }
            finally
            {
                conexao.Close();
            }

        }

        public void Delete(int idLivro)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "DELETE FROM Livros WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", idLivro);  
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro sql Remover Livros...");
            }
            finally
            {
                conexao.Close();
            }
        }

    }
}
