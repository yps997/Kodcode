using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
       public string chak = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void rdbtnR_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnR.Checked)
            {
                chak = "r";
            }
        }

        private void rdbtnK_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnK.Checked)
            {
                chak = "k";
            }
        }

        private void rdbtnY_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnY.Checked)
            {
                chak = "y";
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            Pillar pillar = new Pillar(
                int.Parse(txtWidth.Text),
                int.Parse(txtHeight.Text),
                chak);
            lblStatus.Text = pillar.Status;
            Console.WriteLine(lblStatus.Text);
                
        }

        private void txtHeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtWidth_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }
    }
}
