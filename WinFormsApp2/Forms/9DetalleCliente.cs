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
        public Titular titular1;
        public DetalleCliente(Titular titular)
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
            this.DireccionLabel.Text = titular.TDomicilio.Direccion;
            this.LocalidadLabel.Text = titular.TDomicilio.Localidad;
            this.ProvinciaLabel.Text = titular.TDomicilio.Provincia;
            this.EmailLabel.Text = titular.TContacto.email;
            this.TelefonoLabel.Text = titular.TContacto.telefono;
            this.TvLabel.Text = titular.TPlan.Tv;
            this.InternetLabel.Text = titular.TPlan.Internet;
            this.NombrePlanLabel.Text = titular.TPlan.Nombre;
            this.PrecioLabel.Text = $"{titular.TPlan.Precio}";

        }
         

    }
}
