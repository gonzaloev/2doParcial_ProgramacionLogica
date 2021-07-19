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
    public partial class RecuperacionClave : Form
    {
        
        private int index;
        public RecuperacionClave(int indexUsuario)
        {
            InitializeComponent();
            this.usuarioLabel.Text = BaseDeDatos.Usuarios[indexUsuario].Nombre;
            index = indexUsuario;            
            this.recuperarBtn.Click += RecuperarBtn_Click;
            this.cambiarBtn.Click += CambiarBtn_Click;
            this.preguntaLabel.Text = BaseDeDatos.Usuarios[indexUsuario].Pregunta;
            
        }

        
        private void RecuperarBtn_Click(object sender, EventArgs e)
        {
            string respuesta = this.respuestaTextBox.Text;
            if(respuesta == BaseDeDatos.Usuarios[index].Respuesta)
            {
                MessageBox.Show("Respuesta Valida, ingrese su nueva Contraseña");
                respuestaTextBox.Enabled = false;
                claveTextBox.Enabled = true;
                repitaTextBox.Enabled = true;
                
            }
            else
            {
                MessageBox.Show("Respuesta invalida");
            }
        }
        private void CambiarBtn_Click(object sender, EventArgs e)
        {
            if (!claveTextBox.Enabled)
            {
                MessageBox.Show("Ingrese la respuesta de seguridad.");
            }else if (claveTextBox.Text.Length == 0)
            {
                MessageBox.Show("Ingrese una clave.");
            }
            else if (claveTextBox.Text != repitaTextBox.Text)
            {
                MessageBox.Show("Las claves no coinciden.");
            }
            else if (claveTextBox.Text == repitaTextBox.Text)
            {
                BaseDeDatos.Usuarios[index].Clave = claveTextBox.Text;
                MessageBox.Show("Cambio de clave exitoso!");
                this.Hide();
                Principal form = new Principal();
                form.ShowDialog();
            }
        }
        private void atrasBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Principal form = new Principal();
            form.ShowDialog();
        }
    }
}
