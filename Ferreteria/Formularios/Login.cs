
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Ferreteria.Formularios
{
    public partial class Login : Form
    {

        public bool noValido = true;
        int calcularIntentos = 0;
        public Login()
        {
            InitializeComponent();
            lblactivacion.Visible = false;
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (!validacionesForm())
            {
                return;
            }
            lblactivacion.Visible = true;
            lblactivacion.Text = "Activando licencia, aguarde";
            String usuario = txtusuario.Text.ToString();
            String clave = txtpass.Text.ToString();
            //if (ActivacionMapper.verificarLicenciaActivada(usuario, clave) == "NO")
            //{
                
            //    if (GestorActivacion.guardarDatosRegistro(usuario, clave))
            //    {
            //        lblactivacion.Text = "Licencia correcta";
            //        MessageBox.Show("Su licencia se activó correctamente.", "Activación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        noValido = false;
            //        Close();
            //    }else
            //    {
            //        calcularIntentos++;
            //        mensajeDeError();

            //    }

            //}
            //else
            //{
            //    if (calcularIntentos > 3)
            //    {
            //        cerrarNoValido();
            //    }
            //    mensajeDeError();
            //    calcularIntentos++;
                

            //}
        }


        public void mensajeDeError()
        {
            MessageBox.Show("Hubo un error al activar el sistema. Contáctese con los administradores", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            lblactivacion.Visible = false;


        }
        public void cerrarNoValido()
        {

            noValido = true;
            Close();
        }


        private bool validacionesForm()
        {

            String usuario = txtusuario.Text.ToString();
            String clave = txtpass.Text.ToString();

            //Primer Validacion
            if (usuario == "" || usuario == "Usuario")
            {
                MessageBox.Show("Igrese el usuario.", "Error al activar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (clave == "" || clave == "Password")
            {
                MessageBox.Show("Ingrese la contraseña.", "Error al activar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;

        }



        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txtusuario.ForeColor = Color.Black;
        }

        private void txtusuario_Click(object sender, EventArgs e)
        {
            txtusuario.Text = "";
        }

        private void txtpass_Click(object sender, EventArgs e)
        {
            txtpass.Text = "";
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {
            txtpass.ForeColor = Color.Black;
        }
    }
}
