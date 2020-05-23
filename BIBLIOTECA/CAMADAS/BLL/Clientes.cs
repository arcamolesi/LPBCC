using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIBLIOTECA.CAMADAS.BLL
{
    public class Clientes
    {
        public List<MODEL.Clientes> Select()
        {
            DAL.Clientes dalCli = new DAL.Clientes();
            return dalCli.Select(); 
        }

        public MODEL.Clientes SelectByID(int id)
        {
            DAL.Clientes dalCli = new DAL.Clientes();
            return dalCli.SelectByID(id);
        }


        public void Insert (MODEL.Clientes cliente)
        {
            DAL.Clientes dalCli = new DAL.Clientes();
            dalCli.Insert(cliente); 
        }

        public void Update (MODEL.Clientes cliente)
        {
            DAL.Clientes dalCli = new DAL.Clientes();
            dalCli.Update(cliente); 
        }
        public void Delete (int idCliente)
        {
            DAL.Clientes dalCli = new DAL.Clientes();
            dalCli.Delete(idCliente); 
        }
    }
}
