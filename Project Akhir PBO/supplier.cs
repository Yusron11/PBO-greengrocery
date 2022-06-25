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
    public partial class supplier : Form
    {
        public supplier()
        {
            InitializeComponent();
            load_data();
        }
        private static NpgsqlConnection koneksi()
        {
            return new NpgsqlConnection("server = localhost; port = 5432; username = postgres; password = yourpassword; database = pbo;");
        }
        void load_data()
        {
            NpgsqlConnection con = koneksi();
            con.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("select * from supplier order by id_supplier", con);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            datasupplier.DataSource = dt;
        }


        private void datasupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ids.Text = datasupplier.CurrentRow.Cells[0].Value.ToString();
            nama.Text = datasupplier.CurrentRow.Cells[1].Value.ToString();
            nomor.Text = datasupplier.CurrentRow.Cells[2].Value.ToString();
            alamat.Text = datasupplier.CurrentRow.Cells[3].Value.ToString();
        }

        private void btntambah_Click_1(object sender, EventArgs e)
        {
            try
            {
                NpgsqlConnection conn = koneksi();
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("insert into supplier values ('" + ids.Text + "','" + nama.Text + "','" + nomor.Text + "','" + alamat.Text + "')", conn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
                load_data();
                ids.Text = " ";
                nama.Text = " ";
                nomor.Text = " ";
                alamat.Text = " ";
                ids.Text = " ";
                MessageBox.Show("berhasil menambah produk");

            }
            catch (Exception)
            {
                MessageBox.Show("gagal menambah produk");
            }
        }

        private void btnedit_Click_1(object sender, EventArgs e)
        {
            try
            {
                NpgsqlConnection conn = koneksi();
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("update supplier set nama_supplier = '" + nama.Text + "', nomor_telepon = '" + nomor.Text + "', alamat = '" + alamat.Text + "' where id_supplier = @id_supplier ", conn);
                cmd.Parameters.AddWithValue("@id_supplier", int.Parse(ids.Text));
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
                load_data();
                ids.Text = " ";
                nama.Text = " ";
                nomor.Text = " ";
                alamat.Text = " ";
                ids.Text = " ";
                MessageBox.Show("berhasil mengedit produk");
            }
            catch (Exception)
            {
                MessageBox.Show("gagal mengedit produk");
            }
        }

        private void btnhapus_Click_1(object sender, EventArgs e)
        {
            try
            {
                NpgsqlConnection conn = koneksi();
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("delete from supplier where id_supplier = @id_supplier", conn);
                cmd.Parameters.AddWithValue("@id_supplier", int.Parse(ids.Text));
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
                load_data();
                ids.Text = " ";
                nama.Text = " ";
                nomor.Text = " ";
                alamat.Text = " ";
                ids.Text = " ";
                MessageBox.Show("berhasil menghapus produk");
            }
            catch (Exception)
            {
                MessageBox.Show("gagal menghapus produk");
            }
        }
    }
}
