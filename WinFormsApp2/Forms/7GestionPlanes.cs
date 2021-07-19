using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            cargarCSVButton.Click += CargarCSVButton_Click;
        }

        private void CargarCSVButton_Click(object sender, EventArgs e)
        {
            DialogResult resultado = openFilePlanes.ShowDialog();

            switch (resultado)
            {
                case DialogResult.OK:
                    //MessageBox.Show(openFilePlanes.FileName);
                    break;
                case DialogResult.Cancel:
                    break;                
            }

            List<Plan> registros = LeerPlanesDeCSV(openFilePlanes.FileName);

            if (registros == null)
            {
                return;
            }

            foreach (Plan p in registros)
            {
                //No pueden haber 2 planes con el mismo nombre
                if (BaseDeDatos.Planes.Find((Plan x) => x.Nombre == p.Nombre) == null)
                {
                    BaseDeDatos.Planes.Add(p);
                }
                
            }

            RefrescarLista();
        }

        private List<Plan> LeerPlanesDeCSV(string path)
        {
            List<Plan> planes = new List<Plan>();

            string[] registros = File.ReadAllLines(path);

            planes.Capacity = registros.Length;

            for (int i = 0; i < registros.Length; i++)
            {
                string[] campos = registros[i].Split(";");

                Plan p = GenerarPlan(campos);

                if(p == null)
                {
                    MessageBox.Show("Metiste cualquier data hermano");
                    return null;
                }
                else
                {
                    planes.Add(p);
                }
            }
            return planes;
        }

        private Plan GenerarPlan(string[] campos)
        {
            if (campos == null)
            {
                return null;
            }

            if (campos.Length != 4)
            {                
                return null;
            }

            //Nombre del plan; TV; Internet; Precio

            string nombrePlan = campos[0];
            string tv = campos[1];
            string internet = campos[2];
            string precio = campos[3];

            decimal precioParseado;

            Plan resultado = new Plan();

            if (!decimal.TryParse(precio, out precioParseado))
            {
                return null;
            }
            if (nombrePlan.Length == 0)
            {
                return null;
            }
            if (tv.Length == 0)
            {
                return null;
            }
            if (internet.Length == 0)
            {
                return null;
            }

            resultado.Nombre = nombrePlan;
            resultado.Tv = tv;
            resultado.Precio = precioParseado;
            resultado.Internet = internet;

            return resultado;
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
