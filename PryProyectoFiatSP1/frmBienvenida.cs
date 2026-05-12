using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryProyectoFiatSP1
{
    public partial class frmBienvenida : Form
    {
        public frmBienvenida()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void frmBienvenida_Load(object sender, EventArgs e)
        {
            this.Text = "Bienvenido - Sintepart SRL";

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Cierra toda la aplicación
            Application.Exit();
        }
    }
}
