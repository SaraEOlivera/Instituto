using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formPrincipal
{
    public partial class frmInscripcionPostulante : Form
    {
        public frmInscripcionPostulante()
        {
            InitializeComponent();
        }

        private void InscribirPostulante_Load(object sender, EventArgs e)
        {

        }

        private void btnVolverInscripcion_Click(object sender, EventArgs e)
        {
            formPrincipal principal = new formPrincipal();
            principal.Show();
            this.Hide();
        }

        private void btnIngresarInscripcion_Click(object sender, EventArgs e)
        {
            if
        }
    }
}
