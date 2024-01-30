using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasBesar.model
{
    internal class M_transaksi_barang
    {
        string id_transaksi, id_barang, qty, total;

        public M_transaksi_barang()
        {

        }

        public M_transaksi_barang(string id_transaski , string id_barang, string qty, string total)
        {
            string Id_transasksi = id_transaksi;
            this.Id_barang = id_barang;
            this.Qty = qty;
            this.Total = total;
        }

        public string Id_transaksi
        {
            get => id_transaksi; set => id_transaksi = value;
        }
        public string Id_barang
        {
            get => id_barang; set => id_barang = value;
        }

        public string Qty
        {
            get => qty; set => qty = value;
        }

        public string Total
        {
            get => total; set => total = value;
        }
    }
}
