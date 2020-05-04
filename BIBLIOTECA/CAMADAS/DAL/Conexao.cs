using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIBLIOTECA.CAMADAS.DAL
{
    public class Conexao
    {
        public static string getConexao()
        { 
            
            return @"Data Source=.\SQLEXPRESS;Initial Catalog=BIBLIOTECA2020;Integrated Security=True"; 
        }
    }
}
