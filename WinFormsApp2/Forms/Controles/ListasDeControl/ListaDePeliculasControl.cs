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
    public partial class ListaDePeliculasControl : UserControl
    {
        
        List<PeliculaControl> Items = new List<PeliculaControl>();

        public ListaDePeliculasControl()
        {
            InitializeComponent();
            flowLayoutPanel1.SizeChanged += FlowLayoutPanel1_SizeChanged;
        }

        public void SetItems(List<Pelicula> peliculas)
        {
            flowLayoutPanel1.Controls.Clear();
            Items.Clear();

            for (int i = 0; i < peliculas.Count; i++)
            {
                PeliculaControl item = new PeliculaControl(peliculas[i]);
                item.Width = flowLayoutPanel1.Width - 25;

                Items.Add(item);
                flowLayoutPanel1.Controls.Add(item);
            }
        }

        public void Filtrar(Predicate<Pelicula> predicate)
        {
            for (int i = 0; i < Items.Count; i++)
            {
                Items[i].Visible = predicate(Items[i].Pelicula);
            }
        }

        void FlowLayoutPanel1_SizeChanged(object sender, EventArgs e)
        {
            ActualizarAnchoDeItems();
        }

        void ActualizarAnchoDeItems()
        {
            for (int i = 0; i < flowLayoutPanel1.Controls.Count; i++)
            {
                flowLayoutPanel1.Controls[i].Width = flowLayoutPanel1.Width - 25;
            }
        }
    }
}
