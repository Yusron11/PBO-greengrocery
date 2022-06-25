using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using NpgsqlTypes;

namespace Projek_Pbo
{
    public partial class masuk : Form
    {
        public masuk()
        {
            InitializeComponent();
        }
        private static NpgsqlConnection koneksi()
        {
            return new NpgsqlConnection("server = localhost; port = 5432; username = postgres; password = yourpassword; database = pbo;");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            daftar fm = new daftar();
            fm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = koneksi();
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("select * from akun where username = '"+user.Text+ "' and password = '" + pass.Text + "'", conn);
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            DataTable dt = new DataTable();
            NpgsqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                if (dr[5].ToString() == "owner")
                {
                    Home_owner own = new Home_owner();
                    own.Show();
                    conn.Close();
                    this.Hide();
                }
                else
                {
                    Home_pegawai pgw = new Home_pegawai();
                    pgw.Show();
                    conn.Close();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("username / password salah");
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
