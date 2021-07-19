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
    public partial class PeliculaControl : UserControl
    {
        public Pelicula Pelicula;
        public PeliculaControl()
        {
            InitializeComponent();
        }

        public PeliculaControl(Pelicula pelicula)
        {
            InitializeComponent();
            SetCanal(pelicula);
            dateTimePicker.ValueChanged += DateTimePicker_ValueChanged;
        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            Pelicula.HHHorario = this.dateTimePicker.Value;
        }

        void SetCanal(Pelicula pelicula)
        {

            Pelicula = pelicula;
            this.NombreLabel.Text = $"{Pelicula.Nombre}";
            this.DuracionLabel.Text = $"{Pelicula.Duracion}";
            this.dateTimePicker.Value = Pelicula.HHHorario;
        } 
    }
}
