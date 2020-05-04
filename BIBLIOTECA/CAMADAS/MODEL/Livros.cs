using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIBLIOTECA.CAMADAS.MODEL
{
    public class Livros
    {
        public int id { get; set; }
        public string titulo { get; set; }
        public string editora { get; set; }
        public string autor { get; set; }
        public float  valor { get; set; }
        public int situacao { get; set; }
    }
}
