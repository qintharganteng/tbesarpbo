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
            Koneksi koneksi = new Koneksi();
            M_Pelanggan m_pgl = new M_Pelanggan();

            public void Tampil()
            {
                string query = "SELECT*FROM t_pelanggann";
                //Query DB Get MGS
                DataPelanggan.DataSource = koneksi.ShowData(query);
            }

            public Form1()
            {
                InitializeComponent();
            }

            public void ResetForm()
            {
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
      
        }

        private void btnUbah_Click_1(object sender, EventArgs e)
        {
           

            
        }

        private void btnHapus_Click_1(object sender, EventArgs e)
        {
        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void DataPelanggan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataPelanggan_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
 
           
        }

        private void tbpelanggan_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbCariData_TextChanged(object sender, EventArgs e)
        {
            DataPelanggan.DataSource = koneksi.ShowData("SELECT * FROM t_pelanggann WHERE id_pelanggan LIKE '%' '" + tbCariData.Text + "' '%' OR nama LIKE '%' '" + tbCariData.Text + "' '%' OR alamat LIKE '%' '" + tbCariData.Text + "' '%' OR email LIKE '%' '" + tbCariData.Text + "' '%' OR nohp LIKE '%' '" + tbCariData.Text + "'");
        }
    }
    }



    
