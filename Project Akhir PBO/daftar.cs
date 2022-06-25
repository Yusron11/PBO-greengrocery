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

namespace Projek_Pbo
{
    public partial class daftar : Form
    {
        public daftar()
        {
            InitializeComponent();
        }
        private static NpgsqlConnection koneksi()
        {
            return new NpgsqlConnection(@"server=localhost;port=5432;user id=postgres;password=yourpassword;database=pbo;");
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            masuk fm = new masuk();
            fm.Show();
            this.Close();
        }

        private void btndaftar_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlConnection conn = koneksi();
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("insert into akun (nama_depan,nama_belakang,username,password,role) values ('"+Fname.Text+"','"+Lname.Text+"','"+username.Text+"','"+pw.Text+"', 'pegawai')", conn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
                MessageBox.Show("berhasil membuat akun");

                masuk fm = new masuk();
                fm.Show();
                this.Hide();
            }
            catch (Exception )
            {
                MessageBox.Show("gagal membuat akun");
            }
        }
    }
}
