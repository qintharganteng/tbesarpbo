﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasBesar.view
{
    public partial class StartUpUser : Form
    {
        public StartUpUser()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 1;
            if (progressBar1.Value == 100)
            {
                timer1.Dispose();
                Close();
            }
        }

        private void StartUpUser_Load(object sender, EventArgs e)
        {

        }
    }
}
