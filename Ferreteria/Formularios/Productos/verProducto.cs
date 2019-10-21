using Ferreteria.Entidades;
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

namespace Ferreteria.Formularios.Productos
{
    public partial class verProducto : Form
    {
        List<Producto> productos;
        public verProducto()
        {
            InitializeComponent();
            productos = new List<Producto>();
            estilosGrilla();
            cargarGridProductos();
            
        }

        #region grilla
        public void cargarGridProductos()
        {
            productos = ProductoMapper.devolverTodos();
            grilla_productos.DataSource = productos;

            grilla_productos.AllowUserToAddRows = false;


            contarProductos();
        }

        private void contarProductos()
        {
            tssmostrar.Text = "Hay: " + grilla_productos.Rows.Count + " productos en esta lista.";
        }
        private void grilla_productos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            grilla_productos.ClearSelection();
        }

        private void estilosGrilla()
        {
            grilla_productos.BorderStyle = BorderStyle.None;
            grilla_productos.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            grilla_productos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grilla_productos.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            grilla_productos.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            grilla_productos.BackgroundColor = Color.White;

            grilla_productos.EnableHeadersVisualStyles = false;
            grilla_productos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            grilla_productos.ColumnHeadersDefaultCellStyle.BackColor = Color.DodgerBlue;
            grilla_productos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;


        }



        #endregion

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            nuevoProducto np;
            using (np = new nuevoProducto())
            {
                btn_nuevo.Enabled = false;
                np.ShowDialog();
            }
            btn_nuevo.Enabled = true;
            cargarGridProductos();
        }

    

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            Int64 id = 0;

            if (grilla_productos.Rows.Count <= 0)
            {
                MessageBox.Show("Debe seleccionar un producto de la lista para editar.", "Seleccione el producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            id = Int64.Parse(grilla_productos.CurrentRow.Cells[0].Value.ToString());

            if (id == 0)
            {
                MessageBox.Show("Debe seleccionar un producto de la lista para editar.", "Seleccione el producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            nuevoProducto np;

            using (np = new nuevoProducto(id))
            {
               
                np.ShowDialog();
            }

            cargarGridProductos();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            Int64 id = 0;

            if (grilla_productos.Rows.Count <= 0)
            {
                MessageBox.Show("Debe seleccionar un producto de la lista para eliminar.", "Seleccione el producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            if (grilla_productos.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Estás seguro que deseas eliminar el/los productos seleccionados?", "Confirme.", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in grilla_productos.SelectedRows)
                    {
                        id = Int64.Parse(row.Cells[0].Value.ToString());

                        ProductoMapper.eliminar(id);
                    }


                }
                MessageBox.Show("Los elementos se eliminaron correctamente", "Productos Eliminados", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {

                MessageBox.Show("Debe seleccionar un producto de la lista para eliminar.", "Seleccione el producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            cargarGridProductos();
        }

        private void cmb_ordenar_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmb_ordenar.Text)
            {
                case "Código Ascendente":
                                       
                    grilla_productos.DataSource = productos.OrderBy(x => x.codProducto).ToList();
                                        break;

                case "Código Descendente":
                    grilla_productos.DataSource = productos.OrderByDescending(x => x.codProducto).ToList();

                    break;

                case "Descripción Ascendente":


                    grilla_productos.DataSource = productos.OrderBy(x => x.descripcion).ToList();
                    break;                   

                case "Descripción Descendente":

                    grilla_productos.DataSource = productos.OrderByDescending(x => x.descripcion).ToList();
                   
                    break;

                case "Categoría Ascendente":
                    grilla_productos.DataSource = productos.OrderBy(x => x.categoria).ToList();
                
                    break;

                case "Categoría Descendente":
                    grilla_productos.DataSource = productos.OrderByDescending(x => x.categoria).ToList();
                  
                    break;

                case "Precio Ascendente":
                    grilla_productos.DataSource = productos.OrderBy(x => x.precioVenta).ToList();
                   
                    break;

                case "Precio Descendente":
                    grilla_productos.DataSource = productos.OrderByDescending(x => x.precioVenta).ToList();
                    
                    break;

                case "Stock Ascendente":
                    grilla_productos.DataSource = productos.OrderBy(x => x.stock).ToList();
                  
                    break;

                case "Stock Descendente":
                    grilla_productos.DataSource = productos.OrderByDescending(x => x.stock).ToList();
              
                    break;
            }
        }

        private void txb_filtro_KeyUp(object sender, KeyEventArgs e)
        {
            //if (txb_filtro.Text != "")
            //{
                List<Producto> copia = productos.ToList();
                // m.Name.Contains(key)
                grilla_productos.DataSource = copia.Where(x => x.nombre.Contains(txb_filtro.Text)).ToList();
                      contarProductos();
                if (grilla_productos.Rows.Count <= 0)
                {
                    txb_filtro.BackColor = Color.LightCoral;
                }
                else
                {
                    txb_filtro.BackColor = Color.White;
                }
            //}
        
        }

        private void txb_filtro_Click(object sender, EventArgs e)
        {
            txb_filtro.Text = "";
        }

        private void txb_filtro_Leave(object sender, EventArgs e)
        {
            txb_filtro.Text = "Buscar";
        }
    }
}
