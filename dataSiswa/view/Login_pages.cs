using dataSiswa.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dataSiswa.view
{
    public partial class Login_pages : Form
    {
        login lg = new login();

        public Login_pages()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (namebox.Text == "" || passbox.Text == "")
            {
                MessageBox.Show("Username dan Password tidak boleh kosong!", "GAGAL");
            }
            else
            {
                string username = namebox.Text;
                string password = passbox.Text;

                bool status = lg.check_login(username, password);
                if (status)
                {
                    MessageBox.Show("Login Berhasil","berhasil");
                    Form1 main = new Form1();
                    main.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Periksa kembali Username dan Password anda!", "Gagal");
                }
            }
        }

        private void namebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
