using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace b3
{
    public partial class FrmMainMenu : Form
    {
        public FrmMainMenu()
        {
            InitializeComponent();
        }

        Button currentButton;
        bool mouseDown;

        public void Autentication(string lvl, string name)
        {
            if(lvl == "Admin")
            {

            }
            if(lvl == "Penumpang")
            {

            }
            if(lvl == "Petugas")
            {

            }

            lblUsername.Text = name;
            lblLevel.Text = lvl;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Apakah anda yakin ingin keluar?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void panelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if(mouseDown)
            {
                int mousex = MousePosition.X - 400;
                int mousey = MousePosition.Y - 20;
                this.SetDesktopLocation(mousex, mousey);
            }
        }

        private void panelHeader_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        void LoadForm(object Form)
        {
            if (this.mainPanel.Controls.Count > 0)
                this.mainPanel.Controls.RemoveAt(0);

            mainPanel.Visible = true;
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();
        }

        void ActiveButton(object btnSender)
        {
            if(btnSender != null)
            {
                if(currentButton != (Button)btnSender)
                {
                    ResetButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.FromArgb(51, 51, 76);
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Bahnschrift", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        void ResetButton()
        {
            btnEntriPenumpang.BackColor = Color.FromArgb(31, 31, 56);
            btnEntriPenumpang.ForeColor = Color.Gainsboro;
            btnEntriPenumpang.Font = new System.Drawing.Font("Bahnschrift", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            btnEntriRute.BackColor = Color.FromArgb(31, 31, 56);
            btnEntriRute.ForeColor = Color.Gainsboro;
            btnEntriRute.Font = new System.Drawing.Font("Bahnschrift", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            btnPesanTiket.BackColor = Color.FromArgb(31, 31, 56);
            btnPesanTiket.ForeColor = Color.Gainsboro;
            btnPesanTiket.Font = new System.Drawing.Font("Bahnschrift", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            btnTransaksi.BackColor = Color.FromArgb(31, 31, 56);
            btnTransaksi.ForeColor = Color.Gainsboro;
            btnTransaksi.Font = new System.Drawing.Font("Bahnschrift", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            btnLaporan.BackColor = Color.FromArgb(31, 31, 56);
            btnLaporan.ForeColor = Color.Gainsboro;
            btnLaporan.Font = new System.Drawing.Font("Bahnschrift", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void btnEntriPenumpang_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            lblTitle.Text = "Entri Penumpang";
            LoadForm(new FrmEntriPenumpang());
        }

        private void btnEntriRute_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            lblTitle.Text = "Entri Rute";
        }

        private void btnPesanTiket_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            lblTitle.Text = "Pesan Tiket";
        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            lblTitle.Text = "Transaksi";
        }

        private void btnLaporan_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            lblTitle.Text = "Laporan";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Apakah anda yakin ingin logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FrmLogin login = new FrmLogin();
                login.Show();
                this.Hide();
            }
        }
    }
}
