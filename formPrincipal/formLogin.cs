using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace formPrincipal
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
                txtUsuario.Text = "";
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
                txtUsuario.Text = "Usuario";
        }

        private void txtClave_Enter(object sender, EventArgs e)
        {
            if (txtClave.Text == "Contraseña") 
            {
                txtClave.Text = "";
                txtClave.UseSystemPasswordChar = true;
            }
        }

        private void txtClave_Leave(object sender, EventArgs e)
        {
            if (txtClave.Text == "")
            {
                txtClave.Text = "Contraseña";
                txtClave.UseSystemPasswordChar = false;
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
            DataTable tablaLogin = usuarioNegocio.loginUsuario(txtUsuario.Text, txtClave.Text);

            if (tablaLogin.Rows.Count > 0)
            {
                MessageBox.Show("Ingreso exitoso");
                formPrincipal formPrincipal = new formPrincipal();
                formPrincipal.rol = Convert.ToString(tablaLogin.Rows[0][0]);
                formPrincipal.usuario = Convert.ToString(txtUsuario.Text);
                formPrincipal.Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("Usuario y/o clave incorrecta");
            }
        }

        private void formLogin_Load(object sender, EventArgs e)
        {

        }

        private void formLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
