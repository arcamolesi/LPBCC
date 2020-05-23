using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIBLIOTECA.CAMADAS.BLL
{
    public class Itens
    {
        public List<MODEL.Itens> Select()
        {
            DAL.Itens dalItens = new DAL.Itens();
            return dalItens.Select(); 
        }

        public void Insert (MODEL.Itens item)
        {
            DAL.Itens dalItens = new DAL.Itens();
            dalItens.Insert(item); 
        }

        public void Update(MODEL.Itens item)
        {
            DAL.Itens dalItens = new DAL.Itens();
            dalItens.Update(item);
        }

        public void Delete (int id)
        {
            DAL.Itens dalItens = new DAL.Itens();
            dalItens.Delete(id);
        }
    }
}
