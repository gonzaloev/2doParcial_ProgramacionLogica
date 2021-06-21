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
    public partial class TitularesItem : UserControl
    {
        public Cliente Titular;
        public TitularesItem()
        {
            InitializeComponent();
        }

        public TitularesItem(Cliente titular)
        {
            InitializeComponent();
            VerButton.Click += VerButton_Click;
            SetTitular(titular);
        }

        void SetTitular(Cliente titular)
        {
            Titular = titular;
            NombreLabel.Text = $"{Titular.Nombre}";
            DNILabel.Text = $"{Titular.DNI}";
            NroClienteLabel.Text = $"{Titular.Nro}";
            if (Titular.Estatus == true)
            {
                ActivoCheckBox.Checked = true;
            }
            else
            {
                ActivoCheckBox.Checked = false;
            }

        }
        private void VerButton_Click(object sender, EventArgs e)
        {
            DetalleCliente form = new DetalleCliente(Titular);
            form.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
