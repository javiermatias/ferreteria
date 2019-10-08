using Ferreteria.Entidades;
using Ferreteria.Persistencia.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.Persistencia
{
    public class CategoriaMapper
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        /// <summary>
        ///  Grabar Categoria
        /// </summary>
        /// <param name="categoria"></param>
        public static bool grabar(Categoria _categoria)
        {
            try
            {

                using (var db = new FerreteriaContext())
                {

                    db.categoria.Add(_categoria);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Ocurrio una excepcion al grabar la categoria");
                return false;
            }

        }

        /// <summary>
        /// Modificar Categoria
        /// </summary>
        /// <param name="_categoria"></param>
        public static void update(Categoria _categoria)
        {
            try
            {

                using (var db = new FerreteriaContext())
                {
                    var buscarproducto = db.categoria.Find(_categoria.id);

                    if (buscarproducto != null)
                    {
                        db.Entry(buscarproducto).CurrentValues.SetValues(_categoria);
                        db.SaveChanges();
                    }

                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Ocurrio una excepcion al actualizar la categoria");
            }

        }


        //we can use the Find() method of DbSet to search the entity based on the primary key Value

        /// <summary>
        /// Traer Categoria por su Id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Categoria devolver(int _id)
        {
            try
            {
                using (var db = new FerreteriaContext())
                {
                    return db.categoria.Find(_id);
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Ocurrio una excepcion al devolver la categoria");
                return null;

            }

        }


        /// <summary>
        /// Traer Todos los Productos
        /// </summary>
        /// <returns></returns>
        public static List<Categoria> devolverTodos()
        {
            try
            {
                using (var db = new FerreteriaContext())
                {
                    return db.categoria.ToList();
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Ocurrio una excepcion al devolver todas las categorias");
                return null;
            }
            
        }


        /// <summary>
        /// Eliminar Categoria por su ID.
        /// </summary>
        public static void eliminar(int _id)
        {
            try
            {
                using (var db = new FerreteriaContext())
                {
                    db.categoria.Remove(db.categoria.Find(_id));
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Ocurrio una excepcion al eliminar una categoria");
            }
        }
    }
}
