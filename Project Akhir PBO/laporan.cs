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
    public partial class laporan : Form
    {
        public laporan()
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
            NpgsqlCommand cmd = new NpgsqlCommand("select id_transaksi,nama_produk,jumlah,tanggal_transaksi,nama_pegawai from transaksi t, produk p, pegawai pg where p.id_produk=t.id_produk and pg.id_pegawai=t.id_pegawai", con);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            datalaporan.DataSource = dt;
        }

        private void datalaporan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idt.Text = datalaporan.CurrentRow.Cells[0].Value.ToString();
            nama.Text = datalaporan.CurrentRow.Cells[1].Value.ToString();
            jumlah.Text = datalaporan.CurrentRow.Cells[2].Value.ToString();
            DateTime dt1 = Convert.ToDateTime(datalaporan.CurrentRow.Cells[3].Value);
            tgl.Text = dt1.ToString("yyyy-MM-dd");
            pegawai.Text = datalaporan.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnhapus_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlConnection conn = koneksi();
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("delete from transaksi where id_transaksi = @id_transaksi", conn);
                cmd.Parameters.AddWithValue("@id_transaksi", int.Parse(idt.Text));
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
                load_data();
                idt.Text = " ";
                nama.Text = " ";
                jumlah.Text = " ";
                tgl.Text = " ";
                pegawai.Text = " ";
                MessageBox.Show("berhasil menghapus laporan transaksi");
            }
            catch (Exception)
            {
                MessageBox.Show("gagal menghapus laporan transaksi");
            }
        }

        private void laporan_Load(object sender, EventArgs e)
        {
            datalaporan.Columns[3].DefaultCellStyle.Format = "yyyy-MM-dd";
        }
    }
}
