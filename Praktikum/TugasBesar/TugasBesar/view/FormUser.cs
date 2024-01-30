using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TugasBesar.controller;
using TugasBesar.model;

namespace TugasBesar.view
{
    public partial class FormUser : Form
    {
        Koneksi koneksi = new Koneksi();
        M_Pelanggan m_pgl = new M_Pelanggan();

        public FormUser()
        {
            InitializeComponent();
        }

        public void ResetForm()
        {
            tbnama.Text = "";
            tbalamat.Text = "";
            tbemail.Text = "";
            tbnohp.Text = "";
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if ( tbnama.Text == "" || tbalamat.Text == "" || tbemail.Text == "" || tbnohp.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Pelanggan pgl = new Pelanggan();
                m_pgl.Nama = tbnama.Text;
                m_pgl.Alamat = tbalamat.Text;
                m_pgl.Email = tbemail.Text;
                m_pgl.Nohp = tbnohp.Text;

                pgl.Insert(m_pgl);

                ResetForm();

            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if ( tbnama.Text == "" || tbalamat.Text == "" || tbemail.Text == "" || tbnohp.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                controller.Pelanggan pgl = new controller.Pelanggan();
                m_pgl.Nama = tbnama.Text;
                m_pgl.Alamat = tbalamat.Text;
                m_pgl.Email = tbemail.Text;
                m_pgl.Nohp = tbnohp.Text;

       

                ResetForm();

            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show("Apakah anda yakin akan menghapus data ini?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (pesan == DialogResult.Yes)
            {
                ResetForm();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormUser_Load(object sender, EventArgs e)
        {

        }
    }
}

