
using Ferreteria.Entidades;
using Ferreteria.Persistencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferreteria.Formularios.Productos
{
    public partial class nuevoProducto : Form
    {


        string rutaDestino = "Imagenes/";
        string rutaImagen = "";
        bool banderaActualizar = false;
        Int64 idActualizar = 0;
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        /// <summary>
        /// Constructor cuando se invoca la acción de Nuevo.
        /// </summary>
        public nuevoProducto()
        {
            InitializeComponent();
            leerCategorias(); //carga categorias en el combo
            chk_activo.Checked = true;
            chk_activo.Text = "Activo";
            lbl_mensaje.Visible = false;
            pcb_Imagen.Load("Imagenes/default.png");
        }

        /// <summary>
        /// Constructor que ejecuta la acción de Modificar
        /// </summary>
        /// <param name="id"></param>
        public nuevoProducto(Int64 id)
        {
            InitializeComponent();
            leerCategorias();
            banderaActualizar = true;
            lbl_mensaje.Visible = false;
            Producto producto = ProductoMapper.devolver(id);
            armarProducto(producto);
            this.idActualizar = id;
        }



        #region InteraccionUsuario

        private void chk_activo_CheckedChanged(object sender, EventArgs e)
        {
            chk_activo.Text = (chk_activo.Checked) ? "Activo" : "No activo";
        }
        private void txb_Stock_Click(object sender, EventArgs e)
        {
            txb_Stock.Text = "";
        }

        private void txt_precio_sin_iva_Click(object sender, EventArgs e)
        {
            txt_precio_sin_iva.Text = "";
        }

        private void txt_precio_con_iva_Click(object sender, EventArgs e)
        {
            txt_precio_con_iva.Text = "";
        }

        private void txb_precioVenta_Click(object sender, EventArgs e)
        {
            txb_precioVenta.Text = "";
        }
        private void nuevoProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
        #endregion

        #region Validaciones

        private bool validarFormulario()
        {

            if (txt_codigo.Text == "")
            {
                MessageBox.Show("El campo Código no debe estar vacio.", "Error");
                return false;
            }

            if (cmb_categoria.SelectedIndex <= -1)
            {
                MessageBox.Show("Debe seleccionar la categoria.", "Error");
                return false;
            }

            if (txt_nombre.Text == "")
            {
                MessageBox.Show("El campo Nombre no debe estar vacio", "Error");
                return false;
            }

            if (txb_descripcion.Text == "")
            {
                MessageBox.Show("El campo Descripción no debe estar vacio.", "Error");
                return false;
            }

            if (txt_precio_sin_iva.Text == "")
            {
                MessageBox.Show("El campo Precio sin iva no debe estar vacio.", "Error");
                return false;
            }
            if (txt_precio_con_iva.Text == "")
            {
                MessageBox.Show("El campo Precio con Iva no debe estar vacio.", "Error");
                return false;
            }

            if (txb_precioVenta.Text == "")
            {
                MessageBox.Show("El campo Precio Venta no debe estar vacio.", "Error");
                return false;
            }


            if (txb_Stock.Text == "")
            {
                MessageBox.Show("El campo Stock no debe estar vacio.", "Error");
                return false;
            }

            return true;
        }


        private void txb_Stock_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números 
            if (Char.IsDigit(e.KeyChar))
            {

                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan 
                e.Handled = true;
                MessageBox.Show("Debe poner sólo números!!", "No se permiten letras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txb_precioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = "0123456789.," + (char)8;
            Char.IsControl(e.KeyChar);
            if (cadena.Contains(e.KeyChar))
            {


            }
            else
            {
                e.Handled = true;
                MessageBox.Show("No se permiten poner letras, permitidos solo números y valores decimales con . y ,", "Precio Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txt_precio_sin_iva_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = "0123456789.," + (char)8;
            Char.IsControl(e.KeyChar);
            if (cadena.Contains(e.KeyChar))
            {


            }
            else
            {
                e.Handled = true;
                MessageBox.Show("No se permiten poner letras, permitidos solo números y valores decimales con . y ,", "Precio Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txt_precio_con_iva_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = "0123456789.," + (char)8;
            Char.IsControl(e.KeyChar);
            if (cadena.Contains(e.KeyChar))
            {


            }
            else
            {
                e.Handled = true;
                MessageBox.Show("No se permiten poner letras, permitidos solo números y valores decimales con . y ,", "Precio Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region InteraccionBD
        private void leerCategorias()
        {
            this.cmb_categoria.DataSource = CategoriaMapper.devolverTodos();
            this.cmb_categoria.DisplayMember = "descripcion";
            this.cmb_categoria.ValueMember = "id";
            // Solo lectura
            this.cmb_categoria.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        #endregion


        #region Imagen


        private void btn_cargarImagen_Click(object sender, EventArgs e)
        {
            try
            {

                string rutaArchivo = "";
                //creamos un objeto OpenDialog que es un cuadro de dialogo para buscar archivos
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Imagenes|*.jpg;*.jpeg;*.gif;*.png";
                open.Title = "Seleccione la imagen"; //le damos un titulo a la ventana
                open.FileName = string.Empty; //inicializamos con vacio el nombre del archivo

                if (open.ShowDialog() != DialogResult.OK)
                { //si al seleccionar el archivo damos Ok
                    rutaImagen = open.FileName;
                    rutaArchivo = open.SafeFileName;
                    rutaDestino = rutaDestino + rutaArchivo;
                    pcb_Imagen.Load(open.FileName);
                    pcb_Imagen.SizeMode = PictureBoxSizeMode.StretchImage;
                    btn_guardar.Focus();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Seleccione la imagen correspondiente", "Elija una imagen.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private string cargarImagen()
        {
            try
            {
                if (pcb_Imagen.ImageLocation == "Imagenes/default.png" || pcb_Imagen.ImageLocation == null)
                {
                    return "Imagenes/default.png";
                }
                else
                {
                    System.IO.File.Delete(rutaDestino); //si existe imagen la elimino
                    System.IO.File.Copy(rutaImagen, rutaDestino); //guardo copia de imagen
                    return rutaDestino;
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Ocurrió un error al procesar la imagen" + ex);
                return "Imagenes/default.png";
            }
        }

        private void btn_borrarImagen_Click(object sender, EventArgs e)
        {
            pcb_Imagen.Load("Imagenes/default.png");
            pcb_Imagen.SizeMode = PictureBoxSizeMode.StretchImage;
        }


        private void cargarImagenActualizar(string imagen) {

            if (imagen == "" || imagen == null)
            {
                pcb_Imagen.Load("Imagenes/default.png");
                pcb_Imagen.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                try
                {
                    pcb_Imagen.Load(imagen);
                    pcb_Imagen.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch (Exception ex)
                {
                    pcb_Imagen.Load("Imagenes/default.png");
                    pcb_Imagen.SizeMode = PictureBoxSizeMode.StretchImage;
                    Logger.Error(ex, "Ocurrió una excepción al cargar la imagen.");
                }

            }


        }

        #endregion


        private void btn_guardar_Click(object sender, EventArgs e)
          {
            if (!validarFormulario())
            {
                return;
            }
            if (banderaActualizar)
            {
                actualizarProducto();
                return;
            }

            if (guardarProducto())
            {
                limpiarControles();
                txt_codigo.Focus();
                
            }
            
        

                



           }

        #region guardarProducto
        private bool guardarProducto()
        {
            Producto pro = ProductoMapper.devolverXcodigo(txt_codigo.Text.ToString());
            if (pro != null)
            {
                MessageBox.Show("El Código ya esta siendo usado por otro artículo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cargarProducto())
            {
                lbl_mensaje.Visible = true;
                lbl_mensaje.TextAlign = ContentAlignment.MiddleCenter;
                lbl_mensaje.Text = "Producto guardado con éxito.";
                return true;

            }
            else
            {

                MessageBox.Show("Hubo un error al guardar el producto.", "Problema al guardar el producto");
                return false;
            }
            
        }

        private bool cargarProducto()
        {


            Producto producto = capturarPantalla();


            if (ProductoMapper.grabar(producto))
            {
                return true;
            }
            else
            {

                return false;
            }
            

        }

        private void limpiarControles()
        {
            txt_codigo.Enabled = true;
            txt_codigo.Text = "";
            txt_nombre.Text = "";
            txb_descripcion.Text = "";
            cmb_categoria.SelectedItem = 1;
            txt_precio_sin_iva.Text = "0,00";
            txt_precio_con_iva.Text = "0,00";
            txb_precioVenta.Text = "0,00";
            txb_Stock.Text = "0";
            chk_activo.Checked = true;
            pcb_Imagen.Load("Imagenes/default.png");



        }

        private Producto capturarPantalla()
        {


            Producto p = new Producto();
            p.codProducto = txt_codigo.Text;
            p.nombre = txt_nombre.Text.ToString();
            p.descripcion = txb_descripcion.Text.ToString();
            p.categoria = cmb_categoria.Text.ToString();
            p.precioSinIva = Utilidades.convertirSeparadorDecimal(txt_precio_sin_iva.Text.ToString());
            p.precioConIva = Utilidades.convertirSeparadorDecimal(txt_precio_con_iva.Text.ToString());
            p.precioVenta = Utilidades.convertirSeparadorDecimal(txb_precioVenta.Text.ToString());
            p.stock = int.Parse(txb_Stock.Text);
            p.estado = (chk_activo.Checked) ? true : false;
            p.imagen = cargarImagen();

            return p;
        }
        #endregion

        #region actualizarProducto
        private void actualizarProducto()
        {
       
            if (actualizar())
            {

                MessageBox.Show("El artículo fue actualizado con Éxito", "Actulizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("No se pudo realizar los cambios.", "Error");
                return;

            }

            Close();
        }

        private bool actualizar()
           {

               Producto producto = capturarPantalla();
             producto.id = this.idActualizar;
               if (ProductoMapper.update(producto)) return true; else return false;
                
            }

        public void armarProducto(Producto producto)
        {

         
            txt_codigo.Text = producto.codProducto.ToString();
            txt_nombre.Text = producto.nombre.ToString();
            txb_descripcion.Text = producto.descripcion.ToString();               
            txt_precio_sin_iva.Text = producto.precioSinIva.ToString();
            txt_precio_con_iva.Text = producto.precioConIva.ToString();
            txb_precioVenta.Text = producto.precioVenta.ToString();         
            txb_Stock.Text = producto.stock.ToString();
            chk_activo.Checked = producto.estado;
            cargarImagenActualizar(producto.imagen);



            //Para seleccionar el combo
            foreach (Categoria x in cmb_categoria.Items)
            {
                if (x.descripcion == producto.categoria)
                {
                 
                    cmb_categoria.SelectedValue = x.id;
                    break;
                }
            }



           

        }



        #endregion


        private void btninsertarcategoria_Click(object sender, EventArgs e)
           {
            //abrirCategorias();
        }





        private void btn_cancelarClick(object sender, EventArgs e)
        {
            Close();
        }

     







     
    }


}
