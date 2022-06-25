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
    public partial class pegawai : Form
    {
        public pegawai()
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
            NpgsqlCommand cmd = new NpgsqlCommand("select * from pegawai order by id_pegawai", con);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            datapegawai.DataSource = dt;
        }

        private void datapegawai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idp.Text = datapegawai.CurrentRow.Cells[0].Value.ToString();
            nama.Text = datapegawai.CurrentRow.Cells[1].Value.ToString();
            nomor.Text = datapegawai.CurrentRow.Cells[2].Value.ToString();
            DateTime dt1 = Convert.ToDateTime(datapegawai.CurrentRow.Cells[3].Value);
            tgl_lahir.Text = dt1.ToString("yyyy-MM-dd");
            DateTime dt2 = Convert.ToDateTime(datapegawai.CurrentRow.Cells[4].Value);
            tgl_rekrut.Text = dt2.ToString("yyyy-MM-dd");
            alamat.Text = datapegawai.CurrentRow.Cells[5].Value.ToString();
            ida.Text = datapegawai.CurrentRow.Cells[6].Value.ToString();

        }

        private void btntambah_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlConnection conn = koneksi();
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("insert into pegawai values ('" + idp.Text + "','" + nama.Text + "','" + nomor.Text + "','" + tgl_lahir.Text + "','" + tgl_rekrut.Text + "', '" + alamat.Text + "', '" + ida.Text + "')", conn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
                load_data();
                idp.Text = " ";
                nama.Text = " ";
                nomor.Text = " ";
                tgl_lahir.Text = " ";
                tgl_rekrut.Text = " ";
                alamat.Text = " ";
                ida.Text = " ";
                MessageBox.Show("berhasil menambah pegawai");

            }
            catch (Exception)
            {
                MessageBox.Show("gagal menambah pegawai");
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlConnection conn = koneksi();
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("update pegawai set nama_pegawai = '" + nama.Text + "',nomor_telepon = '" + nomor.Text + "', tanggal_lahir = '" + tgl_lahir.Text + "', tanggal_rekrut = '" + tgl_rekrut.Text + "', alamat = '" +alamat.Text + "', id_akun = '" + ida.Text + "' where id_pegawai = @id_pegawai ", conn);
                cmd.Parameters.AddWithValue("@id_pegawai", int.Parse(idp.Text));
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
                load_data();
                idp.Text = " ";
                nama.Text = " ";
                nomor.Text = " ";
                tgl_lahir.Text = " ";
                tgl_rekrut.Text = " ";
                alamat.Text = " ";
                ida.Text = " ";
                MessageBox.Show("berhasil mengedit pegawai");
            }
            catch (Exception)
            {
                MessageBox.Show("gagal mengedit pegawai");
            }
        }

        private void btnhapus_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlConnection conn = koneksi();
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("delete from pegawai where id_pegawai = @id_pegawai", conn);
                cmd.Parameters.AddWithValue("@id_pegawai", int.Parse(idp.Text));
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
                load_data();
                idp.Text = " ";
                nama.Text = " ";
                nomor.Text = " ";
                tgl_lahir.Text = " ";
                tgl_rekrut.Text = " ";
                alamat.Text = " ";
                ida.Text = " ";
                MessageBox.Show("berhasil menghapus pegawai");
            }
            catch (Exception)
            {
                MessageBox.Show("gagal menghapus pegawai");
            }
        }

        private void pegawai_Load(object sender, EventArgs e)
        {
            datapegawai.Columns[3].DefaultCellStyle.Format = "yyyy-MM-dd";
            datapegawai.Columns[4].DefaultCellStyle.Format = "yyyy-MM-dd";
        }
    }
}
