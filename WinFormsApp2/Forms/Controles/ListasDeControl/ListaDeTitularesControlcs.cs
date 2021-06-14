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
    public partial class ListaDeTitularesControlcs : UserControl
    {
        List<TitularesItem> Items = new List<TitularesItem>();
        public ListaDeTitularesControlcs()
        {
            InitializeComponent();
            FLPanel.SizeChanged += FLPanel_SizeChanged;
        }

        public void SetItems(List<Titular> titulares)
        {
            FLPanel.Controls.Clear();
            Items.Clear();

            for(int i = 0; i < titulares.Count; i++)
            {
                TitularesItem item = new TitularesItem(titulares[i]);
                item.Width = FLPanel.Width - 25;

                Items.Add(item);
                FLPanel.Controls.Add(item);
            }
        }

        public void Filtrar(Predicate<Titular> predicate)
        {
            for(int i = 0; i < Items.Count; i++)
            {
                Items[i].Visible = predicate(Items[i].Titular);
            }
        }
        private void FLPanel_SizeChanged(object sender, EventArgs e)
        {
            ActualizarAnchoItems();
        }

        void ActualizarAnchoItems()
        {
            for (int i = 0; i < FLPanel.Controls.Count; i++)
            {
                FLPanel.Controls[i].Width = FLPanel.Width - 25;
            }
        }
    }
}
