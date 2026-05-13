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
    public partial class frmLogin : Form
    {
        
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            int intentos = 0;
            

            if (txtUsuario.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el usuario.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            // Verifica que la contraseña esté completo
            else if (txtContra.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese la contraseña.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            // Verifica que el módulo esté completo
            else if (cmbMódulo.Text == "")
            {
                MessageBox.Show("Seleccione un módulo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //guarda lo q escribio el usuario y el thim: saca los espacios
                string usuario = txtUsuario.Text.Trim();
                string contraseña = txtContra.Text.Trim();
                string modulo = cmbMódulo.Text;


                //ve q sea los datos
                if (usuario == "Adm" && contraseña == "@1a" && (modulo.StartsWith("ADM") || modulo.StartsWith("COM") || modulo.StartsWith("VTA")))
                {
                    intentos = 0;      //resetea el contador de errores
                    this.Hide();      //oculta el formulario d login
                    frmBienvenida bienvenida = new frmBienvenida();
                    bienvenida.Show();
                }
                else if (usuario == "John" && contraseña == "@2b" && modulo.StartsWith("SIST"))
                {
                    intentos = 0;
                    this.Hide();
                    frmBienvenida bienvenida = new frmBienvenida();
                    bienvenida.Show();
                }
                    //solo puede entrar si 
                else if (usuario == "Ceci" && contraseña == "@3c" && (modulo.StartsWith("ADM") || modulo.StartsWith("VTA")))
                {
                    intentos = 0;
                    this.Hide();
                    frmBienvenida bienvenida = new frmBienvenida();
                    bienvenida.Show();
                }
                else if (usuario == "God" && contraseña == "@#4d")
                {
                    intentos = 0;
                    this.Hide();
                    frmBienvenida bienvenida = new frmBienvenida();
                    bienvenida.Show();
                }
                else
                {
                    intentos++;

                    if (usuario != "Adm" && usuario != "John" && usuario != "Ceci" && usuario != "God")
                    {
                        MessageBox.Show("Usuario incorrecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (contraseña != "@1a" && contraseña != "@2b" && contraseña != "@3c" && contraseña != "@#4d")
                    {
                        MessageBox.Show("Contraseña incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Módulo incorrecto para ese usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    if (intentos >= 2)
                    {
                        MessageBox.Show("Sistema cerrado.", "Bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                    }
                    
                }
            }
        }

        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Cierra el formulario
        this.Close(); //cierra el formulario
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            cmbMódulo.Items.Clear();  //limpia las casillas
            cmbMódulo.Items.Add("ADM - Administración");
            cmbMódulo.Items.Add("SIST - Sistemas");
            cmbMódulo.Items.Add("COM - Compras");
            cmbMódulo.Items.Add("VTA - Ventas");
            cmbMódulo.SelectedIndex = 0; //muestra el ADM ADMICION seleccioando caundo abre el formulario
        }
    }
}
