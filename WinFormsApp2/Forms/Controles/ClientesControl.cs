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
    public partial class ClientesControl : UserControl
    {
        Cliente Titular;
        public ClientesControl()
        {
            InitializeComponent();
        }

        public ClientesControl(Cliente titular)
        {
            InitializeComponent();
            SetTitular(titular);

        }

        void SetTitular(Cliente t)
        {
            Titular = t;

            this.NombreLabel.Text = Titular.Nombre;
            this.DNILabel.Text = Titular.DNI;
            this.NroClienteLabel.Text = Titular.Nro;
            if (Titular.Estatus == true)
            {
                this.ActivoCheckBox.Checked = true;
            }
            else
            {
                this.ActivoCheckBox.Checked = false;
            }
        }


       
    }
}
