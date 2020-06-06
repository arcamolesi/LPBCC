using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIBLIOTECA.RELATORIOS
{
    public class Funcoes
    {
        public static string deretorioPasta()
        {
            string pasta = @"c:\RELBCC";
            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }
            return pasta;
        }
    }
}
