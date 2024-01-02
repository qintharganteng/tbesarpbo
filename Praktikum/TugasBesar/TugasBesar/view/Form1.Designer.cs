namespace TugasBesar
{
    partial class Form1
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
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbCariData = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tbnohp = new System.Windows.Forms.TextBox();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.tbalamat = new System.Windows.Forms.TextBox();
            this.tbnama = new System.Windows.Forms.TextBox();
            this.tbpelanggan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.gBTombolAction = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbPelanggan = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DataPelanggan = new System.Windows.Forms.DataGridView();
            this.gBtablemahasiswa = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.gBTombolAction.SuspendLayout();
            this.gbPelanggan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataPelanggan)).BeginInit();
            this.gBtablemahasiswa.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 55);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Cari Data";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbCariData);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(656, 282);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(490, 117);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Form Pencarian";
            // 
            // tbCariData
            // 
            this.tbCariData.Location = new System.Drawing.Point(100, 51);
            this.tbCariData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCariData.Name = "tbCariData";
            this.tbCariData.Size = new System.Drawing.Size(378, 26);
            this.tbCariData.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(126, 28);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(273, 32);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // tbnohp
            // 
            this.tbnohp.Location = new System.Drawing.Point(142, 285);
            this.tbnohp.Name = "tbnohp";
            this.tbnohp.Size = new System.Drawing.Size(348, 26);
            this.tbnohp.TabIndex = 10;
            // 
            // tbemail
            // 
            this.tbemail.Location = new System.Drawing.Point(142, 235);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(348, 26);
            this.tbemail.TabIndex = 9;
            // 
            // tbalamat
            // 
            this.tbalamat.Location = new System.Drawing.Point(142, 133);
            this.tbalamat.Multiline = true;
            this.tbalamat.Name = "tbalamat";
            this.tbalamat.Size = new System.Drawing.Size(348, 75);
            this.tbalamat.TabIndex = 8;
            // 
            // tbnama
            // 
            this.tbnama.Location = new System.Drawing.Point(142, 86);
            this.tbnama.Name = "tbnama";
            this.tbnama.Size = new System.Drawing.Size(348, 26);
            this.tbnama.TabIndex = 7;
            // 
            // tbpelanggan
            // 
            this.tbpelanggan.Location = new System.Drawing.Point(152, 45);
            this.tbpelanggan.Name = "tbpelanggan";
            this.tbpelanggan.Size = new System.Drawing.Size(348, 26);
            this.tbpelanggan.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "No HP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(126, 165);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(273, 32);
            this.btnHapus.TabIndex = 3;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click_1);
            // 
            // btnUbah
            // 
            this.btnUbah.Location = new System.Drawing.Point(126, 118);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(273, 35);
            this.btnUbah.TabIndex = 2;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = true;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click_1);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(126, 71);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(273, 35);
            this.btnSimpan.TabIndex = 1;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click_1);
            // 
            // gBTombolAction
            // 
            this.gBTombolAction.Controls.Add(this.btnHapus);
            this.gBTombolAction.Controls.Add(this.btnUbah);
            this.gBTombolAction.Controls.Add(this.btnSimpan);
            this.gBTombolAction.Controls.Add(this.btnRefresh);
            this.gBTombolAction.Location = new System.Drawing.Point(656, 415);
            this.gBTombolAction.Name = "gBTombolAction";
            this.gBTombolAction.Size = new System.Drawing.Size(490, 229);
            this.gBTombolAction.TabIndex = 4;
            this.gBTombolAction.TabStop = false;
            this.gBTombolAction.Text = "Tombol Action";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Alamat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama ";
            // 
            // gbPelanggan
            // 
            this.gbPelanggan.Controls.Add(this.tbnohp);
            this.gbPelanggan.Controls.Add(this.tbemail);
            this.gbPelanggan.Controls.Add(this.tbalamat);
            this.gbPelanggan.Controls.Add(this.tbnama);
            this.gbPelanggan.Controls.Add(this.tbpelanggan);
            this.gbPelanggan.Controls.Add(this.label6);
            this.gbPelanggan.Controls.Add(this.label5);
            this.gbPelanggan.Controls.Add(this.label4);
            this.gbPelanggan.Controls.Add(this.label2);
            this.gbPelanggan.Controls.Add(this.label1);
            this.gbPelanggan.Location = new System.Drawing.Point(28, 292);
            this.gbPelanggan.Name = "gbPelanggan";
            this.gbPelanggan.Size = new System.Drawing.Size(496, 352);
            this.gbPelanggan.TabIndex = 5;
            this.gbPelanggan.TabStop = false;
            this.gbPelanggan.Text = "Form Data Pelanggaan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Pelanggan";
            // 
            // DataPelanggan
            // 
            this.DataPelanggan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataPelanggan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataPelanggan.Location = new System.Drawing.Point(0, 25);
            this.DataPelanggan.Name = "DataPelanggan";
            this.DataPelanggan.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DataPelanggan.RowHeadersWidth = 62;
            this.DataPelanggan.RowTemplate.Height = 28;
            this.DataPelanggan.Size = new System.Drawing.Size(1119, 177);
            this.DataPelanggan.TabIndex = 0;
            this.DataPelanggan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataPelanggan_CellClick_1);
            this.DataPelanggan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataPelanggan_CellContentClick);
            // 
            // gBtablemahasiswa
            // 
            this.gBtablemahasiswa.Controls.Add(this.DataPelanggan);
            this.gBtablemahasiswa.Location = new System.Drawing.Point(28, 12);
            this.gBtablemahasiswa.Name = "gBtablemahasiswa";
            this.gBtablemahasiswa.Size = new System.Drawing.Size(1119, 202);
            this.gBtablemahasiswa.TabIndex = 3;
            this.gBtablemahasiswa.TabStop = false;
            this.gBtablemahasiswa.Text = "Table Data Pelanggan";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 667);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gBTombolAction);
            this.Controls.Add(this.gbPelanggan);
            this.Controls.Add(this.gBtablemahasiswa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gBTombolAction.ResumeLayout(false);
            this.gbPelanggan.ResumeLayout(false);
            this.gbPelanggan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataPelanggan)).EndInit();
            this.gBtablemahasiswa.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbCariData;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox tbnohp;
        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.TextBox tbalamat;
        private System.Windows.Forms.TextBox tbnama;
        private System.Windows.Forms.TextBox tbpelanggan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.GroupBox gBTombolAction;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbPelanggan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataPelanggan;
        private System.Windows.Forms.GroupBox gBtablemahasiswa;
    }
}

