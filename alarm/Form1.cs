﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            NewAlarm alarm = new NewAlarm();
            alarm.Show();
        }

        
    }
}
