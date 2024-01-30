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
            this.btnHapus = new System.Windows.Forms.Button();
            this.gBTombolAction = new System.Windows.Forms.GroupBox();
            this.DataPelanggan = new System.Windows.Forms.DataGridView();
            this.gBtablemahasiswa = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.gBTombolAction.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(326, 290);
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
            this.tbCariData.TextChanged += new System.EventHandler(this.tbCariData_TextChanged);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(117, 98);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(273, 32);
            this.btnHapus.TabIndex = 3;
            this.btnHapus.Text = "Hapus Data Pelanggan";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click_1);
            // 
            // gBTombolAction
            // 
            this.gBTombolAction.Controls.Add(this.btnHapus);
            this.gBTombolAction.Location = new System.Drawing.Point(326, 415);
            this.gBTombolAction.Name = "gBTombolAction";
            this.gBTombolAction.Size = new System.Drawing.Size(490, 229);
            this.gBTombolAction.TabIndex = 4;
            this.gBTombolAction.TabStop = false;
            this.gBTombolAction.Text = "Tombol Action";
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
            this.BackgroundImage = global::TugasBesar.Properties.Resources._845;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1204, 667);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gBTombolAction);
            this.Controls.Add(this.gBtablemahasiswa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gBTombolAction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataPelanggan)).EndInit();
            this.gBtablemahasiswa.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbCariData;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.GroupBox gBTombolAction;
        private System.Windows.Forms.DataGridView DataPelanggan;
        private System.Windows.Forms.GroupBox gBtablemahasiswa;
    }
}

