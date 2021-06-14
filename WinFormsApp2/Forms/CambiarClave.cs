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
    public partial class CambiarClave : Form
    {
        public int index;
        public CambiarClave(int indexUsuario)
        {
            InitializeComponent();
            index = indexUsuario;
            this.AtrasButton.Click += AtrasButton_Click;
            this.ValidarButton.Click += ValidarButton_Click;
            this.AceptarButton.Click += AceptarButton_Click;
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            if(this.ClaveActualTextBox.Enabled == true)
            {
                MessageBox.Show("Ingrese su clave actual");
            }else if (this.NuevaClaveTextBox.Text != this.ReingresaClaveTextBox.Text)
            {
                MessageBox.Show("Las claves no coinciden");
            }else if (this.NuevaClaveTextBox.Text == "" || this.ReingresaClaveTextBox.Text == "")
            {
                MessageBox.Show("Campos vacios.");
            }
            else if(this.NuevaClaveTextBox.Text == this.ReingresaClaveTextBox.Text)
            {
                BaseDeDatos.Clientes[index].Clave = this.NuevaClaveTextBox.Text;
                MessageBox.Show("Clave actualizada con exito!");
                this.Hide();
            }
        }

        private void ValidarButton_Click(object sender, EventArgs e)
        {
            if(BaseDeDatos.Clientes[index].Clave == this.ClaveActualTextBox.Text)
            {
                MessageBox.Show("Clave Verificada.");
                ClaveActualTextBox.Enabled = false;
                NuevaClaveTextBox.Enabled = true;
                ReingresaClaveTextBox.Enabled = true;
            }
            else if(this.ClaveActualTextBox.Text == "")
            {
                MessageBox.Show("Ingrese su clave.");
            }
            else
            {
                MessageBox.Show("Clave Invalida.");
            }
        }

        private void AtrasButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
