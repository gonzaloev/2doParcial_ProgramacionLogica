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
    public partial class Principal2 : Form
    {
        string textoDeForm1;
        int index;
        public Principal2(int indexUsuario)
        {
            InitializeComponent();
            textoDeForm1 = Principal.usuarioTextBox;
            index = indexUsuario;
            this.NombreUsuarioLabel.Text = BaseDeDatos.Usuarios[index].Nombre;
            this.LogOutLabel.Click += LogOutLabel_Click;
            this.btnClientes.MouseHover += BtnClientes_MouseHover;
            this.btnClientes.MouseLeave += BtnClientes_MouseLeave;
            this.planesBtn.MouseHover += PlanesBtn_MouseHover;
            this.planesBtn.MouseLeave += PlanesBtn_MouseLeave;
            this.programacionBtn.MouseHover += ProgramacionBtn_MouseHover;
            this.programacionBtn.MouseLeave += ProgramacionBtn_MouseLeave;

        }

        private void LogOutLabel_Click(object sender, EventArgs e)
        {
            string msj = "¿Desea cerrar sesion?";
            string tituloVentana = "Cerrar Sesion";
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(msj, tituloVentana, botones);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Principal form = new Principal();
                form.ShowDialog();
            }
        }

        private void ProgramacionBtn_MouseLeave(object sender, EventArgs e)
        {
            this.programacionBtn.ForeColor = Color.White;
        }

        private void ProgramacionBtn_MouseHover(object sender, EventArgs e)
        {
            this.programacionBtn.ForeColor = Color.Black;
        }

        private void PlanesBtn_MouseLeave(object sender, EventArgs e)
        {
            this.planesBtn.ForeColor = Color.White;
        }

        private void PlanesBtn_MouseHover(object sender, EventArgs e)
        {
            this.planesBtn.ForeColor = Color.Black;
        }

        private void BtnClientes_MouseLeave(object sender, EventArgs e)
        {
            this.btnClientes.ForeColor = Color.White;
        }

        private void BtnClientes_MouseHover(object sender, EventArgs e)
        {

            this.btnClientes.ForeColor = Color.Black;

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Form4 form = new Form4(index);
            form.ShowDialog();

        }

        private void cerrarBtn_Click(object sender, EventArgs e)
        {

            string msj = "¿Desea cerrar completamente el sistema?";
            string tituloVentana = "Cerrar Ventana";
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(msj, tituloVentana, botones);
            if (result == DialogResult.Yes)
            {
                Environment.Exit(0);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            form.ShowDialog();
        }

        private void planesBtn_Click(object sender, EventArgs e)
        {
            Form8 form = new Form8();
            form.ShowDialog();
        }

        private void programacionBtn_Click(object sender, EventArgs e)
        {
            GestionProgramacion form = new GestionProgramacion();
            form.ShowDialog();
        }
    }
}
