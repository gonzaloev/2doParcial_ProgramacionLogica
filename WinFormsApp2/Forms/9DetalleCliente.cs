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
    public partial class DetalleCliente : Form
    {
        public Cliente titular1;
        public DetalleCliente(Cliente titular)
        {
            InitializeComponent();            
            this.NombreLabel.Text = titular.Nombre;
            this.NroLabel.Text = titular.Nro;
            this.DNILabel.Text = titular.DNI;
            if (titular.Estatus == true)
            {
                this.ActivoLabel.Text = "Activo";
            }
            else
            {
                this.ActivoLabel.Text = "Inactivo";
            }
            this.DireccionLabel.Text = titular.Domicilio.Direccion;
            this.LocalidadLabel.Text = titular.Domicilio.Localidad;
            this.ProvinciaLabel.Text = titular.Domicilio.Provincia;
            this.EmailLabel.Text = titular.Contacto.email;
            this.TelefonoLabel.Text = titular.Contacto.telefono;
            this.TvLabel.Text = titular.Plan.Tv;
            this.InternetLabel.Text = titular.Plan.Internet;
            this.NombrePlanLabel.Text = titular.Plan.Nombre;
            this.PrecioLabel.Text = $"{titular.Plan.Precio}";

        }
         

    }
}
