using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace TugasBesar.model
{
    internal class M_barang
    {
        string  nama_barang, harga, stok;
        public M_barang()
        {
        }

        public M_barang(string nama_barang, string harga, string stok)

        {
            this.Nama_barang = nama_barang;
            this.Harga = harga;
            this.Stok = stok;
        }
        public string Nama_barang
        {
            get => nama_barang; set => nama_barang =
       value;
        }
        public string Harga { get => harga; set => harga = value; }     
        public string Stok { get => stok; set => stok = value; }
      
    }
}
