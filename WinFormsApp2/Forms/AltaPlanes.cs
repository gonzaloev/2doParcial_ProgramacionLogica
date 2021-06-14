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
    public partial class AltaPlanes : Form
    {
        public AltaPlanes()
        {
            InitializeComponent();
            this.CrearButton.Click += CrearButton_Click;
            this.AtrasButton.Click += AtrasButton_Click;
        }

        private void AtrasButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void CrearButton_Click(object sender, EventArgs e)
        {
            if(this.PlanTextBox.Text == "" || this.TvTextBox2.Text == "" || this.InternetTextBox.Text == "" || this.numericUpDown1.Value <= 0)
            {
                MessageBox.Show("Campos vacios.");
            }else
            {
                Plan pl = new Plan()
                {
                    Nombre = this.PlanTextBox.Text,
                    Tv = this.TvTextBox2.Text,
                    Internet = this.InternetTextBox.Text,
                    Precio = this.numericUpDown1.Value
                };

                BaseDeDatos.Planes.Add(pl);

                MessageBox.Show("Plan creado con exito!");
                this.Hide();
            }
        }
    }
}
