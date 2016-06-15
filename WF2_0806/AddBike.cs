using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF2_0806
{
    public partial class AddBike : Form
    {
        private UcCross ucCross = new UcCross();
        public AddBike()
        {
            InitializeComponent();
           
            cbBikeType.Items.Add(BikeType.Cross);
            cbBikeType.SelectedIndex = 0;
        }

        private void cbBikeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            BikeType type = (BikeType)Enum.Parse(typeof(BikeType), cbBikeType.SelectedItem.ToString());
            switch (type)
            {
                case BikeType.Cross:
                    panelContent.Controls.Clear();
                    panelContent.Controls.Add(ucCross);
                    break;
            }
        }
    }
}
