using MySqlConnector;
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
    public partial class FormTransaksiBarang : Form
    {

        Koneksi koneksi = new Koneksi();
        string id_transaksi;
        M_transaksi_barang m_transibarang = new M_transaksi_barang();
        M_barang m_Barang = new M_barang();
        M_Pelanggan m_Pelanggan = new M_Pelanggan();
        public void Tampil()
        {
            DataTransaksi.DataSource = koneksi.ShowData("SELECT id_transaksi ,b.id_barang, nama_barang, harga, qty, total FROM t_transaksii t JOIN t_barangg b ON (t.id_barang = b.id_barang)");
            DataTransaksi.Columns[0].HeaderText = "ID Transaksi";
            DataTransaksi.Columns[1].HeaderText = "ID Barang";
            DataTransaksi.Columns[2].HeaderText = "Nama Barang";
            DataTransaksi.Columns[3].HeaderText = "Harga";
            DataTransaksi.Columns[4].HeaderText = "QTY";
            DataTransaksi.Columns[5].HeaderText = "Total Harga";
        }
        public void resetForm()
        {
            cbIDBarang.Text = "";
            tbnamabarang.Text = "";
            tbHargaBarang.Text = "";
            tbQuantity.Text = "";
            tbTotal.Text = "";
            tbCariData.Text = "";
        }



        public void GetDataBarang(int selectIdBarang)
        {
            koneksi.OpenConnection();

            string query = $"SELECT nama_barang, harga FROM t_barangg WHERE id_barang = {selectIdBarang}";
            MySqlDataReader reader = koneksi.reader(query);

            if (reader.Read())
            {
                tbnamabarang.Text = reader["nama_barang"].ToString();
                tbHargaBarang.Text = reader["harga"].ToString();
            }

            reader.Close();
            koneksi.CloseConnection();
        }
        private void TotalHarga()
        {
            if (double.TryParse(tbQuantity.Text, out double qty_barang) && double.TryParse(tbHargaBarang.Text.Replace(".", ""), out double harga_barang))
            {
                double totals = qty_barang * harga_barang;

                string formattedTotal = string.Format("{0:#,##0}", totals);

                tbTotal.Text = formattedTotal;
            }
        }
        public FormTransaksiBarang()
        {
            InitializeComponent();
            tbnamabarang.ReadOnly = true;
            tbnamabarang.Enabled = false;
            tbHargaBarang.Enabled = false;
            tbHargaBarang.ReadOnly = true;
            tbTotal.Enabled = false;
            tbTotal.ReadOnly = true;

            LoadIdBarang();
        }

        public void LoadNama()
        {
            koneksi.OpenConnection();

            string query = "SELECT nama FROM t_pelanggann";
            object dataTable = koneksi.ShowData(query);

            cbIDBarang.DisplayMember = "nama";
            cbIDBarang.ValueMember = "nama";
            cbIDBarang.DataSource = dataTable;

            koneksi.CloseConnection();
        }
        public void LoadIdBarang()
        {
            koneksi.OpenConnection();

            string query = "SELECT id_barang FROM t_barangg";
            object dataTable = koneksi.ShowData(query);

            cbIDBarang.DisplayMember = "id_barang";
            cbIDBarang.ValueMember = "id_barang";
            cbIDBarang.DataSource = dataTable;

            koneksi.CloseConnection();
        }
        private void FormTransaksiBarang_Load(object sender, EventArgs e)
        {
            Tampil();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            resetForm();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if ( cbIDBarang.Text == "" || tbnamabarang.Text == "" || tbHargaBarang.Text == "" || tbQuantity.Text == "" || tbTotal.Text == "" ||  cbIDBarang.Text.Any(Char.IsLetter)  || tbQuantity.Text.Any(Char.IsLetter) || cbIDBarang.SelectedItem == null )
            {
                MessageBox.Show("Form harus diisi dengan benar sebelum disimpan!", "Gagal Menyimpan Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Transaksi tf = new Transaksi();
                m_transibarang.Id_barang = cbIDBarang.Text;
                m_transibarang.Qty = tbQuantity.Text;

                string formattedTotal = tbTotal.Text.Replace("Rp ", "").Replace(",", "");
                if (double.TryParse(formattedTotal, out double numericTotal))
                {
                    m_transibarang.Total = numericTotal.ToString();
                }

                tf.Insert(m_transibarang);
                resetForm();
                Tampil();


            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (cbIDBarang.Text != "" || tbnamabarang.Text != "" || tbHargaBarang.Text != "" || tbQuantity.Text != "" || tbTotal.Text != "" || !cbIDBarang.Text.Any(Char.IsLetter) || !tbQuantity.Text.Any(Char.IsLetter) || cbIDBarang.SelectedItem != null)
            {
                Transaksi tf = new Transaksi();
                m_transibarang.Id_barang = cbIDBarang.Text;
                m_transibarang.Qty = tbQuantity.Text;

                string formattedTotal = tbTotal.Text.Replace("Rp ", "").Replace(",", "");
                if (double.TryParse(formattedTotal, out double numericTotal))
                {
                    m_transibarang.Total = numericTotal.ToString();
                }

                tf.Update(m_transibarang, id_transaksi);
                resetForm();
                Tampil();
            }
            else
            {
                MessageBox.Show("Data harus diisi dengan benar sebelum diperbarui!", "Terjadi Kesalahan Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbCariData_TextChanged(object sender, EventArgs e)
        {
            DataTransaksi.DataSource = koneksi.ShowData("SELECT id_transaksi, b.id_barang, nama_barang, harga, qty, total FROM t_transaksii t JOIN t_barangg b ON (t.id_barang = b.id_barang) WHERE id_transaksi LIKE '%' '" + tbCariData.Text + "' '%' OR t.id_barang LIKE '%' '" + tbCariData.Text + "' '%' OR b.id_barang LIKE '%' '" + tbCariData.Text + "' '%' OR nama_barang LIKE '%' '" + tbCariData.Text + "' '%' OR harga LIKE '%' '" + tbCariData.Text + "' '%' OR qty LIKE '%' '" + tbCariData.Text + "' '%' OR total LIKE '%' '" + tbCariData.Text + "' '%'");
        }

        private void DataTransaksi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_transaksi = DataTransaksi.Rows[e.RowIndex].Cells[0].Value.ToString();
            cbIDBarang.Text = DataTransaksi.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbnamabarang.Text = DataTransaksi.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbHargaBarang.Text = DataTransaksi.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbQuantity.Text = DataTransaksi.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void tbHargaBarang_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbQuantity_TextChanged(object sender, EventArgs e)
        {
            TotalHarga();
        }

        private void tbTotal_TextChanged(object sender, EventArgs e)
        {
            TotalHarga();
        }

        private void cbIDBarang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbIDBarang.SelectedValue != null)
            {
                int selectIdBarang;
                if (int.TryParse(cbIDBarang.SelectedValue.ToString(), out selectIdBarang))
                {
                    GetDataBarang(selectIdBarang);
                }
            }
        }

 

        private void FormatDigit(TextBox textBox)
        {
            if (!string.IsNullOrEmpty(textBox.Text) && textBox.Text.All(char.IsDigit))
            {
                string number = textBox.Text.Replace(".", "");

                number = string.Format("{0:#,##0}", double.Parse(number));

                textBox.Text = number;
                textBox.SelectionStart = textBox.Text.Length;
            }
        }

        private string FormatDigitAngka(int number)
        {
            return string.Format("Rp {0:N0}", number);
        }
        private void DataTransaksi_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.Value != null)
            {
                if (int.TryParse(e.Value.ToString(), out int number))
                {
                    e.Value = FormatDigitAngka(number);
                    e.FormattingApplied = true;
                }
            }

            if (e.ColumnIndex == 5 && e.Value != null)
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
