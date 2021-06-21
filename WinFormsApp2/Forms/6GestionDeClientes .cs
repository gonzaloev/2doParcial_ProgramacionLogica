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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            //BaseDeDatos.CargarTitular();
            listaDeTitularesControlcs1.SetItems(BaseDeDatos.Clientes);

            buscarBox.TextChanged += BuscarBox_TextChanged;
            nuevoBtn.Click += NuevoBtn_Click;
            
        }

        private void NuevoBtn_Click(object sender, EventArgs e)
        {
            AltaCliente form = new AltaCliente();  
            form.ShowDialog();
            RefrescarLista();
        }


        private void BuscarBox_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltro();
        }
        bool FiltroDePersonas(Cliente t)
        {
            string filtro = buscarBox.Text.ToUpper();
            return filtro.Length < 2 || (t.Nombre.ToUpper().Contains(filtro));
        }


        void AplicarFiltro()
        {
            listaDeTitularesControlcs1.Filtrar(FiltroDePersonas);
        }


        void RefrescarLista()
        {
            listaDeTitularesControlcs1.SetItems(BaseDeDatos.Clientes);
            AplicarFiltro();
        }

    }
}
