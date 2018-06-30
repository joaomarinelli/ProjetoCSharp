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
        }

        public void Atualizar(Retirada entity)
        {
            throw new NotImplementedException();
        }

        public Retirada BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Retirada> ListarPorNome(string nome)
        {
            throw new NotImplementedException();
        }

        public IList<Retirada> ListarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
