using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace RentalApp
{
    public partial class Pelanggan : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;
        private DataSet ds = new DataSet();
        private string alamat, query;
        public Pelanggan()
        {
            alamat = "server=localhost; database=db_rentalapp; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void Pelanggan_Load(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                query = string.Format("select * from tbl_pelanggan");
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].Width = 100;
                dataGridView1.Columns[0].HeaderText = "ID Pelanggan";
                dataGridView1.Columns[1].Width = 150;
                dataGridView1.Columns[1].HeaderText = "Nama";
                dataGridView1.Columns[2].Width = 120;
                dataGridView1.Columns[2].HeaderText = "Alamat";
                dataGridView1.Columns[3].Width = 120;
                dataGridView1.Columns[3].HeaderText = "Telepon";
                dataGridView1.Columns[4].Width = 120;
                dataGridView1.Columns[4].HeaderText = "Jaminan";

                txtID.Clear();
                txtNama.Clear();
                txtAlamat.Clear();
                txtTelepon.Clear();
                txtJaminan.Clear();
                txtID.Focus();
                btnUpdate.Enabled = false;
                btnClear.Enabled = false;
                btnAdd.Enabled = true;
                btnSearch.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtTanggal_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtAlamat_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNama.Text != "")
                {
                    query = string.Format("select * from tbl_pelanggan where Nama = '{0}'", txtNama.Text);
                    ds.Clear();
                    koneksi.Open();
                    perintah = new MySqlCommand(query, koneksi);
                    adapter = new MySqlDataAdapter(perintah);
                    perintah.ExecuteNonQuery();
                    adapter.Fill(ds);
                    koneksi.Close();
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow kolom in ds.Tables[0].Rows)
                        {
                            txtNama.Text = kolom["nama"].ToString();
                            txtAlamat.Text = kolom["alamat"].ToString();
                            txtTelepon.Text = kolom["telepon"].ToString();
                            txtJaminan.Text = kolom["jaminan"].ToString();


                        }
                        txtNama.Enabled = false;
                        dataGridView1.DataSource = ds.Tables[0];
                        btnAdd.Enabled = false;
                        btnUpdate.Enabled = true;
                        btnSearch.Enabled = false;
                        btnClear.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Data Tidak Ada !!");
                        Pelanggan_Load(null, null);
                    }

                }
                else
                {
                    MessageBox.Show("Data Yang Anda Pilih Tidak Ada !!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                Pelanggan_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNama.Text != "" && txtAlamat.Text != "" && txtTelepon.Text != "" && txtJaminan.Text != "")
                {

                    query = string.Format("update tbl_pelanggan set nama = '{0}', alamat = '{1}', telepon = '{2}' where jaminan = '{3}'", txtNama.Text, txtAlamat.Text, txtTelepon.Text, txtJaminan.Text);


                    koneksi.Open();
                    perintah = new MySqlCommand(query, koneksi);
                    adapter = new MySqlDataAdapter(perintah);
                    int res = perintah.ExecuteNonQuery();
                    koneksi.Close();
                    if (res == 1)
                    {
                        MessageBox.Show("Update Data Suksess ...");
                        Pelanggan_Load(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Gagal Update Data . . . ");
                    }
                }
                else
                {
                    MessageBox.Show("Data Tidak lengkap !!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNama.Text != "" && txtAlamat.Text != "" && txtTelepon.Text != "" && txtJaminan.Text != "")
                {

                    query = string.Format("insert into tbl_pelanggan  values ('{0}','{1}','{2}','{3}', '{4}');", txtID.Text, txtNama.Text, txtAlamat.Text, txtTelepon.Text, txtJaminan.Text);


                    koneksi.Open();
                    perintah = new MySqlCommand(query, koneksi);
                    adapter = new MySqlDataAdapter(perintah);
                    int res = perintah.ExecuteNonQuery();
                    koneksi.Close();
                    if (res == 1)
                    {
                        MessageBox.Show("Insert Data Suksess ...");
                        Pelanggan_Load(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Gagal inser Data . . . ");
                    }
                }
                else
                {
                    MessageBox.Show("Data Tidak lengkap !!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
