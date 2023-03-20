using System.Configuration;

namespace AD_WEEK_3_RILL
{

    public partial class main : Form
    {
        public bool second = false;
        second form2 = new second();
       
        public main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox.Checked)
            {
                submit_butt.Enabled = true;
            }
           if(checkBox.Checked==false)
            {
                submit_butt.Enabled = false;
            }
        }

        private void next_butt_Click(object sender, EventArgs e)
        {
            form2.Show(this);
            second = true;
        }

        private void submit_butt_Click(object sender, EventArgs e)
        {
            if(second==true&&nama_tb.Text !=""&&artis_tb.Text != "")
            {
              
            }
            else
            {
                MessageBox.Show("Please enter the correct input");
            }
        }
    }
}