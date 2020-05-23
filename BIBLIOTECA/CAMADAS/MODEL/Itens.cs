using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIBLIOTECA.CAMADAS.MODEL
{
    public class Itens
    {
        public int id { get; set; }
        public int emprestimoID { get; set; }
        public int livroID { get; set; }
        public string livro { get; set; }
        public DateTime entrega { get; set; }
    }
}
