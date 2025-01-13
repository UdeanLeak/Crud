using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dataSiswa.controller
{
    internal class login
    {
        Koneksi jem = new Koneksi();

        public bool check_login(string username, string password)
        {
            try
            {
                jem.OpenConnection();
                MySqlDataReader bac = jem.baca("SELECT * FROM admin WHERE nama='" + username + "'AND password='" + password + "'");
                if (bac.Read())
                {
                    jem.CloseConnection();
                    return true;
                }
                else
                {
                    jem.CloseConnection();
                    return false;
                }
            }
            catch (Exception e) 
            {
                MessageBox.Show(e.Message, "gagal");
            }
            return false;
        }
    }
}
