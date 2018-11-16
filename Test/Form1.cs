﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vision_form;

namespace Test
{
    public partial class Form1 : Form
    {
        Calibration calib = new Calibration("MainCamera");

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calib.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            calib.SaveConfig();
        }
    }
}