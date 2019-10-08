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
        public verProducto()
        {
            InitializeComponent();
            estilosGrilla();
            cargarGridProductos();
        }

        #region grilla
        public void cargarGridProductos()
        {

            grilla_productos.DataSource = ProductoMapper.devolverTodos();

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
    }
}
