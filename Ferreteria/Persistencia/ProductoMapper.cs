using Ferreteria.Entidades;
using Ferreteria.Persistencia.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.Persistencia
{
    public static class ProductoMapper
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        /// <summary>
        ///  Grabar Producto
        /// </summary>
        /// <param name="producto"></param>
        public static bool grabar(Producto _producto)
        {
            try
            {

                using (var db = new FerreteriaContext())
                {

                    db.producto.Add(_producto);
                    db.SaveChanges();                  
                    return true;
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Ocurrio una excepcion al grabar un producto");
                return false;
            }

        }

        /// <summary>
        /// Modificar Producto
        /// </summary>
        /// <param name="_producto"></param>
        public static bool update(Producto _producto)
        {
            try
            {

                using (var db = new FerreteriaContext())
                {
                    var buscarproducto = db.producto.Find(_producto.id);

                    if (buscarproducto != null)
                    {
                        db.Entry(buscarproducto).CurrentValues.SetValues(_producto);
                        db.SaveChanges();
                        
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Ocurrio una excepcion al actualizar un producto");
                return false;
            }

        }


        //we can use the Find() method of DbSet to search the entity based on the primary key Value

        /// <summary>
        /// Traer Producto por su Id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Producto devolver(Int64 _id)
        {
            try
            {
                using (var db = new FerreteriaContext())
                {
                    return db.producto.Find(_id);
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Ocurrio una excepcion al devolver un producto");
                return null;

            }

        }

        /// <summary>
        /// Traer Producto por su codigo.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Producto devolverXcodigo(string _codigo)
        {
            try
            {
                using (var db = new FerreteriaContext())
                {
                    return db.producto.Where(x => x.codProducto.Equals(_codigo)).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Ocurrio una excepcion al devolver un producto");
                return null;

            }

        }


        /// <summary>
        /// Traer Todos los Productos
        /// </summary>
        /// <returns></returns>
        public static List<Producto> devolverTodos()
        {
            try
            {
                using (var db = new FerreteriaContext())
                {
                    return db.producto.ToList();
                    //ADO.NET  select nombre,descripcion from producto where
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Ocurrio una excepcion al devolver todos los productos");
            }
            return null;
        }


        /// <summary>
        /// Traer Todos los Productos Ordenados Ascendente
        /// </summary>
        /// <returns></returns>
        //public static List<Producto> devolverTodosOrdenadosAscendente(string filtro)
        //{
        //    try
        //    {
        //        using (var db = new FerreteriaContext())
        //        {
        //            return db.producto.OrderBy(x => x.codProducto.Equals(_codigo))ToList();
        //            //ADO.NET  select nombre,descripcion from producto where
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Logger.Error(ex, "Ocurrio una excepcion al devolver todos los productos");
        //    }
        //    return null;
        //}

        ///// <summary>
        ///// Traer Todos los Productos Ordenados Descendete
        ///// </summary>
        ///// <returns></returns>
        //public static List<Producto> devolverTodosOrdenadosDescendente(string filtro)
        //{
        //    try
        //    {
        //        using (var db = new FerreteriaContext())
        //        {
        //            return db.producto.ToList();
        //            //ADO.NET  select nombre,descripcion from producto where
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Logger.Error(ex, "Ocurrio una excepcion al devolver todos los productos");
        //    }
        //    return null;
        //}

        /// <summary>
        /// Eliminar Producto por su ID.
        /// </summary>
        public static void eliminar(Int64 _id)
        {
            try
            {
                using (var db = new FerreteriaContext())
                {
                    db.producto.Remove(db.producto.Find(_id));
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Ocurrio una excepcion al eliminar un producto");
            }
        }



    }
}
