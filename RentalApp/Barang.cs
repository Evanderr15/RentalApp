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
            alamat = "server=localhost; database=db_rentalapp; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNB.Text != "" && txtHsewa.Text != "" && txtStok.Text != "")
                {
                    query = "INSERT INTO tbl_barang (nama_barang, harga_sewa, stok) VALUES (@nama_barang, @harga_sewa, @stok)";

                    koneksi.Open();
                    perintah = new MySqlCommand(query, koneksi);
                    perintah.Parameters.AddWithValue("@nama_barang", txtNB.Text);
                    perintah.Parameters.AddWithValue("@harga_sewa", txtHsewa.Text);
                    perintah.Parameters.AddWithValue("@stok", txtStok.Text);
                    // adapter tidak diperlukan untuk insert; cukup gunakan perintah.ExecuteNonQuery()
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
                MessageBox.Show("Error: " + ex.Message); // Lebih baik tampilkan pesan error yang lebih bersih
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
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIDB.Text != "")
                {
                    query = "SELECT * FROM tbl_barang WHERE id_barang = @id_barang";
                    ds.Clear();
                    koneksi.Open();
                    perintah = new MySqlCommand(query, koneksi);
                    perintah.Parameters.AddWithValue("@id_barang", txtIDB.Text);
                    adapter = new MySqlDataAdapter(perintah);
                    adapter.Fill(ds);
                    koneksi.Close();

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        // Karena query WHERE id_barang, seharusnya hanya satu baris; tidak perlu loop
                        DataRow kolom = ds.Tables[0].Rows[0];
                        txtIDB.Text = kolom["id_barang"].ToString();
                        txtNB.Text = kolom["nama_barang"].ToString();
                        txtHsewa.Text = kolom["harga_sewa"].ToString(); // Diperbaiki: txtHsewa untuk harga_sewa
                        txtStok.Text = kolom["stok"].ToString(); // Diperbaiki: txtStok untuk stok

                        txtIDB.Enabled = false; // Disable ID saat edit
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
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNB.Text != "" && txtHsewa.Text != "" && txtStok.Text != "" && txtIDB.Text != "")
                {
                    query = "UPDATE tbl_barang SET nama_barang = @nama_barang, harga_sewa = @harga_sewa, stok = @stok WHERE id_barang = @id_barang";

                    koneksi.Open();
                    perintah = new MySqlCommand(query, koneksi);
                    perintah.Parameters.AddWithValue("@nama_barang", txtNB.Text);
                    perintah.Parameters.AddWithValue("@harga_sewa", txtHsewa.Text);
                    perintah.Parameters.AddWithValue("@stok", txtStok.Text);
                    perintah.Parameters.AddWithValue("@id_barang", txtIDB.Text);
                    // adapter tidak diperlukan untuk update; cukup gunakan perintah.ExecuteNonQuery()
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
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        // Event handlers kosong dihapus untuk membersihkan kode
        // private void txtNB_TextChanged(object sender, EventArgs e) { }
        // private void txtHsewa_TextChanged(object sender, EventArgs e) { }
        // private void label3_Click(object sender, EventArgs e) { }

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
                // Asumsikan urutan kolom: 0=id_barang, 1=nama_barang, 2=harga_sewa, 3=stok
                dataGridView1.Columns[0].Width = 100;
                dataGridView1.Columns[0].HeaderText = "ID Barang";
                dataGridView1.Columns[1].Width = 150;
                dataGridView1.Columns[1].HeaderText = "Nama Barang";
                dataGridView1.Columns[2].Width = 120;
                dataGridView1.Columns[2].HeaderText = "Harga Sewa";
                dataGridView1.Columns[3].Width = 120;
                dataGridView1.Columns[3].HeaderText = "Stok";

                txtIDB.Clear();
                txtNB.Clear();
                txtHsewa.Clear();
                txtStok.Clear();
                txtNB.Enabled = true;
                txtIDB.Focus();
                btnU.Enabled = false;
                btnC.Enabled = false;
                btnSave.Enabled = true;
                btnS.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
