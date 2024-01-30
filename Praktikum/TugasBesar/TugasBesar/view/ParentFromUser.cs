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
    public partial class ParentFromUser : Form
    {
        public ParentFromUser()
        {
            InitializeComponent();
        }

        private void ParentFromUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dataDiriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUser Formpgl = new FormUser();
            Formpgl.MdiParent = this;
            Formpgl.Show();
        }

        private void ParentFromUser_Load(object sender, EventArgs e)
        {

        }

        private void halamanAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartUp startUp = new StartUp();
            startUp.MdiParent = this;
            startUp.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogin Formpgl = new FormLogin();
            Formpgl.MdiParent = this;
            Formpgl.Show();
        }

        private void barangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTransaksiBarang formbu = new FormTransaksiBarang();
            formbu.MdiParent = this;
            formbu.Show();

        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
