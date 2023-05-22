namespace b3
{
    partial class FrmMainMenu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnLaporan = new System.Windows.Forms.Button();
            this.btnTransaksi = new System.Windows.Forms.Button();
            this.btnPesanTiket = new System.Windows.Forms.Button();
            this.btnEntriRute = new System.Windows.Forms.Button();
            this.btnEntriPenumpang = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(56)))));
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnLaporan);
            this.panel1.Controls.Add(this.btnTransaksi);
            this.panel1.Controls.Add(this.btnPesanTiket);
            this.panel1.Controls.Add(this.btnEntriRute);
            this.panel1.Controls.Add(this.btnEntriPenumpang);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 591);
            this.panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Bahnschrift", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLogout.Image = global::b3.Properties.Resources.logout;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 542);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(202, 49);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "    Logout";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnLaporan
            // 
            this.btnLaporan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLaporan.FlatAppearance.BorderSize = 0;
            this.btnLaporan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaporan.Font = new System.Drawing.Font("Bahnschrift", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaporan.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLaporan.Image = global::b3.Properties.Resources.report;
            this.btnLaporan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLaporan.Location = new System.Drawing.Point(0, 245);
            this.btnLaporan.Name = "btnLaporan";
            this.btnLaporan.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnLaporan.Size = new System.Drawing.Size(202, 49);
            this.btnLaporan.TabIndex = 5;
            this.btnLaporan.Text = "    Laporan";
            this.btnLaporan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLaporan.UseVisualStyleBackColor = true;
            this.btnLaporan.Click += new System.EventHandler(this.btnLaporan_Click);
            // 
            // btnTransaksi
            // 
            this.btnTransaksi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTransaksi.FlatAppearance.BorderSize = 0;
            this.btnTransaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransaksi.Font = new System.Drawing.Font("Bahnschrift", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransaksi.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTransaksi.Image = global::b3.Properties.Resources.transaction;
            this.btnTransaksi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransaksi.Location = new System.Drawing.Point(0, 196);
            this.btnTransaksi.Name = "btnTransaksi";
            this.btnTransaksi.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnTransaksi.Size = new System.Drawing.Size(202, 49);
            this.btnTransaksi.TabIndex = 4;
            this.btnTransaksi.Text = "    Transaksi";
            this.btnTransaksi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTransaksi.UseVisualStyleBackColor = true;
            this.btnTransaksi.Click += new System.EventHandler(this.btnTransaksi_Click);
            // 
            // btnPesanTiket
            // 
            this.btnPesanTiket.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPesanTiket.FlatAppearance.BorderSize = 0;
            this.btnPesanTiket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesanTiket.Font = new System.Drawing.Font("Bahnschrift", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesanTiket.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPesanTiket.Image = global::b3.Properties.Resources.ticket_machine;
            this.btnPesanTiket.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesanTiket.Location = new System.Drawing.Point(0, 147);
            this.btnPesanTiket.Name = "btnPesanTiket";
            this.btnPesanTiket.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnPesanTiket.Size = new System.Drawing.Size(202, 49);
            this.btnPesanTiket.TabIndex = 3;
            this.btnPesanTiket.Text = "    Pesan Tiket";
            this.btnPesanTiket.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesanTiket.UseVisualStyleBackColor = true;
            this.btnPesanTiket.Click += new System.EventHandler(this.btnPesanTiket_Click);
            // 
            // btnEntriRute
            // 
            this.btnEntriRute.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEntriRute.FlatAppearance.BorderSize = 0;
            this.btnEntriRute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntriRute.Font = new System.Drawing.Font("Bahnschrift", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntriRute.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEntriRute.Image = global::b3.Properties.Resources.add;
            this.btnEntriRute.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntriRute.Location = new System.Drawing.Point(0, 98);
            this.btnEntriRute.Name = "btnEntriRute";
            this.btnEntriRute.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnEntriRute.Size = new System.Drawing.Size(202, 49);
            this.btnEntriRute.TabIndex = 2;
            this.btnEntriRute.Text = "    Entri Rute";
            this.btnEntriRute.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEntriRute.UseVisualStyleBackColor = true;
            this.btnEntriRute.Click += new System.EventHandler(this.btnEntriRute_Click);
            // 
            // btnEntriPenumpang
            // 
            this.btnEntriPenumpang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEntriPenumpang.FlatAppearance.BorderSize = 0;
            this.btnEntriPenumpang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntriPenumpang.Font = new System.Drawing.Font("Bahnschrift", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntriPenumpang.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEntriPenumpang.Image = global::b3.Properties.Resources.add_user;
            this.btnEntriPenumpang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntriPenumpang.Location = new System.Drawing.Point(0, 49);
            this.btnEntriPenumpang.Name = "btnEntriPenumpang";
            this.btnEntriPenumpang.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnEntriPenumpang.Size = new System.Drawing.Size(202, 49);
            this.btnEntriPenumpang.TabIndex = 1;
            this.btnEntriPenumpang.Text = "    Entri Penumpang";
            this.btnEntriPenumpang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEntriPenumpang.UseVisualStyleBackColor = true;
            this.btnEntriPenumpang.Click += new System.EventHandler(this.btnEntriPenumpang_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblLevel);
            this.panel2.Controls.Add(this.lblUsername);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(202, 49);
            this.panel2.TabIndex = 0;
            // 
            // lblLevel
            // 
            this.lblLevel.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblLevel.Location = new System.Drawing.Point(60, 19);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(100, 23);
            this.lblLevel.TabIndex = 2;
            this.lblLevel.Text = "Admin";
            this.lblLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUsername
            // 
            this.lblUsername.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblUsername.Location = new System.Drawing.Point(60, 2);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(100, 23);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Farhan";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::b3.Properties.Resources.user__2_;
            this.pictureBox1.Location = new System.Drawing.Point(-14, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelHeader.Controls.Add(this.btnExit);
            this.panelHeader.Controls.Add(this.btnMinimize);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(202, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(782, 37);
            this.panelHeader.TabIndex = 1;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            this.panelHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseMove);
            this.panelHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseUp);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnExit.Location = new System.Drawing.Point(753, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(28, 28);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "O";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMinimize.Location = new System.Drawing.Point(730, 5);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(28, 28);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.Text = "O";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitle.Location = new System.Drawing.Point(264, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(248, 23);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Home";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::b3.Properties.Resources.transportation__1_;
            this.pictureBox2.Location = new System.Drawing.Point(402, 147);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(396, 282);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(56)))));
            this.label4.Location = new System.Drawing.Point(447, 440);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(312, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ticketing Pesawat dan Kereta Api";
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(202, 37);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(782, 554);
            this.mainPanel.TabIndex = 4;
            this.mainPanel.Visible = false;
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 591);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnLaporan;
        private System.Windows.Forms.Button btnTransaksi;
        private System.Windows.Forms.Button btnPesanTiket;
        private System.Windows.Forms.Button btnEntriRute;
        private System.Windows.Forms.Button btnEntriPenumpang;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel mainPanel;
    }
}

