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
    public partial class GestionProgramacion : Form
    {
        
        
        public GestionProgramacion()
        {
            InitializeComponent();
            //BaseDeDatos.CargarCanal();
            listaDeCanalesControl1.SetItems(BaseDeDatos.Canales);

            buscarCanalesBox.TextChanged += BuscarCanalesBox_TextChanged;
            nuevoBtn.Click += NuevoBtn_Click;
        }

        private void NuevoBtn_Click(object sender, EventArgs e)
        {
            AltaProgramacion form = new AltaProgramacion();
            form.ShowDialog();
            RefrescarLista();
        }

        private void BuscarCanalesBox_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltro();
        }

        bool FiltroDePlanes(Canal c)
        {
            string filtro = buscarCanalesBox.Text.ToUpper();
            return filtro.Length < 2 || (c.Nombre.ToUpper().Contains(filtro));
        }
        void AplicarFiltro()
        {
            listaDeCanalesControl1.Filtrar(FiltroDePlanes);
        }
        void RefrescarLista()
        {
            listaDeCanalesControl1.SetItems(BaseDeDatos.Canales);
            AplicarFiltro();
        }


    }
}
