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

        public List<MODEL.Itens> SelectByEmp(int idEmp)
        {
            DAL.Itens dalItens = new DAL.Itens();
            return dalItens.SelectByEmp(idEmp);
        }

        public void Insert (MODEL.Itens item)
        {
            DAL.Itens dalItens = new DAL.Itens();

            CAMADAS.BLL.Livros bllLivro = new Livros();

            List<CAMADAS.MODEL.Livros> lstLivro = bllLivro.SelectByID(item.livroID);
            CAMADAS.MODEL.Livros livro = lstLivro[0];
            if (livro.situacao == 1)
                livro.situacao = 2;
            bllLivro.Update(livro); 
            dalItens.Insert(item); 
        }

        public void Devolver(MODEL.Itens item)
        {
            DAL.Itens dalItens = new DAL.Itens();

            CAMADAS.BLL.Livros bllLivro = new Livros();

            List<CAMADAS.MODEL.Livros> lstLivro = bllLivro.SelectByID(item.livroID);
            CAMADAS.MODEL.Livros livro = lstLivro[0];

            if (livro.situacao == 2)
                livro.situacao = 1;
            bllLivro.Update(livro);

            item.entrega = DateTime.Now;
            Update(item); 
         
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
