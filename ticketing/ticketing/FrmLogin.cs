using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace b3
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            sqlserver con = new sqlserver();
            SqlConnection Conn = con.GetConn();

            try
            {
                Conn.Open();
                string query = "SELECT lvl FROM tb_petugas WHERE username = '" + tbox_Username.Text + "' AND password = '" + tbox_password.Text + "'";
                SqlCommand cmd = new SqlCommand(query, Conn);

                string lvl = (string)cmd.ExecuteScalar();
                if(lvl != null)
                {
                    FrmMainMenu main = new FrmMainMenu();
                    main.Autentication(lvl, tbox_Username.Text);
                    main.Show();
                    this.Hide();
                }
            }
            catch (Exception g)
            {
                MessageBox.Show(g.ToString(), "Error");
            }
            finally 
            {
                Conn.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda yakin ingin Keluar dari aplikasi?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
