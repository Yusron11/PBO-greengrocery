namespace Projek_Pbo
{
    partial class produk
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
            this.dataproduk = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.idp = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nama = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.harga = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.stok = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ids = new System.Windows.Forms.TextBox();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnhapus = new System.Windows.Forms.Button();
            this.btntambah = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataproduk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataproduk
            // 
            this.dataproduk.AllowUserToDeleteRows = false;
            this.dataproduk.AllowUserToResizeColumns = false;
            this.dataproduk.AllowUserToResizeRows = false;
            this.dataproduk.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataproduk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataproduk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataproduk.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataproduk.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataproduk.Location = new System.Drawing.Point(198, 33);
            this.dataproduk.Name = "dataproduk";
            this.dataproduk.ReadOnly = true;
            this.dataproduk.RowHeadersVisible = false;
            this.dataproduk.RowHeadersWidth = 45;
            this.dataproduk.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataproduk.Size = new System.Drawing.Size(551, 235);
            this.dataproduk.TabIndex = 0;
            this.dataproduk.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataproduk_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id_produk";
            this.Column1.HeaderText = "ID Produk";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 110;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "nama_produk";
            this.Column2.HeaderText = "Nama Produk";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 110;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "harga";
            this.Column3.HeaderText = "Harga";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 110;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "stok";
            this.Column4.HeaderText = "Stok";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 110;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "id_supplier";
            this.Column5.HeaderText = "ID Supplier";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 110;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(55)))));
            this.label1.Location = new System.Drawing.Point(194, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Produk";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(55)))));
            this.label2.Location = new System.Drawing.Point(194, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nama Produk";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(55)))));
            this.label3.Location = new System.Drawing.Point(194, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Harga";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(55)))));
            this.label4.Location = new System.Drawing.Point(194, 446);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Stok";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(55)))));
            this.label5.Location = new System.Drawing.Point(194, 491);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "ID Supplier";
            // 
            // idp
            // 
            this.idp.BackColor = System.Drawing.SystemColors.Control;
            this.idp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idp.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idp.ForeColor = System.Drawing.SystemColors.MenuText;
            this.idp.Location = new System.Drawing.Point(333, 311);
            this.idp.Name = "idp";
            this.idp.Size = new System.Drawing.Size(178, 19);
            this.idp.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(55)))));
            this.panel1.Location = new System.Drawing.Point(333, 336);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 1);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(55)))));
            this.panel2.Location = new System.Drawing.Point(333, 377);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(178, 1);
            this.panel2.TabIndex = 9;
            // 
            // nama
            // 
            this.nama.BackColor = System.Drawing.SystemColors.Control;
            this.nama.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nama.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nama.ForeColor = System.Drawing.SystemColors.MenuText;
            this.nama.Location = new System.Drawing.Point(333, 352);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(178, 19);
            this.nama.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(55)))));
            this.panel3.Location = new System.Drawing.Point(333, 419);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(178, 1);
            this.panel3.TabIndex = 9;
            // 
            // harga
            // 
            this.harga.BackColor = System.Drawing.SystemColors.Control;
            this.harga.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.harga.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.harga.ForeColor = System.Drawing.SystemColors.MenuText;
            this.harga.Location = new System.Drawing.Point(333, 394);
            this.harga.Name = "harga";
            this.harga.Size = new System.Drawing.Size(178, 19);
            this.harga.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(55)))));
            this.panel4.Location = new System.Drawing.Point(333, 463);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(178, 1);
            this.panel4.TabIndex = 9;
            // 
            // stok
            // 
            this.stok.BackColor = System.Drawing.SystemColors.Control;
            this.stok.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stok.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stok.ForeColor = System.Drawing.SystemColors.MenuText;
            this.stok.Location = new System.Drawing.Point(333, 438);
            this.stok.Name = "stok";
            this.stok.Size = new System.Drawing.Size(178, 19);
            this.stok.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(55)))));
            this.panel5.Location = new System.Drawing.Point(333, 508);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(178, 1);
            this.panel5.TabIndex = 9;
            // 
            // ids
            // 
            this.ids.BackColor = System.Drawing.SystemColors.Control;
            this.ids.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ids.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ids.ForeColor = System.Drawing.SystemColors.MenuText;
            this.ids.Location = new System.Drawing.Point(333, 483);
            this.ids.Name = "ids";
            this.ids.Size = new System.Drawing.Size(178, 19);
            this.ids.TabIndex = 8;
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(55)))));
            this.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnedit.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnedit.Location = new System.Drawing.Point(598, 386);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(115, 35);
            this.btnedit.TabIndex = 11;
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
            this.btnhapus.TabIndex = 12;
            this.btnhapus.Text = "Hapus";
            this.btnhapus.UseVisualStyleBackColor = false;
            this.btnhapus.Click += new System.EventHandler(this.btnhapus_Click);
            // 
            // btntambah
            // 
            this.btntambah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(199)))), ((int)(((byte)(55)))));
            this.btntambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntambah.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntambah.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btntambah.Location = new System.Drawing.Point(598, 327);
            this.btntambah.Name = "btntambah";
            this.btntambah.Size = new System.Drawing.Size(115, 35);
            this.btntambah.TabIndex = 10;
            this.btntambah.Text = "Tambah";
            this.btntambah.UseVisualStyleBackColor = false;
            this.btntambah.Click += new System.EventHandler(this.btntambah_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projek_Pbo.Properties.Resources.vegab_1;
            this.pictureBox1.Location = new System.Drawing.Point(37, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // produk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(837, 560);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnhapus);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btntambah);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.ids);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.stok);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.harga);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.nama);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.idp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataproduk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "produk";
            this.Text = "produk";
            ((System.ComponentModel.ISupportInitialize)(this.dataproduk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataproduk;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox idp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox nama;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox harga;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox stok;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox ids;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnhapus;
        private System.Windows.Forms.Button btntambah;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}