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
    public partial class AltaProgramacion : Form
    {
       
        public AltaProgramacion()
        {
            InitializeComponent();

            AtrasBtn.Click += AtrasBtn_Click;
            GuardarBtn.Click += GuardarBtn_Click;
        }

        private void GuardarBtn_Click(object sender, EventArgs e)
        {
           
            if ((this.numericUpDown1.Value <= 0 && this.numericUpDown1.Value != this.Canal.Nro) || this.NombreTextBox.Text == "")
            {
                MessageBox.Show("Campos vacios o invalidos.");
            }
            else
            {
                Canal cn = new Canal()
                {
                    Nombre = this.NombreTextBox.Text,
                    Nro = this.numericUpDown1.Value
                };
                BaseDeDatos.Canales.Add(cn);
                MessageBox.Show("Canal creado con exito");

                this.Hide();
            }
        }

        private void AtrasBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
