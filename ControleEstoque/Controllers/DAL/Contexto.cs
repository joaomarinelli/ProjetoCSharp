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
   public class Contexto : DbContext
    {
        public Contexto() : base("strConn")
        {
            //Padrao(cria se nao tiver base)
            Database.SetInitializer(new CreateDatabaseIfNotExists<Contexto>());
            //apaga a base de dados e cria novamente
            //Database.SetInitializer(new DropCreateDatabaseAlways<Contexto>());

            //apga e recria a base se houver mudanças
           // Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Contexto>());
        }

        public DbSet<Material> Materiais { get; set; }

        public DbSet<Armazem> Armazens { get; set; }

        public DbSet<Funcionario> Funcionarios { get; set; }

        public DbSet<Retirada> Retiradas { get; set; }
    }
}
