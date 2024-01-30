using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TugasBesar.model;

namespace TugasBesar.controller
{
    internal class Barang
    {
        Koneksi koneksi = new Koneksi();

        //Method insert
        public bool Insert(model.M_barang barang)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("INSERT INTO t_barangg (nama_barang,harga,stok) VALUES('" + barang.Nama_barang + "', '" + barang.Harga + "', '" + barang.Stok + "' )");
                status = true;
                MessageBox.Show("Data berhasil ditambahkan", "Informasi",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
            return status;
        }

        //Method update
        public bool Update(M_barang barang, string id)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("UPDATE t_barangg SET nama_barang='" +
               barang.Nama_barang + "'," + "harga='" + barang.Harga + "' WHERE id_barang = '" + id + "'");

                status = true;
                MessageBox.Show("Data berhasil diubah", "Informasi",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
            return status;
        }

        //Method delete
        public bool Delete(string id)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("DELETE FROM t_barangg WHERE id_barang='"
               + id + "'");
                status = true;
                MessageBox.Show("Data berhasil dihapus", "Informasi",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
            return status;

        }
    }
}
