﻿using System;
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
    public partial class formPrincipal : Form
    {
        internal string rol;
        internal string usuario;

        public formPrincipal()
        {
            InitializeComponent();
        }

        private void formPrincipal_Load(object sender, EventArgs e) =>
            //lblIngreso.Text = "USUARIO: " + usuario + " " + "(" + rol  +")";
            lblIngreso.Text = $"Usuario: {usuario} ({rol})";

        private void formPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnInscribir_Click(object sender, EventArgs e)
        {

        }
    }
}
