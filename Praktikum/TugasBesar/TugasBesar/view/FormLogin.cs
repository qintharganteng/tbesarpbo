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

namespace TugasBesar.view
{
    public partial class FormLogin : Form
    {
        CekLogin login = new CekLogin();
        CekLoginUser loginn = new CekLoginUser();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "" || tbPassword.Text == "")
            {
                MessageBox.Show("Username dan Password tidak boleh kosong !!");
            }
            else
            {
                string username = tbUsername.Text;
                string password = tbPassword.Text;

                bool status = login.cek_login(username, password);
                if (status)
                {
                    MessageBox.Show("LOGIN BERHASIL", "BERHASIL");
                    ParentFrom form = new ParentFrom();
                    form.Show();
                }
                else
                {
                    MessageBox.Show("GAGAL LOGIN", "GAGAL");
                }
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "" || tbPassword.Text == "")
            {
                MessageBox.Show("Username dan Password tidak boleh kosong !!");
            }
            else
            {
                string username = tbUsername.Text;
                string password = tbPassword.Text;

                bool status = loginn.cek_login(username, password);
                if (status)
                {
                    MessageBox.Show("LOGIN BERHASIL", "BERHASIL");
                    ParentFromUser hehe = new ParentFromUser();
                    this.Hide();
                    hehe.Show();
                }
                else
                {
                    MessageBox.Show("GAGAL LOGIN", "GAGAL");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormRegister formregis = new FormRegister();
            this.Hide();
            formregis.Show();
        }
    }
}
