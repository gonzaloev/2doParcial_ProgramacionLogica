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
    public partial class GestionDeCanal : Form
    {
        public Canal canal1;
        public GestionDeCanal(Canal canal)
        {
            InitializeComponent();
            //BaseDeDatos.CargarPeliculas();
            listaDePeliculasControl1.SetItems(BaseDeDatos.peliculas);

            BuscarTexBox.TextChanged += BuscarTexBox_TextChanged;
            nuevoBtn.Click += NuevoBtn_Click;
        }

        private void NuevoBtn_Click(object sender, EventArgs e)
        {
            AltaPelicula form = new AltaPelicula();
            form.ShowDialog();
            RefrescarLista();
        }

        private void BuscarTexBox_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltro();
        }
        bool FiltroDePlanes(Pelicula p)
        {
            string filtro = BuscarTexBox.Text.ToUpper();
            return filtro.Length < 2 || (p.Nombre.ToUpper().Contains(filtro));
        }
        void AplicarFiltro()
        {
            listaDePeliculasControl1.Filtrar(FiltroDePlanes);
        }
        void RefrescarLista()
        {
            listaDePeliculasControl1.SetItems(BaseDeDatos.peliculas);
            AplicarFiltro();
        }

    }
}
