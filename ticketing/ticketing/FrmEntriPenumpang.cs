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
    public partial class FrmEntriPenumpang : Form
    {
        public FrmEntriPenumpang()
        {
        
            InitializeComponent();
            LoadData();
            load_cbox();
            dateTimePicker1.Value = DateTime.Today;
        }

        void LoadData()
        {
            sqlserver con = new sqlserver();
            SqlConnection Conn = con.GetConn();

            try
            {
                Conn.Open();
                string kueri = "SELECT * FROM tb_pelanggan";
                SqlCommand cmd = new SqlCommand(kueri, Conn);
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "tb_pelanggan");

                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "tb_pelanggan";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception g)
            {
                MessageBox.Show(g.ToString(), "Error");
            }
        }

        void load_cbox()
        {
            sqlserver con = new sqlserver();
            SqlConnection Conn = con.GetConn();

            try
            {
                Conn.Open();
                string kueri = "SELECT nama_pelanggan FROM tb_pelanggan";
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(kueri, Conn);
                da.Fill(dt);

                cbox_jk.DataSource = dt;
                cbox_jk.ValueMember = "nama_pelanggan";
                cbox_jk.DisplayMember = "nama_pelanggan";
            }
            catch (Exception g)
            {
                MessageBox.Show(g.ToString(), "Error");
            }
        }

        private void FrmEntriPenumpang_Load(object sender, EventArgs e)
        {
            
        }



        void CariData()
        {
            sqlserver con = new sqlserver();
            SqlConnection Conn = con.GetConn();

            try
            {
                Conn.Open();
                string kueri = "SELECT * FROM tb_pelanggan WHERE nama_pelanggan LIKE '%"+tbox_cari.Text+"%' OR alamat LIKE '%"+tbox_cari.Text+"%'";
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(kueri, Conn);
                da.Fill(ds, "tb_pelanggan");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "tb_pelanggan";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            catch (Exception g)
            {

            }
        }




        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                tbox_nama.Text = row.Cells["nama_pelanggan"].Value.ToString();
                cbox_jk.Text = row.Cells["jenis_kelamin"].Value.ToString();
            }
        }

        private void tbox_cari_TextChanged(object sender, EventArgs e)
        {
            CariData();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string msg = "" + dateTimePicker1.Text;
            MessageBox.Show(msg, "tes");
        }
    }
}
