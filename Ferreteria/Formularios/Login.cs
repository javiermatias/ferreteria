
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


namespace Ferreteria.Formularios
{
    public partial class Login : Form
    {

        public bool Valido = false;
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
            lblactivacion.Text = "Verificando usuario";
            String usuario = txtusuario.Text.ToString();
            String clave = txtpass.Text.ToString();

            Entidades.Login login = LoginMapper.validar(usuario, clave);

            if (login != null) {
                this.Valido = true;
                Close();
            }
            else
            {
                mensajeDeError();
            }

       
        }


        public void mensajeDeError()
        {
            MessageBox.Show("El usuario u contraseña es incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            lblactivacion.Visible = false;


        }
        public void cerrarNoValido()
        {

            Valido = false;
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
