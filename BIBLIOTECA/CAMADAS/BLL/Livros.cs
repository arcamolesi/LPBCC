using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIBLIOTECA.CAMADAS.BLL
{
    public class Livros
    {
        public List<MODEL.Livros> Select()
        {
            DAL.Livros dalLivro = new DAL.Livros();
            return dalLivro.Select();
        }

        public List<MODEL.Livros> SelectByID(int id)
        {
            DAL.Livros dalLivro = new DAL.Livros();
            return dalLivro.SelectByID(id);
        }

        public List<MODEL.Livros> SelectByTitulo(string titulo)
        {
            DAL.Livros dalLivro = new DAL.Livros();
            return dalLivro.SelectByTitulo(titulo);
        }



        public void Insert (MODEL.Livros livro)
        {
            DAL.Livros dalLivro = new DAL.Livros();
            dalLivro.Insert(livro); 
        }

        public void Update(MODEL.Livros livro)
        {
            DAL.Livros dalLivro = new DAL.Livros();
            dalLivro.Update(livro); 
        }

        public void Delete (int idLivro)
        {
            DAL.Livros dalLivro = new DAL.Livros();
            dalLivro.Delete(idLivro); 
        }

    }
}
