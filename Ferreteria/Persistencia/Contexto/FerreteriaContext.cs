using Ferreteria.Entidades;
using SQLite.CodeFirst;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.Persistencia.Contexto
{
    public class FerreteriaContext : DbContext
    {

        public DbSet<Producto> producto { get; set; }
        public DbSet<Categoria> categoria { get; set; }

        public DbSet<Login> login { get; set; }

        public FerreteriaContext(): base("name=BDFerreteria") {
            var ensureDLLIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;

        }

        /// <summary>
        /// Metodo que genera la Base de datos
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var instance = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
            var sqliteConnectionInitializer = new SqliteDropCreateDatabaseWhenModelChanges<FerreteriaContext>(modelBuilder);

           
            Database.SetInitializer(sqliteConnectionInitializer);



            //var sqliteConnectionInitializer1 = new SqliteDropCreateDatabaseAlways <FerreteriaContext>(modelBuilder);
            //Database.SetInitializer(sqliteConnectionInitializer);


            //Database.SetInitializer<FerreteriaContext>(null);
        }

    }
}
