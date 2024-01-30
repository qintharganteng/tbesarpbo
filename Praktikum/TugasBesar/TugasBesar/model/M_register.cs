using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasBesar.model
{
    internal class M_register
    {
        string nama, username, password;

        public M_register()
        {
        }

        public M_register(string nama, string username, string password)
        {
            this.Nama = nama;
            this.Username= username;
            this.Password = password;
        }
        public string Nama
        {
            get => nama; set => nama =
       value;
        }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
    }
}
