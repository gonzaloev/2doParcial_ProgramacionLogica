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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            //BaseDeDatos.CargarTitular();
            listaDeTitularesControlcs1.SetItems(BaseDeDatos.Clientes);

            buscarBox.TextChanged += BuscarBox_TextChanged;
            nuevoBtn.Click += NuevoBtn_Click;
            BotonCSVClientes.Click += BotonCSVClientes_Click;
            
        }

        private void BotonCSVClientes_Click(object sender, EventArgs e)
        {
            EscribirCSV();
        }

        private void EscribirCSV()
        {
            List<string> registros = new List<string>();

            foreach (Cliente c in BaseDeDatos.Clientes)
            {
                registros.Add($"{c.Nro};{c.DNI};{c.Nombre};{c.Domicilio.Provincia};{c.Plan.Nombre};{c.Plan.Precio}");
            }

            DialogResult resultado = SaveClientes.ShowDialog();

            switch (resultado)
            {
                case DialogResult.OK:
                    MessageBox.Show(SaveClientes.FileName);
                    File.WriteAllLines(SaveClientes.FileName, registros);
                    break;
                case DialogResult.Cancel:
                    MessageBox.Show("Todo mal");
                    break;
            }

            
            //string[] lineas = new string[6]; 
            //for(int i = 0; i < BaseDeDatos.Clientes.Count; i++)
            //{
            //    lineas[0] = BaseDeDatos.Clientes[i].Nro;
            //    lineas[1] = BaseDeDatos.Clientes[i].DNI;
            //    lineas[2] = BaseDeDatos.Clientes[i].Nombre;
            //    lineas[3]  = BaseDeDatos.Clientes[i].Domicilio.Provincia;
            //    lineas[4] = BaseDeDatos.Clientes[i].Plan.Nombre;
            //    lineas[5] = $"{BaseDeDatos.Clientes[i].Plan.Precio}";
            //}
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
