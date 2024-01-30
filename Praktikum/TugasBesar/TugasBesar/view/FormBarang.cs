using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TugasBesar.controller;
using TugasBesar.model;

namespace TugasBesar.view
{
    public partial class FormBarang : Form
    {
        Koneksi koneksi = new Koneksi();
        M_barang m_barang = new M_barang();
        string id_barang;
        public FormBarang()
        {
            InitializeComponent();
        }

        public void Tampil()
        {
            Databarang.DataSource = koneksi.ShowData("SELECT * FROM t_barangg");
            Databarang.Columns[0].HeaderText = "ID Barang";
            Databarang.Columns[1].HeaderText = "Nama Barang";
            Databarang.Columns[2].HeaderText = "Harga";
            Databarang.Columns[3].HeaderText = "Stok";

        }

        public void resetForm()
        {
            nama_barang.Text = "";
            harga.Text = "";
            caridata.Text = "";
            stok.Text = "";
        }


        private void FormBarang_Load(object sender, EventArgs e)
        {
            Tampil();
        }

        private void Databarang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id_barang = Databarang.Rows[e.RowIndex].Cells[0].Value.ToString();
            nama_barang.Text = Databarang.Rows[e.RowIndex].Cells[1].Value.ToString();
            harga.Text = Databarang.Rows[e.RowIndex].Cells[2].Value.ToString();
            stok.Text = Databarang.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btnsimpan_Click(object sender, EventArgs e)
        {
            if (nama_barang.Text == "" || (nama_barang.Text).All(Char.IsNumber) || harga.Text == "" || (harga.Text).All(Char.IsLetter) || stok.Text == "" || stok.Text.All(Char.IsLetter))
            {
                MessageBox.Show("Isi data dengan benar sebelum dimasukkan!", "Terjadi Kesalahan Insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Barang barang = new Barang();
                m_barang.Nama_barang = nama_barang.Text;
                m_barang.Harga = harga.Text;
                m_barang.Stok = stok.Text;

                barang.Insert(m_barang);
                resetForm();
                Tampil();
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            {
                resetForm();
                Tampil();
            }
        }

        private void btnubah_Click(object sender, EventArgs e)
        {
            if (nama_barang.Text != "" || !nama_barang.Text.All(Char.IsNumber) || harga.Text != "" || !harga.Text.All(Char.IsLetter) || stok.Text != "" || !harga.Text.All(Char.IsLetter))
            {
                Barang barang = new Barang();
                m_barang.Nama_barang = nama_barang.Text;
                m_barang.Harga = harga.Text;

                barang.Update(m_barang, id_barang);
                resetForm();
                Tampil();
            }
            else
            {
                MessageBox.Show("Isi data dengan benar sebelum diperbarui!", "Terjadi Kesalahan Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnhapus_Click(object sender, EventArgs e)
        {
            DialogResult message = MessageBox.Show("Apakah kamu yakin ingin menghapus data ini?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (message == DialogResult.Yes)
            {
                Barang barang = new Barang();
                barang.Delete(id_barang);
                resetForm();
                Tampil();
            }
        }

        private void caridata_TextChanged(object sender, EventArgs e)
        {
            Databarang.DataSource = koneksi.ShowData("SELECT * FROM t_barangg WHERE id_barang LIKE '%' '" + caridata.Text + "' '%' OR nama_barang LIKE '%' '" + caridata.Text + "' '%' OR harga LIKE '%' '" + caridata.Text + "' '%' OR harga LIKE '%' '");
        }

        private string FormatDigitAngka(int number)
        {
            return string.Format("Rp {0:N0}", number);
        }

        private void Databarang_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.Value != null)
            {
                if (int.TryParse(e.Value.ToString(), out int number))
                {
                    e.Value = FormatDigitAngka(number);
                    e.FormattingApplied = true;
                }
            }
        }

       

    }

}
