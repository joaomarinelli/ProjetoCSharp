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
    public class MaterialController : IBaseController<Material>
    {
        private Contexto contexto = new Contexto();

        public void Adicionar(Material entity)
        {
            contexto.Materiais.Add(entity);
            contexto.SaveChanges();
        }

        public void Atualizar(Material entity)
        {
            contexto.Entry(entity).State =
                System.Data.Entity.EntityState.Modified;

            contexto.SaveChanges();
        }

        public Material BuscarPorId(int id)
        {
            return contexto.Materiais.Find(id);
        }

        public void Excluir(int id)
        {
            Material m = BuscarPorId(id);

            if (m != null)
            {
                // forma 1
                contexto.Materiais.Remove(m);

                // forma 2
                //contexto.Entry(a).State = System.Data.Entity.EntityState.Deleted;

                //contexto.SaveChanges();
            }
        }

        public IList<Material> ListarPorNome(string nome)
        {
            return contexto.Materiais
                .Where(m => m.MaterialNome.ToLower() == nome.ToLower()).ToList();
        }

        public IList<Material> ListarTodos()
        {
            return contexto.Materiais.ToList();
        }
    }
}
