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
    public partial class CambioPregunta : Form
    {
        public int index;
        public CambioPregunta(int indexUsuario)
        {
            InitializeComponent();
            this.ValidaButton.Click += ValidaButton_Click;
            this.AceptaButton.Click += AceptaButton_Click;
            this.AtraButton.Click += AtraButton_Click;
            index = indexUsuario;
        }

        private void AtraButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AceptaButton_Click(object sender, EventArgs e)
        {
            if(this.NuevaPreguntaTextBox.Text == "" || this.NuevaRespuestaTextBox.Text == "" || this.RepitaPreguntaTextBox.Text == "" || this.RepitaRespuestaTextBox.Text == "")
            {
                MessageBox.Show("Campos Vacios.");
            } else if (this.NuevaPreguntaTextBox.Text != this.RepitaPreguntaTextBox.Text || this.NuevaRespuestaTextBox.Text != this.RepitaRespuestaTextBox.Text)
            {
                MessageBox.Show("Los campos no coinciden.");
            } else if (this.NuevaPreguntaTextBox.Text == this.RepitaPreguntaTextBox.Text && this.NuevaRespuestaTextBox.Text == this.RepitaRespuestaTextBox.Text)
            {
                BaseDeDatos.Usuarios[index].Pregunta = this.NuevaPreguntaTextBox.Text;
                BaseDeDatos.Usuarios[index].Respuesta = this.NuevaRespuestaTextBox.Text;
                MessageBox.Show("Pregunta y respuesta de seguridad actualizadas con exito.");
                this.Hide();
            }
        }

        private void ValidaButton_Click(object sender, EventArgs e)
        {
            if (this.PreguntaActualTextBox.Text == "" || this.RespuestaActualTextBox.Text == "")
            {
                MessageBox.Show("Campos vacios.");
            }
            else if(BaseDeDatos.Usuarios[index].Pregunta != this.PreguntaActualTextBox.Text || BaseDeDatos.Usuarios[index].Respuesta != this.RespuestaActualTextBox.Text)
            {
                MessageBox.Show("Pregunta o Respuesta de seguridad invalidas");
            }else if (BaseDeDatos.Usuarios[index].Pregunta == this.PreguntaActualTextBox.Text && BaseDeDatos.Usuarios[index].Respuesta == this.RespuestaActualTextBox.Text)
            {
                MessageBox.Show("Validacion exitosa");
                this.PreguntaActualTextBox.Enabled = false;
                this.RespuestaActualTextBox.Enabled = false;
                this.NuevaPreguntaTextBox.Enabled = true;
                this.NuevaRespuestaTextBox.Enabled = true;
                this.RepitaPreguntaTextBox.Enabled = true;
                this.RepitaRespuestaTextBox.Enabled = true;
            }
        }
    }
}
