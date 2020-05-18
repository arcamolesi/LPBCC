using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIBLIOTECA.CAMADAS.MODEL
{
    public class Emprestimo
    {
        public int id { get; set; }
        public int clienteId { get; set; }
        public DateTime data { get; set; }
    }
}
