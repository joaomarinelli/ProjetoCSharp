using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.DAL
{
    class Contexto : DbContext
    {
        public Contexto() : base("strConn")
        {

        }

        public DbSet<Material> Materiais { get; set; }

        public DbSet<Armazem> Armazens { get; set; }

        public DbSet<Funcionario> Funcionarios { get; set; }
    }
}
