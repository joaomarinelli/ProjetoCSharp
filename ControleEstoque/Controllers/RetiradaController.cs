using Controllers.Base;
using Controllers.DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    class RetiradaController : IBaseController<Retirada>
    {
        private Contexto contexto = new Contexto();
        public void Adicionar(Retirada entity)
        {
            contexto.Retiradas.Add(entity);
            contexto.SaveChanges();
        }

        public void Atualizar(Retirada entity)
        {
            contexto.Entry(entity).State =
                System.Data.Entity.EntityState.Modified;

            contexto.SaveChanges();
        }

        public Retirada BuscarPorId(int id)
        {
           return contexto.Retiradas.Find(id);
        }

        public void Excluir(int id)
        {
            Retirada r = BuscarPorId(id);

            if (r != null)
            {
              
                contexto.Retiradas.Remove(r);
                contexto.SaveChanges();
            }
        }

        public IList<Retirada> ListarPorNome(string nome)
        {
            throw new NotImplementedException();
        }

        public IList<Retirada> ListarTodos()
        {
            return contexto.Retiradas.ToList();
        }
    }
}
