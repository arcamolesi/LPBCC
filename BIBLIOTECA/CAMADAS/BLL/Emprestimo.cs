using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIBLIOTECA.CAMADAS.BLL
{
    public class Emprestimo
    {
        public List<MODEL.Emprestimo> Select()
        {
            DAL.Emprestimo dalEmprestimo = new DAL.Emprestimo();
            return dalEmprestimo.Select();
        }

        public void Insert(MODEL.Emprestimo emprestimo)
        {
            DAL.Emprestimo dalEmprestimo = new DAL.Emprestimo();
            dalEmprestimo.Insert(emprestimo);
        }

        public void Update(MODEL.Emprestimo emprestimo)
        {
            DAL.Emprestimo dalEmprestimo = new DAL.Emprestimo();
            dalEmprestimo.Update(emprestimo);
        }

        public void Delete(int idEmprestimo)
        {
            DAL.Emprestimo dalEmprestimo = new DAL.Emprestimo();
            dalEmprestimo.Delete(idEmprestimo);
        }
    }
}
