using Ferreteria.Entidades;
using Ferreteria.Persistencia.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.Persistencia
{
    public class LoginMapper
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        /// <summary>
        ///  Grabar Login
        /// </summary>
        /// <param name="Login"></param>
        public static bool grabar(Login _login)
        {
            try
            {

                using (var db = new FerreteriaContext())
                {

                    db.login.Add(_login);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Ocurrio una excepcion al grabar un login");
                return false;
            }

        }

        /// <summary>
        /// Modificar Login
        /// </summary>
        /// <param name="_login"></param>
        public static bool update(Login _login)
        {
            try
            {

                using (var db = new FerreteriaContext())
                {
                    var buscarlogin = db.login.Find(_login.id);

                    if (buscarlogin != null)
                    {
                        db.Entry(buscarlogin).CurrentValues.SetValues(_login);
                        db.SaveChanges();

                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Ocurrio una excepcion al actualizar un login");
                return false;
            }

        }


        //we can use the Find() method of DbSet to search the entity based on the primary key Value

        /// <summary>
        /// Traer Login por su Id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Login devolver(Int64 _id)
        {
            try
            {
                using (var db = new FerreteriaContext())
                {
                    return db.login.Find(_id);
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Ocurrio una excepcion al devolver un login");
                return null;

            }

        }

        /// <summary>
        /// Traer Login por su codigo.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Login validar(string _user, string _pass)
        {
            try
            {
                using (var db = new FerreteriaContext())
                {
                    return db.login.Where(x => x.usuario == _user && x.password ==_pass).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Ocurrio una excepcion al devolver un login");
                return null;

            }

        }


        /// <summary>
        /// Traer Todos los Logins
        /// </summary>
        /// <returns></returns>
        public static List<Login> devolverTodos()
        {
            try
            {
                using (var db = new FerreteriaContext())
                {
                    return db.login.ToList();
                    //ADO.NET  select nombre,descripcion from login where
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Ocurrio una excepcion al devolver todos los logins");
            }
            return null;
        }


        /// <summary>
        /// Eliminar Login por su ID.
        /// </summary>
        public static void eliminar(int _id)
        {
            try
            {
                using (var db = new FerreteriaContext())
                {
                    db.login.Remove(db.login.Find(_id));
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Ocurrio una excepcion al eliminar un login");
            }
        }



    }

}

