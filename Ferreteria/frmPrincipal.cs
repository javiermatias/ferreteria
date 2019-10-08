using Ferreteria.Entidades;
using Ferreteria.Formularios;
using Ferreteria.Formularios.Productos;
using Ferreteria.Persistencia;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferreteria
{
    public partial class frmPrincipal : Form
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        public frmPrincipal()
        {
            InitializeComponent();
           
        }
 
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.adaptarPantalla();              
            //cargarDatosPrueba();
        }

        private void cargarDatosPrueba()
        {
            //var _producto = new Producto()
            //{

            //    codProducto = "2312232",
            //    descripcion = "jugo",
            //    categoria = "limpieza",
                



            //};

            //ProductoMapper.grabar(_producto);

            var _categoria = new Categoria()
            {
                descripcion = "PINTURAS"


            };

            CategoriaMapper.grabar(_categoria);
            // List<Producto> productos = ProductoMapper.devolverTodos();
        }

        #region ConfiguracionesFormulario

        /// <summary>
        /// Adapta la pantalla en diferentes tamaños de pantalla(Resolución).
        /// </summary>
        private void adaptarPantalla()
        {

            this.Width = Convert.ToInt32(Math.Floor(Screen.PrimaryScreen.WorkingArea.Width * 0.90));
            this.Height = Convert.ToInt32(Math.Floor(Screen.PrimaryScreen.WorkingArea.Height * 0.90));
            this.Left = ((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2);
            this.Top = ((Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
        
        }
        /// <summary>
        /// Abre distintos formularios en el panel contenedor.
        /// </summary>
        /// <typeparam name="MiForm"></typeparam>
        private void abrirFormulario<MiForm>() where MiForm:Form, new() {

            Form formulario;

            formulario = panelContenedor.Controls.OfType<MiForm>().FirstOrDefault();

            if (formulario == null)
            {

                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.Dock = DockStyle.Fill;
                panelContenedor.Controls.Add(formulario);
                panelContenedor.Tag = formulario;
                formulario.Show();

            }
            else {

                formulario.BringToFront();


            }
         



        }

        #endregion

        #region BotonesMenu

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            //this.abrirFormulario<FormularioPrueba>();

            nuevoProducto np;
            using (np = new nuevoProducto(1))
            {
               
                np.ShowDialog();
            }
        }

        #endregion

        private void btn_productos_Click(object sender, EventArgs e)
        {
            abrirFormulario<verProducto>();
        }

        private void btnprincipal_Click(object sender, EventArgs e)
        {
            //abrirFormulario<nuevoProducto>();
        }
    }
}
