using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projek_Pbo
{
    public partial class Home_owner : Form
    {
        public Home_owner()
        {
            InitializeComponent();
        }
        public void loadform(object Form)
        {
            if (this.panelutama.Controls.Count > 0)
                this.panelutama.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelutama.Controls.Add(f);
            this.panelutama.Tag = f;
            f.Show();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void produkBTN_Click(object sender, EventArgs e)
        {
            loadform(new produk());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadform(new supplier());
        }
        private void button2_Click(object sender, EventArgs e)
        {
            loadform(new laporan());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadform(new pegawai());
        }

    }
}
