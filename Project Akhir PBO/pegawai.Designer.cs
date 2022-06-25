namespace Projek_Pbo
{
    partial class pegawai
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
            this.datapegawai = new System.Windows.Forms.DataGridView();
            this.btntambah = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnhapus = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ida = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.alamat = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tgl_rekrut = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tgl_lahir = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nama = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.idp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.nomor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datapegawai)).BeginInit();
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
            // datapegawai
            // 
            this.datapegawai.AllowUserToAddRows = false;
            this.datapegawai.AllowUserToDeleteRows = false;
            this.datapegawai.AllowUserToResizeColumns = false;
            this.datapegawai.AllowUserToResizeRows = false;
            this.datapegawai.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.datapegawai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datapegawai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datapegawai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.datapegawai.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.datapegawai.Location = new System.Drawing.Point(163, 33);
            this.datapegawai.Name = "datapegawai";
            this.datapegawai.ReadOnly = true;
            this.datapegawai.RowHeadersVisible = false;
            this.datapegawai.RowHeadersWidth = 45;
            this.datapegawai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datapegawai.Size = new System.Drawing.Size(653, 173);
            this.datapegawai.TabIndex = 15;
            this.datapegawai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datapegawai_CellClick);
            // 
            // btntambah
            // 
            this.btntambah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(55)))));
            this.btntambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntambah.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntambah.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btntambah.Location = new System.Drawing.Point(598, 282);
            this.btntambah.Name = "btntambah";
            this.btntambah.Size = new System.Drawing.Size(115, 35);
            this.btntambah.TabIndex = 16;
            this.btntambah.Text = "Tambah";
            this.btntambah.UseVisualStyleBackColor = false;
            this.btntambah.Click += new System.EventHandler(this.btntambah_Click);
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(55)))));
            this.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnedit.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnedit.Location = new System.Drawing.Point(598, 364);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(115, 35);
            this.btnedit.TabIndex = 17;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnhapus
            // 
            this.btnhapus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(55)))));
            this.btnhapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhapus.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhapus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnhapus.Location = new System.Drawing.Point(598, 446);
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
            this.panel5.Location = new System.Drawing.Point(300, 525);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(178, 1);
            this.panel5.TabIndex = 30;
            // 
            // ida
            // 
            this.ida.BackColor = System.Drawing.SystemColors.Control;
            this.ida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ida.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ida.ForeColor = System.Drawing.SystemColors.MenuText;
            this.ida.Location = new System.Drawing.Point(300, 500);
            this.ida.Name = "ida";
            this.ida.Size = new System.Drawing.Size(178, 19);
            this.ida.TabIndex = 26;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(55)))));
            this.panel4.Location = new System.Drawing.Point(300, 480);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(178, 1);
            this.panel4.TabIndex = 31;
            // 
            // alamat
            // 
            this.alamat.BackColor = System.Drawing.SystemColors.Control;
            this.alamat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.alamat.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alamat.ForeColor = System.Drawing.SystemColors.MenuText;
            this.alamat.Location = new System.Drawing.Point(300, 455);
            this.alamat.Name = "alamat";
            this.alamat.Size = new System.Drawing.Size(178, 19);
            this.alamat.TabIndex = 27;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(55)))));
            this.panel3.Location = new System.Drawing.Point(300, 436);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(178, 1);
            this.panel3.TabIndex = 32;
            // 
            // tgl_rekrut
            // 
            this.tgl_rekrut.BackColor = System.Drawing.SystemColors.Control;
            this.tgl_rekrut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tgl_rekrut.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tgl_rekrut.ForeColor = System.Drawing.SystemColors.MenuText;
            this.tgl_rekrut.Location = new System.Drawing.Point(300, 411);
            this.tgl_rekrut.Name = "tgl_rekrut";
            this.tgl_rekrut.Size = new System.Drawing.Size(178, 19);
            this.tgl_rekrut.TabIndex = 28;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(55)))));
            this.panel2.Location = new System.Drawing.Point(300, 394);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(178, 1);
            this.panel2.TabIndex = 33;
            // 
            // tgl_lahir
            // 
            this.tgl_lahir.BackColor = System.Drawing.SystemColors.Control;
            this.tgl_lahir.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tgl_lahir.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tgl_lahir.ForeColor = System.Drawing.SystemColors.MenuText;
            this.tgl_lahir.Location = new System.Drawing.Point(300, 369);
            this.tgl_lahir.Name = "tgl_lahir";
            this.tgl_lahir.Size = new System.Drawing.Size(178, 19);
            this.tgl_lahir.TabIndex = 29;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(55)))));
            this.panel1.Location = new System.Drawing.Point(300, 304);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 1);
            this.panel1.TabIndex = 25;
            // 
            // nama
            // 
            this.nama.BackColor = System.Drawing.SystemColors.Control;
            this.nama.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nama.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nama.ForeColor = System.Drawing.SystemColors.MenuText;
            this.nama.Location = new System.Drawing.Point(300, 279);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(178, 19);
            this.nama.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(55)))));
            this.label5.Location = new System.Drawing.Point(161, 508);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 18);
            this.label5.TabIndex = 23;
            this.label5.Text = "ID Akun";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(55)))));
            this.label4.Location = new System.Drawing.Point(161, 463);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 18);
            this.label4.TabIndex = 22;
            this.label4.Text = "Alamat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(55)))));
            this.label3.Location = new System.Drawing.Point(161, 419);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "Tanggal Rekrut";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(55)))));
            this.label2.Location = new System.Drawing.Point(161, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tanggal Lahir";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(55)))));
            this.label1.Location = new System.Drawing.Point(161, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nama Pegawai";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(55)))));
            this.panel6.Location = new System.Drawing.Point(300, 263);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(178, 1);
            this.panel6.TabIndex = 33;
            // 
            // idp
            // 
            this.idp.BackColor = System.Drawing.SystemColors.Control;
            this.idp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idp.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idp.ForeColor = System.Drawing.SystemColors.MenuText;
            this.idp.Location = new System.Drawing.Point(300, 238);
            this.idp.Name = "idp";
            this.idp.Size = new System.Drawing.Size(178, 19);
            this.idp.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(55)))));
            this.label6.Location = new System.Drawing.Point(161, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 18);
            this.label6.TabIndex = 31;
            this.label6.Text = "ID Pegawai";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(55)))));
            this.panel7.Location = new System.Drawing.Point(300, 347);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(178, 1);
            this.panel7.TabIndex = 36;
            // 
            // nomor
            // 
            this.nomor.BackColor = System.Drawing.SystemColors.Control;
            this.nomor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nomor.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomor.ForeColor = System.Drawing.SystemColors.MenuText;
            this.nomor.Location = new System.Drawing.Point(300, 322);
            this.nomor.Name = "nomor";
            this.nomor.Size = new System.Drawing.Size(178, 19);
            this.nomor.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(55)))));
            this.label7.Location = new System.Drawing.Point(161, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 18);
            this.label7.TabIndex = 34;
            this.label7.Text = "No Telepon";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id_pegawai";
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "nama_pegawai";
            this.Column2.HeaderText = "Nama";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 110;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "nomor_telepon";
            this.Column3.HeaderText = "No Telepon";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 110;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "tanggal_lahir";
            this.Column4.HeaderText = "Tanggal Lahir";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 110;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "tanggal_rekrut";
            this.Column5.HeaderText = "Tanggal Rekrut";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 110;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "alamat";
            this.Column6.HeaderText = "Alamat";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 110;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "id_akun";
            this.Column7.HeaderText = "  ID Akun";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 50;
            // 
            // pegawai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 560);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.nomor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.idp);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ida);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.alamat);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.tgl_rekrut);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tgl_lahir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nama);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnhapus);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btntambah);
            this.Controls.Add(this.datapegawai);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "pegawai";
            this.Text = "pegawai";
            this.Load += new System.EventHandler(this.pegawai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datapegawai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView datapegawai;
        private System.Windows.Forms.Button btntambah;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnhapus;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox ida;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox alamat;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tgl_rekrut;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tgl_lahir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox nama;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox idp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox nomor;
        private System.Windows.Forms.Label label7;
    }
}