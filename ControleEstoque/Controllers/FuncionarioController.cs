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
    public class FuncionarioController : IBaseController<Funcionario>
    {

        private Contexto contexto = new Contexto();

        public void Adicionar(Funcionario entity)
        {
            contexto.Funcionarios.Add(entity);
            contexto.SaveChanges();
        }

        public void Atualizar(Funcionario entity)
        {
            contexto.Entry(entity).State =
                System.Data.Entity.EntityState.Modified;

            contexto.SaveChanges();
        }

        public Funcionario BuscarPorId(int id)
        {
            return contexto.Funcionarios.Find(id);
        }

        public void Excluir(int id)
        {
            Funcionario f = BuscarPorId(id);

            if (f != null)
            {
                // forma 1
                contexto.Funcionarios.Remove(f);

                // forma 2
                //contexto.Entry(a).State = System.Data.Entity.EntityState.Deleted;

                //contexto.SaveChanges();
            }
        }

        public IList<Funcionario> ListarPorNome(string nomeFuncionario)
        {
            return contexto.Funcionarios
                .Where(f => f.NomeFuncionario.ToLower() == nomeFuncionario.ToLower()).ToList();
        }

        public IList<Funcionario> ListarTodos()
        {
            return contexto.Funcionarios.ToList();
        }
    }
}
