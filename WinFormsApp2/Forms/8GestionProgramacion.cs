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
    public partial class GestionProgramacion : Form
    {
        
        
        public GestionProgramacion()
        {
            InitializeComponent();
            //BaseDeDatos.CargarCanal();
            listaDeCanalesControl1.SetItems(BaseDeDatos.Canales);

            buscarCanalesBox.TextChanged += BuscarCanalesBox_TextChanged;
            nuevoBtn.Click += NuevoBtn_Click;
            cargarCSVButton.Click += CargarCSVButton_Click;
        }

        private void CargarCSVButton_Click(object sender, EventArgs e)
        {
            DialogResult resultado = openFileCanales.ShowDialog();

            switch (resultado)
            {
                case DialogResult.OK:
                    //MessageBox.Show(openFileCanales.FileName);
                    break;
                case DialogResult.Cancel:
                    break;
            }

            List<Canal> registros = LeerCanalesDeCSV(openFileCanales.FileName);

            if(registros == null)
            {
                return;
            }

            foreach (Canal c in registros)
            {
                BaseDeDatos.Canales.Add(c);
            }

            RefrescarLista();
        }

        private List<Canal> LeerCanalesDeCSV(string path)
        {
            List<Canal> canales = new List<Canal>();

            string[] registros = File.ReadAllLines(path);

            canales.Capacity = registros.Length;

            for (int i = 0; i < registros.Length; i++)
            {
                string[] campos = registros[i].Split(";");

                Canal c = GenerarCanal(campos);

                if (c == null)
                {
                    MessageBox.Show("Metiste cualquier data hermano");
                    return null;
                }
                else
                {
                    canales.Add(c);
                }
            }
            return canales;
        }

        private Canal GenerarCanal(string[] campos)
        {
            if (campos == null)
            {
                return null;
            }

            if (campos.Length != 2)
            {
                return null;
            }


            string nombreCanal = campos[0];
            string nroCanal = campos[1];

            decimal nroCanalParseado;

            Canal resultado = new Canal();

            if (!decimal.TryParse(nroCanal, out nroCanalParseado))
            {
                return null;
            }
            if (nombreCanal.Length == 0)
            {
                return null;
            }


            resultado.Nombre = nombreCanal;
            resultado.Nro = nroCanalParseado;
            
            return resultado;
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
