using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsteaTVInternetCompany
{
    public partial class Principal : Form
    {

        public Principal()
        {
            InitializeComponent();
            
            //GAW: Esto duplica informacion.
            //BaseDeDatos.CargarUsuarios();
        }
        public static string usuarioTextBox;


        private void claveBox_TextChanged(object sender, EventArgs e)
        {
            claveBox.PasswordChar = '·';
        }

        private void salirBtn_Click(object sender, EventArgs e)
        {

            Environment.Exit(0);

        }

        private void ingresarBtn_Click(object sender, EventArgs e)
        {
            int indexUsuario = BaseDeDatos.Usuarios.FindIndex((Usuario elem) => elem.Nombre == this.usuarioBox.Text && elem.Clave == this.claveBox.Text);
            if (indexUsuario > -1)
            {
                Principal2 form = new Principal2(indexUsuario);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario o clave invalido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void olvideClaveLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int indexUsuario = BaseDeDatos.Usuarios.FindIndex((Usuario elem) => elem.Nombre == this.usuarioBox.Text);
            if (indexUsuario > -1)
            {
                RecuperacionClave form = new RecuperacionClave(indexUsuario);
                form.ShowDialog();

            }
            else
            {
                MessageBox.Show("Usuario no reconocido");
            }
        }

        private void registrarseLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            Registrar form = new Registrar();
            form.ShowDialog();
        }
        
    }
}