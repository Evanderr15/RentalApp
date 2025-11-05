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
    public partial class Barang : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;
        private DataSet ds = new DataSet();
        private string alamat, query;

        public Barang()
        {
            alamat = "server=localhost; database=db_rental; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNB.Text != "" && txtStok.Text != "" && txtHsewa.Text != "")
                {
                    query = "INSERT INTO tbl_barang (nama_barang, stok, harga_sewa) VALUES (@nama_barang, @stok, @harga_sewa)";

                    koneksi.Open();
                    perintah = new MySqlCommand(query, koneksi);
                    perintah.Parameters.AddWithValue("@nama_barang", txtNB.Text);
                    perintah.Parameters.AddWithValue("@stok", txtStok.Text);
                    perintah.Parameters.AddWithValue("@harga_sewa", txtHsewa.Text);
                    adapter = new MySqlDataAdapter(perintah);
                    int res = perintah.ExecuteNonQuery();
                    koneksi.Close();

                    if (res == 1)
                    {
                        MessageBox.Show("Insert Data Sukses ...");
                        Barang_Load(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Gagal Insert Data . . . ");
                    }
                }
                else
                {
                    MessageBox.Show("Data Tidak Lengkap !!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            try
            {
                Barang_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNB.Text != "")
                {
                    query = "SELECT * FROM tbl_barang WHERE nama_barang = @nama_barang";
                    ds.Clear();
                    koneksi.Open();
                    perintah = new MySqlCommand(query, koneksi);
                    perintah.Parameters.AddWithValue("@nama_barang", txtNB.Text);
                    adapter = new MySqlDataAdapter(perintah);
                    adapter.Fill(ds);
                    koneksi.Close();

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow kolom in ds.Tables[0].Rows)
                        {
                            txtIDB.Text = kolom["id_barang"].ToString();
                            txtNB.Text = kolom["nama_barang"].ToString();
                            txtStok.Text = kolom["stok"].ToString();
                            txtHsewa.Text = kolom["harga_sewa"].ToString();
                        }
                        txtNB.Enabled = false; // Disable nama barang saat edit
                        dataGridView1.DataSource = ds.Tables[0];
                        btnSave.Enabled = false;
                        btnU.Enabled = true;
                        btnS.Enabled = false;
                        btnC.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Data Tidak Ada !!");
                        Barang_Load(null, null);
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

        private void btnU_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNB.Text != "" && txtStok.Text != "" && txtHsewa.Text != "" && txtIDB.Text != "")
                {
                    query = "UPDATE tbl_barang SET nama_barang = @nama_barang, stok = @stok, harga_sewa = @harga_sewa WHERE id_barang = @id_barang";

                    koneksi.Open();
                    perintah = new MySqlCommand(query, koneksi);
                    perintah.Parameters.AddWithValue("@nama_barang", txtNB.Text);
                    perintah.Parameters.AddWithValue("@stok", txtStok.Text);
                    perintah.Parameters.AddWithValue("@harga_sewa", txtHsewa.Text);
                    perintah.Parameters.AddWithValue("@id_barang", txtIDB.Text);
                    adapter = new MySqlDataAdapter(perintah);
                    int res = perintah.ExecuteNonQuery();
                    koneksi.Close();

                    if (res == 1)
                    {
                        MessageBox.Show("Update Data Sukses ...");
                        Barang_Load(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Gagal Update Data . . . ");
                    }
                }
                else
                {
                    MessageBox.Show("Data Tidak Lengkap !!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void Barang_Load(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                query = "SELECT * FROM tbl_barang";
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();

                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].Width = 100;
                dataGridView1.Columns[0].HeaderText = "ID Barang";
                dataGridView1.Columns[1].Width = 150;
                dataGridView1.Columns[1].HeaderText = "Nama Barang";
                dataGridView1.Columns[2].Width = 120;
                dataGridView1.Columns[2].HeaderText = "Stok";
                dataGridView1.Columns[3].Width = 120;
                dataGridView1.Columns[3].HeaderText = "Harga Sewa";

                txtIDB.Clear();
                txtNB.Clear();
                txtStok.Clear();
                txtHsewa.Clear();
                txtNB.Enabled = true; // Enable nama barang untuk input baru
                txtIDB.Focus();
                btnU.Enabled = false;
                btnC.Enabled = false;
                btnSave.Enabled = true;
                btnS.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
