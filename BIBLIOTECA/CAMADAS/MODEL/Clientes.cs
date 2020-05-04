using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BIBLIOTECA.CAMADAS.MODEL
{
    public class Clientes
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string curso { get; set; }
        public int dias { get; set; }
        public float multa { get; set; }

    }
}
