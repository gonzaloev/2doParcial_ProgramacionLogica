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
    public partial class CanalItem : UserControl
    {

        public Canal Canal;

        public CanalItem()
        {
            InitializeComponent();

        }

        public CanalItem(Canal canal)
        {
            InitializeComponent();
            VerButton.Click += VerButton_Click;
            SetCanal(canal);
        }

        void SetCanal(Canal canal)
        {
            
            Canal = canal;
            this.NombreLabel.Text = $"{Canal.Nombre}";
            this.CanalLabel.Text = $"{ Canal.Nro}";
        }

        private void VerButton_Click(object sender, EventArgs e)
        {
            GestionDeCanal form = new GestionDeCanal(Canal);
            form.ShowDialog();
        }
    }
}
