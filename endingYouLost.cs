﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaslovaT_task6_practice2024
{
    public partial class endingYouLost : Form
    {
        public endingYouLost()
        {
            InitializeComponent();
        }

        private void btRestart_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Restart();
        }
    }
}
