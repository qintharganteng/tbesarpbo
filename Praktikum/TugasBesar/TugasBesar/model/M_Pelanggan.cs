using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasBesar.model
{
    internal class M_Pelanggan
    {
        string id_pelanggan, nama, alamat, email, nohp;
        private string id;

        public M_Pelanggan()
        {

        }

        public M_Pelanggan(string id_pelanggan, string nama, string alamat, string email, string nohp)
        {
            this.id_pelanggan = id_pelanggan;
            this.Nama = nama;
            this.Alamat = alamat;
            this.Email = email;
            this.Nohp = nohp;
        }

        public string Id_pelanggan { get => id_pelanggan; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Alamat { get => alamat; set => alamat = value; }
        public string Email { get => email; set => email = value; }
        public string Nohp { get => nohp; set => nohp = value; }
    }
}

