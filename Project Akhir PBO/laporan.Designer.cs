namespace Projek_Pbo
{
    partial class laporan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.datalaporan = new System.Windows.Forms.DataGridView();
            this.btnhapus = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pegawai = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tgl = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.jumlah = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nama = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.idt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datalaporan)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projek_Pbo.Properties.Resources.vegab_1;
            this.pictureBox1.Location = new System.Drawing.Point(37, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // datalaporan
            // 
            this.datalaporan.AllowUserToDeleteRows = false;
            this.datalaporan.AllowUserToResizeColumns = false;
            this.datalaporan.AllowUserToResizeRows = false;
            this.datalaporan.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.datalaporan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datalaporan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datalaporan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.datalaporan.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.datalaporan.Location = new System.Drawing.Point(198, 33);
            this.datalaporan.Name = "datalaporan";
            this.datalaporan.ReadOnly = true;
            this.datalaporan.RowHeadersVisible = false;
            this.datalaporan.RowHeadersWidth = 45;
            this.datalaporan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datalaporan.Size = new System.Drawing.Size(550, 235);
            this.datalaporan.TabIndex = 15;
            this.datalaporan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datalaporan_CellClick);
            // 
            // btnhapus
            // 
            this.btnhapus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(55)))));
            this.btnhapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhapus.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhapus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnhapus.Location = new System.Drawing.Point(599, 369);
            this.btnhapus.Name = "btnhapus";
            this.btnhapus.Size = new System.Drawing.Size(115, 35);
            this.btnhapus.TabIndex = 18;
            this.btnhapus.Text = "Hapus";
            this.btnhapus.UseVisualStyleBackColor = false;
            this.btnhapus.Click += new System.EventHandler(this.btnhapus_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(55)))));
            this.panel5.Location = new System.Drawing.Point(335, 492);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(178, 1);
            this.panel5.TabIndex = 30;
            // 
            // pegawai
            // 
            this.pegawai.BackColor = System.Drawing.SystemColors.Control;
            this.pegawai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pegawai.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pegawai.ForeColor = System.Drawing.SystemColors.MenuText;
            this.pegawai.Location = new System.Drawing.Point(335, 467);
            this.pegawai.Name = "pegawai";
            this.pegawai.Size = new System.Drawing.Size(178, 19);
            this.pegawai.TabIndex = 26;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(55)))));
            this.panel4.Location = new System.Drawing.Point(335, 447);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(178, 1);
            this.panel4.TabIndex = 31;
            // 
            // tgl
            // 
            this.tgl.BackColor = System.Drawing.SystemColors.Control;
            this.tgl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tgl.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tgl.ForeColor = System.Drawing.SystemColors.MenuText;
            this.tgl.Location = new System.Drawing.Point(335, 422);
            this.tgl.Name = "tgl";
            this.tgl.Size = new System.Drawing.Size(178, 19);
            this.tgl.TabIndex = 27;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(55)))));
            this.panel3.Location = new System.Drawing.Point(335, 403);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(178, 1);
            this.panel3.TabIndex = 32;
            // 
            // jumlah
            // 
            this.jumlah.BackColor = System.Drawing.SystemColors.Control;
            this.jumlah.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.jumlah.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jumlah.ForeColor = System.Drawing.SystemColors.MenuText;
            this.jumlah.Location = new System.Drawing.Point(335, 378);
            this.jumlah.Name = "jumlah";
            this.jumlah.Size = new System.Drawing.Size(178, 19);
            this.jumlah.TabIndex = 28;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(55)))));
            this.panel2.Location = new System.Drawing.Point(335, 361);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(178, 1);
            this.panel2.TabIndex = 33;
            // 
            // nama
            // 
            this.nama.BackColor = System.Drawing.SystemColors.Control;
            this.nama.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nama.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nama.ForeColor = System.Drawing.SystemColors.MenuText;
            this.nama.Location = new System.Drawing.Point(335, 336);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(178, 19);
            this.nama.TabIndex = 29;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(55)))));
            this.panel1.Location = new System.Drawing.Point(335, 320);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 1);
            this.panel1.TabIndex = 25;
            // 
            // idt
            // 
            this.idt.BackColor = System.Drawing.SystemColors.Control;
            this.idt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idt.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idt.ForeColor = System.Drawing.SystemColors.MenuText;
            this.idt.Location = new System.Drawing.Point(335, 295);
            this.idt.Name = "idt";
            this.idt.Size = new System.Drawing.Size(178, 19);
            this.idt.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(55)))));
            this.label5.Location = new System.Drawing.Point(196, 475);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 18);
            this.label5.TabIndex = 23;
            this.label5.Text = "Pegawai";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(55)))));
            this.label4.Location = new System.Drawing.Point(196, 430);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 18);
            this.label4.TabIndex = 22;
            this.label4.Text = "Tanggal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(55)))));
            this.label3.Location = new System.Drawing.Point(196, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "Jumlah";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(55)))));
            this.label2.Location = new System.Drawing.Point(196, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nama Produk";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(55)))));
            this.label1.Location = new System.Drawing.Point(196, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "ID Transaksi";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id_transaksi";
            this.Column1.HeaderText = "     ID Transaksi";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 65;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "nama_produk";
            this.Column2.HeaderText = "Produk";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 110;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "jumlah";
            this.Column3.HeaderText = "Jumlah";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 110;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "tanggal_transaksi";
            this.Column4.HeaderText = "Tanggal";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 120;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "nama_pegawai";
            this.Column5.HeaderText = "Pegawai";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 120;
            // 
            // laporan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 519);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.pegawai);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.tgl);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.jumlah);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.nama);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.idt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnhapus);
            this.Controls.Add(this.datalaporan);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "laporan";
            this.Text = "laporan";
            this.Load += new System.EventHandler(this.laporan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datalaporan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView datalaporan;
        private System.Windows.Forms.Button btnhapus;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox pegawai;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tgl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox jumlah;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox nama;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox idt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}