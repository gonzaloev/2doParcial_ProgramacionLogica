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
    public partial class ListaDePlanes : UserControl
    {
        List<PlanesItem> Items = new List<PlanesItem>();
        public ListaDePlanes()
        {
            InitializeComponent();
            FLPPanels.SizeChanged += FLPPanels_SizeChanged;
        }
        public void SetItems(List<Plan> planes)
        {
            FLPPanels.Controls.Clear();
            Items.Clear();

            for (int i = 0; i < planes.Count; i++)
            {
                PlanesItem item = new PlanesItem(planes[i]);
                item.Width = FLPPanels.Width - 25;

                Items.Add(item);
                FLPPanels.Controls.Add(item);
            }
        }
        public void Filtrar(Predicate<Plan> predicate)
        {
            for (int i = 0; i < Items.Count; i++)
            {
                Items[i].Visible = predicate(Items[i].Plan);
            }
        }
        private void FLPPanels_SizeChanged(object sender, EventArgs e)
        {
            ActualizarAnchoItems();
        }
        void ActualizarAnchoItems()
        {
            for (int i = 0; i < FLPPanels.Controls.Count; i++)
            {
                FLPPanels.Controls[i].Width = FLPPanels.Width - 25;
            }
        }
    }
}
