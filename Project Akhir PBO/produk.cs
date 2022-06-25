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
    public partial class produk : Form
    {
        public produk()
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
            NpgsqlCommand cmd = new NpgsqlCommand("select * from produk order by id_produk", con);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataproduk.DataSource = dt;
        }

        private void dataproduk_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idp.Text = dataproduk.CurrentRow.Cells[0].Value.ToString();
            nama.Text = dataproduk.CurrentRow.Cells[1].Value.ToString();
            harga.Text = dataproduk.CurrentRow.Cells[2].Value.ToString();
            stok.Text = dataproduk.CurrentRow.Cells[3].Value.ToString();
            ids.Text = dataproduk.CurrentRow.Cells[4].Value.ToString();
        }

        private void btntambah_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlConnection conn = koneksi();
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("insert into produk values ('" + idp.Text + "','" + nama.Text + "','" + harga.Text + "','" + stok.Text + "', '" + ids.Text + "')", conn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
                load_data();
                idp.Text = " ";
                nama.Text = " ";
                harga.Text = " ";
                stok.Text = " ";
                ids.Text = " ";
                MessageBox.Show("berhasil menambah produk");

            }
            catch (Exception )
            {
                MessageBox.Show("gagal menambah produk");
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlConnection conn = koneksi();
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("update produk set nama_produk = '" + nama.Text + "', harga = '" + harga.Text + "', stok = '" + stok.Text + "', id_supplier = '" + ids.Text + "' where id_produk = @id_produk ", conn);
                cmd.Parameters.AddWithValue("@id_produk", int.Parse(idp.Text));
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
                load_data();
                idp.Text = " ";
                nama.Text = " ";
                harga.Text = " ";
                stok.Text = " ";
                ids.Text = " ";
                MessageBox.Show("berhasil mengedit produk");
            }
            catch (Exception )
            {
                MessageBox.Show("gagal mengedit produk");
            }
        }

        private void btnhapus_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlConnection conn = koneksi();
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("delete from produk where id_produk = @id_produk", conn);
                cmd.Parameters.AddWithValue("@id_produk", int.Parse(idp.Text)); 
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
                load_data();
                idp.Text = " ";
                nama.Text = " ";
                harga.Text = " ";
                stok.Text = " ";
                ids.Text = " ";
                MessageBox.Show("berhasil menghapus produk");
            }
            catch (Exception )
            {
                MessageBox.Show("gagal menghapus produk");
            }
        }
    }
}
