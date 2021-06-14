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
    public partial class AltaCliente : Form
    {
        public AltaCliente()
        {
            InitializeComponent();
            this.planCombo.DisplayMember = "Nombre";
            this.planCombo.DataSource = BaseDeDatos.Planes;
            this.planCombo.SelectedValueChanged += PlanCombo_SelectedValueChanged;
            this.cancelarBtn.Click += CancelarBtn_Click;
            this.guardarBtn.Click += GuardarBtn_Click;
            CargarPlan();
        }


       void CargarPlan()
        {
            Plan p = (Plan)this.planCombo.SelectedItem;
            this.tvLabel.Text = p.Tv;
            this.InternetLabel.Text = p.Internet;
            this.PrecioLabel.Text = $"{p.Precio}";
        }
        private void PlanCombo_SelectedValueChanged(object sender, EventArgs e)
        {
            //BaseDeDatos.Planes.FindIndex(elem => elem.Nombre == this.planCombo.Text);
            Plan p = (Plan)this.planCombo.SelectedItem;
            this.tvLabel.Text = p.Tv;
            this.InternetLabel.Text = p.Internet;
            this.PrecioLabel.Text = $"{p.Precio}";
            
            
        }

        private void GuardarBtn_Click(object sender, EventArgs e)
        {

            if(this.nombreBox.Text == "" || this.nroClienteBox.Text == "" || this.dniBox.Text == "" || this.emailBox.Text == "" || this.telefonoBox.Text == "" 
                || this.direccionBox.Text == "" || this.localidadBox.Text == "" || this.provinciaBox.Text == "")
            {
                MessageBox.Show("Campos Vacios, por favor llene todos los campos.");
            }
            else
            {
                

                Titular ti = new Titular()
                {
                    Nombre = this.nombreBox.Text,
                    Nro = this.nroClienteBox.Text,
                    DNI = this.dniBox.Text,
                    Estatus = this.activoCheck.Checked,
                    TContacto = new Contacto()
                    {
                        email = this.emailBox.Text,
                        telefono = this.telefonoBox.Text
                    },
                    TDomicilio = new Domicilio()
                    {
                        Direccion = this.direccionBox.Text,
                        Localidad = this.localidadBox.Text,
                        Provincia = this.provinciaBox.Text
                    },
                    TPlan = (Plan)this.planCombo.SelectedItem
                    
                };
                BaseDeDatos.Titulares.Add(ti);
                MessageBox.Show("Cliente creado con exito");
                this.Hide();
            } 
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
