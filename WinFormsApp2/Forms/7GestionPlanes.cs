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
    
    public partial class Form8 : Form
    {
        
        public Form8()
        {
            InitializeComponent();
            //BaseDeDatos.CargarPlanes();
            listaDePlanes1.SetItems(BaseDeDatos.Planes);

            buscarPlanesBox.TextChanged += BuscarPlanesBox_TextChanged;
            nuevoBtn.Click += NuevoBtn_Click;
        }
        private void NuevoBtn_Click(object sender, EventArgs e)
        {
            AltaPlanes form = new AltaPlanes();
            form.ShowDialog();
            RefrescarLista();
        }
        private void BuscarPlanesBox_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltro();
        }
        bool FiltroDePlanes(Plan p)
        {
            string filtro = buscarPlanesBox.Text.ToUpper();
            return filtro.Length < 2 || (p.Nombre.ToUpper().Contains(filtro));
        }
        void AplicarFiltro()
        {
            listaDePlanes1.Filtrar(FiltroDePlanes);
        }
        void RefrescarLista()
        {
            listaDePlanes1.SetItems(BaseDeDatos.Planes);
            AplicarFiltro();
        }

    
    }
}
