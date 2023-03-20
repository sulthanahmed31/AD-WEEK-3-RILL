using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace AD_WEEK_3_RILL
{
    public partial class second : Form
    {
        public second()
        {
            InitializeComponent();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void magic_Click(object sender, EventArgs e)
        {
            main form1 = (main)this.Owner;
            bool backcolor = true;
            bool textcolor = true;
            if (merah.Checked == false && biru.Checked == false && hijau.Checked == false && ungu.Checked == false && hitam.Checked == false)
            {
                backcolor = false;
            }
            if (tulis_merah.Checked == false && tulis_biru.Checked == false && tulis_hijau.Checked == false)
            {
                textcolor = false;
            }
            if (backcolor == false || textcolor == false)
            {
                MessageBox.Show("Please choose color from the radio button");
            }
            if (backcolor == true && textcolor == true)
            {
                if (merah.Checked)
                {
                    form1.BackColor = Color.Red;
                }
                else if (biru.Checked)
                {
                    form1.BackColor = Color.Blue;
                }
                else if (hijau.Checked)
                {
                    form1.BackColor = Color.Green;
                }
                else if (ungu.Checked)
                {
                    form1.BackColor = Color.Purple;
                }
                else if (hitam.Checked)
                {
                    form1.BackColor = Color.Black;
                }

                if (tulis_merah.Checked)
                {
                    form1.ForeColor = Color.Red;
                }
                else if (tulis_biru.Checked)
                {
                    form1.ForeColor = Color.Blue;
                }
                else if (tulis_hijau.Checked)
                {
                    form1.ForeColor = Color.Green;
                }
               
            }
        }

        private void checkBox6_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox6.Checked && checkBox10.Checked)
            {
                magic.Enabled = true;
            }
            if (checkBox6.Checked == false || checkBox10.Checked == false)
            {
                magic.Enabled = false;
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked && checkBox10.Checked)
            {
                magic.Enabled = true;
            }
            if (checkBox6.Checked == false || checkBox10.Checked == false)
            {
                magic.Enabled = false;
            }
        }
        public void gantinama(string NAMA,string ARTIS)
        {
            label3.Text = ("Hi, my name is " + NAMA + " and my favorite artist is " + ARTIS);
        }
    }
}
