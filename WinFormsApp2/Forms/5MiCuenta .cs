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
    public partial class Form4 : Form
    {
        public int index;
        public Form4(int indexUsuario)
        {
            InitializeComponent();
            this.CambiarClaveButton.Click += CambiarClaveButton_Click;
            this.CambiarPreguntaButton.Click += CambiarPreguntaButton_Click;
            this.AtrasLinkLabel.Click += AtrasLinkLabel_Click;
            index = indexUsuario;
        }

        private void CambiarPreguntaButton_Click(object sender, EventArgs e)
        {
            CambioPregunta form = new CambioPregunta(index);
            form.ShowDialog();
        }

        private void AtrasLinkLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void CambiarClaveButton_Click(object sender, EventArgs e)
        {
            CambiarClave form = new CambiarClave(index);
            form.ShowDialog();
        }
    }
}
