namespace TugasBesar.view
{
    partial class FormUser
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
            this.gBTombolAction = new System.Windows.Forms.GroupBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.gbPelanggan = new System.Windows.Forms.GroupBox();
            this.tbnohp = new System.Windows.Forms.TextBox();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.tbalamat = new System.Windows.Forms.TextBox();
            this.tbnama = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gBTombolAction.SuspendLayout();
            this.gbPelanggan.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBTombolAction
            // 
            this.gBTombolAction.BackColor = System.Drawing.Color.Transparent;
            this.gBTombolAction.Controls.Add(this.btnSimpan);
            this.gBTombolAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBTombolAction.Location = new System.Drawing.Point(53, 473);
            this.gBTombolAction.Name = "gBTombolAction";
            this.gBTombolAction.Size = new System.Drawing.Size(490, 126);
            this.gBTombolAction.TabIndex = 7;
            this.gBTombolAction.TabStop = false;
            this.gBTombolAction.Text = "Tombol Action";
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSimpan.Location = new System.Drawing.Point(126, 71);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(273, 35);
            this.btnSimpan.TabIndex = 1;
            this.btnSimpan.Text = "Simpan Data Diri Anda";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // gbPelanggan
            // 
            this.gbPelanggan.BackColor = System.Drawing.Color.Transparent;
            this.gbPelanggan.Controls.Add(this.tbnohp);
            this.gbPelanggan.Controls.Add(this.tbemail);
            this.gbPelanggan.Controls.Add(this.tbalamat);
            this.gbPelanggan.Controls.Add(this.tbnama);
            this.gbPelanggan.Controls.Add(this.label6);
            this.gbPelanggan.Controls.Add(this.label5);
            this.gbPelanggan.Controls.Add(this.label4);
            this.gbPelanggan.Controls.Add(this.label2);
            this.gbPelanggan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPelanggan.Location = new System.Drawing.Point(47, 118);
            this.gbPelanggan.Name = "gbPelanggan";
            this.gbPelanggan.Size = new System.Drawing.Size(496, 324);
            this.gbPelanggan.TabIndex = 8;
            this.gbPelanggan.TabStop = false;
            this.gbPelanggan.Text = "ISI DATA DIRI ANDA";
            // 
            // tbnohp
            // 
            this.tbnohp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tbnohp.Location = new System.Drawing.Point(142, 285);
            this.tbnohp.Name = "tbnohp";
            this.tbnohp.Size = new System.Drawing.Size(348, 28);
            this.tbnohp.TabIndex = 10;
            // 
            // tbemail
            // 
            this.tbemail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tbemail.Location = new System.Drawing.Point(142, 235);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(348, 28);
            this.tbemail.TabIndex = 9;
            // 
            // tbalamat
            // 
            this.tbalamat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tbalamat.Location = new System.Drawing.Point(142, 133);
            this.tbalamat.Multiline = true;
            this.tbalamat.Name = "tbalamat";
            this.tbalamat.Size = new System.Drawing.Size(348, 75);
            this.tbalamat.TabIndex = 8;
            // 
            // tbnama
            // 
            this.tbnama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tbnama.Location = new System.Drawing.Point(142, 86);
            this.tbnama.Name = "tbnama";
            this.tbnama.Size = new System.Drawing.Size(348, 28);
            this.tbnama.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "No HP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Alamat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama ";
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TugasBesar.Properties.Resources.marissa_grootes_flRm0z3MEoA_unsplash__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(607, 704);
            this.Controls.Add(this.gBTombolAction);
            this.Controls.Add(this.gbPelanggan);
            this.Name = "FormUser";
            this.Load += new System.EventHandler(this.FormUser_Load);
            this.gBTombolAction.ResumeLayout(false);
            this.gbPelanggan.ResumeLayout(false);
            this.gbPelanggan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBTombolAction;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.GroupBox gbPelanggan;
        private System.Windows.Forms.TextBox tbnohp;
        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.TextBox tbalamat;
        private System.Windows.Forms.TextBox tbnama;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}