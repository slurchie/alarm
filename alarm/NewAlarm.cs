using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alarm
{
    public partial class NewAlarm : Form
    {
        public NewAlarm()
        {
            InitializeComponent();
        }

        Timer timer01 = new Timer();
        Form1 frm = new Form1();

        private void NewAlarm_Load(object sender, EventArgs e)
        {
            timer01.Interval = 1000;
            timer01.Start();
        }

        private void YESradioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (YESradioButton.Checked)
            {
                timer01.Start();
            }     
        }

        private void NOradioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (NOradioButton.Checked)
            {
                timer01.Stop();
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if(SaveButton.Enabled)
            {
               
                frm.Show();
                this.Hide();
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm.Show();
            this.Hide();


        }
    }
}
