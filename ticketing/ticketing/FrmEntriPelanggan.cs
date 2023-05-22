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

namespace b2
{
    public partial class FrmEntriPelanggan : Form
    {
        public FrmEntriPelanggan()
        {
            InitializeComponent();
        }

        private void FrmEntriPelanggan_Load(object sender, EventArgs e)
        {
            SetVisible(false);
            LoadData();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private string SelectedUsername;
        private string SelectedID;
        private string SaveSection;

        void SearchData()
        {
            Sqlserver Con = new Sqlserver();
            SqlConnection Conn = Con.GetConn();

            try
            {
                Conn.Open();
                string kueri = "SELECT * FROM tb_pelanggan WHERE nama_pelanggan LIKE '%" +tbSearch.Text+ "%' OR no_telpon LIKE '%"+tbSearch.Text+"%'";
                
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(kueri, Conn);
                da.Fill(ds, "tb_pelanggan");

                tblPelanggan.DataSource = ds;
                tblPelanggan.DataMember = "tb_pelanggan";
                tblPelanggan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        private void SetVisible(bool v)
        {
            if (v)
            {
                lblName.Visible = true;
                lblPh.Visible = true;
                lblAddres.Visible = true;
                lblJk.Visible = true;
                tbName.Visible = true;
                tbPh.Visible = true;
                tbAddres.Visible = true;
                cBoxJk.Visible = true;
                btnSave.Visible = true;
                BtnCancel.Visible = true;
            }
            else
            {
                lblName.Visible = false;
                lblPh.Visible = false;
                lblAddres.Visible = false;
                lblJk.Visible = false;
                tbName.Visible = false;
                tbPh.Visible = false;
                tbAddres.Visible = false;
                cBoxJk.Visible = false;
                btnSave.Visible = false;
                BtnCancel.Visible = false;
            }
        }

        private void SetVisibleButton(bool v)
        {
            if(v)
            {
                btnCreate.Visible = true;
                btnDelete.Visible = true;
                btnUpdate.Visible = true;
            }
            else
            {
                btnCreate.Visible = false;
                btnDelete.Visible = false;
                btnUpdate.Visible = false;
            }
            
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            SetVisibleButton(false);
            SetVisible(true);
            SaveSection = "insert";
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            SetVisibleButton(true);
            SetVisible(false);
        }

        private void tblPelanggan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void LoadData()
        {
            Sqlserver con = new Sqlserver();
            SqlConnection Con = con.GetConn();

            try
            {
                Con.Open();

                string query = "SELECT * FROM tb_pelanggan";
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(query, Con);

                da.Fill(ds, "tb_pelanggan");
                tblPelanggan.DataSource = ds;
                tblPelanggan.DataMember = "tb_pelanggan";
                tblPelanggan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception g)
            {
                MessageBox.Show(g.ToString(), "Error");

            }
            finally
            {
                Con.Close();
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            SearchData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string msg = "Apakah kamu yakin untuk menghapus data " + SelectedUsername + " ("+ SelectedID + ") ?";

            if(MessageBox.Show(msg, "Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Sqlserver con = new Sqlserver();
                SqlConnection Conn = con.GetConn();

                try
                {
                    Conn.Open();
                    string kueri = "DELETE FROM tb_pelanggan WHERE id_pelanggan = '"+ SelectedID + "'";

                    SqlCommand cmd = new SqlCommand(kueri, Conn);
                    cmd.ExecuteNonQuery();
                    LoadData();
                    MessageBox.Show("Data berhasil dihapus", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception g)
                {

                    throw;
                }
                finally
                {
                    Conn.Close();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SetVisible(true);
            SetVisibleButton(false);
            SaveSection = "Update";
        }

        private void tblPelanggan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.tblPelanggan.Rows[e.RowIndex];
                SelectedUsername = row.Cells["nama_pelanggan"].Value.ToString();
                SelectedID = row.Cells["id_pelanggan"].Value.ToString();
                tbName.Text = row.Cells["nama_pelanggan"].Value.ToString();
                tbPh.Text = row.Cells["no_telpon"].Value.ToString();
                tbAddres.Text = row.Cells["alamat"].Value.ToString();
                cBoxJk.Text = row.Cells["jenis_kelamin"].Value.ToString();
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(SaveSection == "insert")
            {
                Sqlserver con = new Sqlserver();
                SqlConnection Conn = con.GetConn();

                try
                {
                    Conn.Open();
                    string kueri = "INSERT INTO tb_pelanggan (nama_pelanggan, no_telpon, alamat, jenis_kelamin) VALUES ('"+ tbName.Text +"','"+ tbPh.Text +"','"+ tbAddres.Text +"','"+ cBoxJk.Text +"')";

                    SqlCommand cmd = new SqlCommand(kueri, Conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil di tambahkan", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                catch (Exception g)
                {
                    MessageBox.Show(g.ToString(), "ERROR");
                }
                finally
                {
                    Conn.Close();
                }
            }
            else if(SaveSection == "Update")
            {
                Sqlserver con = new Sqlserver();
                SqlConnection Conn = con.GetConn();

                try
                {
                    Conn.Open();
                    string kueri = "UPDATE tb_pelanggan SET nama_pelanggan = '"+tbName.Text+"', jenis_kelamin = '"+cBoxJk.Text+"', no_telpon = '"+tbPh.Text+"', alamat = '"+tbAddres.Text+"' WHERE id_pelanggan = '"+ SelectedID +"'";

                    SqlCommand cmd = new SqlCommand(kueri, Conn);
                    cmd.ExecuteNonQuery();
                    LoadData();
                    MessageBox.Show("Data berhasil di ubah");

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
        }
    }
}
