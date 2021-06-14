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
    public partial class PlanesItem : UserControl
    {
        public Plan Plan;
        public PlanesItem()
        {
            InitializeComponent();
        }
        public PlanesItem(Plan plan)
        {
            InitializeComponent();
            SetPlan(plan);
        }

        void SetPlan(Plan plan)
        {
            Plan = plan;
            PlanLabel.Text = Plan.Nombre;
            TvLabel.Text = Plan.Tv;
            PrecioNumericUpDown.Value = Plan.Precio;
            InternetLabel.Text = Plan.Internet;
        }


    }
}
