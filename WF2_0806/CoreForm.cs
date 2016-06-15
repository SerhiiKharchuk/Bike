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
    public partial class CoreForm : Form
    {
        public CoreForm()
        {
            InitializeComponent();
            scContainer.Panel2.Controls.Add(new UcCross());
        }

        private void CoreForm_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBike ab = new AddBike();
            if (ab.ShowDialog()==DialogResult.OK)
            {
                
            }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openSavedToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CoreForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Good buy!","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
