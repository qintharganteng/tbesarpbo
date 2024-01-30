using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TugasBesar.model;

namespace TugasBesar.controller
{
    internal class Pelanggan
    {
        //memanggil class dan membuat objek bary
        Koneksi koneksi = new Koneksi();

        //method insert
        public bool Insert(M_Pelanggan pelanggan)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("INSERT INTO t_pelanggann ( nama, alamat, email, nohp) VALUES('" +
                pelanggan.Nama + "','"  + pelanggan.Alamat +
                "','" + pelanggan.Email + "','" + pelanggan.Nohp + "')");
                status = true;
                MessageBox.Show("Data berhasil ditambahkan", "Informasi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal Insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }

        //method Update
        public bool Update(M_Pelanggan pelanggan, string id_pelanggan)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("UPDATE t_pelanggann SET nama='" + pelanggan.Nama + "'," + "alamat='" + pelanggan.Alamat + "'," + "email='" + pelanggan.Email + "'," + "nohp='" + pelanggan.Nohp + "' WHERE id_pelanggan = '" + id_pelanggan + "'");
                status = true;
                MessageBox.Show("Data berhasil diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }

        //method Delete
        public bool Delete(string id_pelanggan)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("DELETE FROM t_pelanggann WHERE id_pelanggan='" + id_pelanggan + "'");
                status = true;
                MessageBox.Show("Data berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal Hapus", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }

    }
}

