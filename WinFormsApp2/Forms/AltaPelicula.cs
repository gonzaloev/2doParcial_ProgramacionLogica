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
    public partial class AltaPelicula : Form
    {
        public AltaPelicula()
        {
            InitializeComponent();
            this.horarioTimePicker.Format = DateTimePickerFormat.Time;
            
            //this.horarioTimePicker.CustomFormat = DateTimePickerFormat.Custom;
            //this.horarioTimePicker.CustomFormat = "HH:mm:ss";
            //this.horarioTimePicker.ShowUpDown = true;
            this.CargarButton.Click += CargarButton_Click;
            this.AtrasButton.Click += AtrasButton_Click;
        }

        private void AtrasButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void CargarButton_Click(object sender, EventArgs e)
        {
            int duracion;

            if(this.NombreTextBox.Text == "" || this.DuracionTextBox.Text == "")
            {
                MessageBox.Show("Campos vacios");
            }else if(this.DuracionTextBox.Text.Length >= 4)
            {
                MessageBox.Show("La duracion debe ser de maximo 999 minutos.");
            }
            else if (int.TryParse(this.DuracionTextBox.Text, out duracion) == false)
            {
                MessageBox.Show("Duracion debe ser un valor numerico.");
            }else if (duracion <= 0)
            {
                MessageBox.Show("Duracion no puede ser negativo o 0.");
            }
            else
            {
                Pelicula pl = new Pelicula()
                {
                    Nombre = this.NombreTextBox.Text,
                    Duracion = $"{duracion}",
                    HHHorario = this.horarioTimePicker.Value
                    
                };

                BaseDeDatos.peliculas.Add(pl);
                MessageBox.Show("Pelicula Creada con exito");
                this.Hide();
                
            }
        }
    }
}
