using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasBesar.controller
{
    internal class CekRegister
    {

        Koneksi koneksi = new Koneksi();

        public bool Insert(model.M_register register)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("INSERT INTO t_regiss (nama,username,password) VALUES('" + register.Nama + "', '" + register.Username + "', '" + register.Password + "' )");
                status = true;
                MessageBox.Show("REGISTER BERHASIL", "Informasi",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, " REGISTER GAGAL", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
            return status;
        }
    }
}
