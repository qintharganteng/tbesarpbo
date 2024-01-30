using System;
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
    public partial class StartUp : Form
    {
        public StartUp()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ParentFrom frm = new ParentFrom();
            progressBar1.Value += 3;
            if (progressBar1.Value == 100)
            { 
                timer1.Dispose();
                Close();
                frm.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void StartUp_Load(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
