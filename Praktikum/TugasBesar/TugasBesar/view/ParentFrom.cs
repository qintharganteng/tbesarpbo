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
    public partial class ParentFrom : Form
    {
        public ParentFrom()
        {
            InitializeComponent();
        }

        private void ParentFrom_Load(object sender, EventArgs e)
        {

        }

        private void dataPelangganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 Formpgl = new Form1();
            Formpgl.MdiParent = this;
            Formpgl.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogin frmlgn = new FormLogin();
            frmlgn.MdiParent = this;
            this.Close();
            frmlgn.Show();
        }

        private void ParentFrom_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void barangToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void stokBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void bARANGToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormBarang form = new FormBarang();
            form.MdiParent = this;
            form.Show();
        }
    }
}
