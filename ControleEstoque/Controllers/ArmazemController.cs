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
    public class ArmazemController : IBaseController<Armazem>
    {
        private Contexto contexto = new Contexto();

        public void Adicionar(Armazem entity)
        {
            contexto.Armazens.Add(entity);
            contexto.SaveChanges(); ;
        }

        public void Atualizar(Armazem entity)
        {
            contexto.Entry(entity).State =
                System.Data.Entity.EntityState.Modified;

            contexto.SaveChanges();
        }

        public Armazem BuscarPorId(int id)
        {
            return contexto.Armazens.Find(id);
        }

        public void Excluir(int id)
        {
            Armazem a = BuscarPorId(id);

            if (a != null)
            {
                // forma 1
                contexto.Armazens.Remove(a);

                // forma 2
                //contexto.Entry(a).State = System.Data.Entity.EntityState.Deleted;

                //contexto.SaveChanges();
            }
        }

        public IList<Armazem> ListarPorNome(string localArmazem)
        {
            return contexto.Armazens
                .Where(a => a.Local.ToLower() == localArmazem.ToLower()).ToList();
        }

        public IList<Armazem> ListarTodos()
        {
            return contexto.Armazens.ToList();
        }
    }
}
