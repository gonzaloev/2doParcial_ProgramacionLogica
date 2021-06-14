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
    public partial class Registrar : Form
    {
        public Registrar()
        {
            InitializeComponent();
            registrarBtn.Click += RegistrarBtn_Click;
            atrasBtn.Click += AtrasBtn_Click;
        }

        private void AtrasBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Principal form = new Principal();
            form.ShowDialog();
        }

        private void RegistrarBtn_Click(object sender, EventArgs e)
        {
            string usuario = usuarioTextBox.Text;
            string clave = claveTextBox.Text;
            string repetirClave = repetirClaveTextBox.Text;
            string pregunta = PreguntaTextBox.Text;
            string respuesta = RespuestaTexxtBox.Text;
            if(clave != repetirClave)
            {
                MessageBox.Show("Las claves no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(usuario.Length == 0 || clave.Length == 0 || repetirClave.Length == 0 || pregunta.Length == 0 || respuesta.Length == 0)
            {
                MessageBox.Show("Campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Cliente cl = new Cliente()
                {
                    Usuario = usuario,
                    Clave = clave,
                    Pregunta = pregunta,
                    Respuesta = respuesta
                };
                BaseDeDatos.Clientes.Add(cl);

                MessageBox.Show("Usuario creado con exito!");

                this.Hide();
                Principal form = new Principal();
                form.ShowDialog();

            }

        }
    }
}
