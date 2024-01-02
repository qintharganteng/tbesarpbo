using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using TugasBesar.controller;
using TugasBesar.model;

namespace TugasBesar
{ 
        public partial class Form1 : Form
        {
            koneksi koneksi = new koneksi();
            M_Pelanggan m_pgl = new M_Pelanggan();

            public void Tampil()
            {
                string query = "SELECT*FROM t_pelanggan";
                //Query DB Get MGS
                DataPelanggan.DataSource = koneksi.ShowData(query);
            }

            public Form1()
            {
                InitializeComponent();
            }

            public void ResetForm()
            {
                tbpelanggan.Text = "";
                tbnama.Text = "";
                tbalamat.Text = "";
                tbemail.Text = "";
                tbnohp.Text = "";
                tbCariData.Text = "";
            }


            private void Form1_Load(object sender, EventArgs e)
            {
                //Memanggil method Tampil
                Tampil();

                //Mengubah Nama Kolom Table
                DataPelanggan.Columns[0].HeaderText = "ID Pelanggan";
                DataPelanggan.Columns[1].HeaderText = "Nama";
                DataPelanggan.Columns[2].HeaderText = "Alamat";
                DataPelanggan.Columns[3].HeaderText = "Email";
                DataPelanggan.Columns[4].HeaderText = "No HP";
            }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnSimpan_Click_1(object sender, EventArgs e)
        {
            if (tbpelanggan.Text == "" || tbnama.Text == "" || tbalamat.Text == "" || tbemail.Text == "" || tbnohp.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Pelanggan pgl = new Pelanggan();
                m_pgl.Id_pelanggan = tbpelanggan.Text;
                m_pgl.Nama = tbnama.Text;
                m_pgl.Alamat = tbalamat.Text;
                m_pgl.Email = tbemail.Text;
                m_pgl.Nohp = tbnohp.Text;

                pgl.Insert(m_pgl);

                ResetForm();
                Tampil();


            }
        }

        private void btnUbah_Click_1(object sender, EventArgs e)
        {
            if (tbpelanggan.Text == "" || tbnama.Text == "" || tbalamat.Text == "" || tbemail.Text == "" || tbnohp.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                controller.Pelanggan pgl = new controller.Pelanggan();
                m_pgl.Id_pelanggan = tbpelanggan.Text;
                m_pgl.Nama = tbnama.Text;
                m_pgl.Alamat = tbalamat.Text;
                m_pgl.Email = tbemail.Text;
                m_pgl.Nohp = tbnohp.Text;

                string id_pelanggan = tbpelanggan.Text;
                pgl.Update(m_pgl, id_pelanggan);

                ResetForm();
                Tampil();

            }
        }

        private void btnHapus_Click_1(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show("Apakah anda yakin akan menghapus data ini?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (pesan == DialogResult.Yes)
            {
                Pelanggan pgl = new Pelanggan();
                pgl.Delete(tbpelanggan.Text);
                ResetForm();
                Tampil();
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void DataPelanggan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataPelanggan_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < DataPelanggan.Rows.Count)
            {
                tbpelanggan.Text = DataPelanggan.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbnama.Text = DataPelanggan.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbalamat.Text = DataPelanggan.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbemail.Text = DataPelanggan.Rows[e.RowIndex].Cells[3].Value.ToString();
                tbnohp.Text = DataPelanggan.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
           
        }
    }
    }



    
