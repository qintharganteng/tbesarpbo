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
    public partial class FormRegister : Form
    {
        Koneksi koneksi = new Koneksi();
        CekRegister regis = new CekRegister();
        M_register m_Register = new M_register();
        public FormRegister()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (tbNama.Text == "" || (tbNama.Text).All(Char.IsNumber) || tbUsername.Text == "" || (tbUsername.Text).All(Char.IsLetter) || tbPassword.Text == "" || tbPassword.Text.All(Char.IsLetter))
            {
                MessageBox.Show("Isi data dengan benar sebelum dimasukkan, Harus terdapat angka pada Username dan Password! ", "Terjadi Kesalahan Insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CekRegister register  = new CekRegister();
                m_Register.Nama = tbNama.Text;
                m_Register.Username = tbUsername.Text;
                m_Register.Password = tbPassword.Text;

                register.Insert(m_Register);
                FormLogin hehe = new FormLogin();
                this.Hide();
                hehe.Show();


            }
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {
            
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
