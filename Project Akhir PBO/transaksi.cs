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
    public partial class transaksi : Form
    {
        public transaksi()
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
            tgl.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void btntambah_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlConnection conn = koneksi();
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("insert into transaksi (tanggal_transaksi,jumlah,id_produk,id_pegawai) values ('" + tgl.Text + "','" + jumlah.Text + "','" + idp.Text + "','" + idpgw.Text + "')", conn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
                load_data();
                idp.Text = " ";
                nama.Text = " ";
                harga.Text = " ";
                tgl.Text = " ";
                jumlah.Text = " ";
                idpgw.Text = " ";
                MessageBox.Show("berhasil menambah transaksi");

            }
            catch (Exception)
            {
                MessageBox.Show("gagal menambah transaksi");
            }
        }
    }
}
