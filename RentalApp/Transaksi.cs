using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RentalApp
{
    public partial class Transaksi : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;
        private DataSet ds = new DataSet();
        private string alamat, query;

        public Transaksi()
        {
            alamat = "server=localhost; database=db_rentalapp; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // Event handler kosong, tidak perlu perubahan
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (CBPel.Text != "" && CBBar.Text != "" && dtpM.Text != "" && dtpK.Text != "" && CBStatus.Text != "" && txtTotal.Text != "")
                {
                    // Perbaikan: Tambahkan kolom BiayaTotal ke dalam INSERT INTO
                    query = "INSERT INTO tbl_transaksi (id_pelanggan, id_barang, TanggalMulai, TanggalKembali, Status, BiayaTotal) VALUES (@id_pelanggan, @id_barang, @TanggalMulai, @TanggalKembali, @Status, @BiayaTotal)";

                    koneksi.Open();
                    perintah = new MySqlCommand(query, koneksi);
                    perintah.Parameters.AddWithValue("@id_pelanggan", CBPel.Text);
                    perintah.Parameters.AddWithValue("@id_barang", CBBar.Text);
                    // Perbaikan: Gunakan .Value untuk DateTimePicker
                    perintah.Parameters.AddWithValue("@TanggalMulai", dtpM.Value);
                    perintah.Parameters.AddWithValue("@TanggalKembali", dtpK.Value);
                    perintah.Parameters.AddWithValue("@Status", CBStatus.Text);
                    perintah.Parameters.AddWithValue("@BiayaTotal", txtTotal.Text);
                    adapter = new MySqlDataAdapter(perintah);
                    int res = perintah.ExecuteNonQuery();
                    koneksi.Close();

                    if (res == 1)
                    {
                        MessageBox.Show("Insert Data Sukses ...");
                        Transaksi_Load(null, null);
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

        private void btnUP_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtpM.Text != "" && dtpK.Text != "" && CBStatus.Text != "" && txtTotal.Text != "")
                {
                    query = "UPDATE tbl_transaksi SET TanggalMulai = @TanggalMulai, TanggalKembali = @TanggalKembali, Status = @Status, BiayaTotal = @BiayaTotal WHERE id_transaksi = @id_transaksi";

                    koneksi.Open();
                    perintah = new MySqlCommand(query, koneksi);
                    // Perbaikan: Gunakan .Value untuk DateTimePicker
                    perintah.Parameters.AddWithValue("@TanggalMulai", dtpM.Value);
                    perintah.Parameters.AddWithValue("@TanggalKembali", dtpK.Value);
                    perintah.Parameters.AddWithValue("@Status", CBStatus.Text);
                    perintah.Parameters.AddWithValue("@BiayaTotal", txtTotal.Text);
                    perintah.Parameters.AddWithValue("@id_transaksi", txtIDT.Text);
                    adapter = new MySqlDataAdapter(perintah);
                    int res = perintah.ExecuteNonQuery();
                    koneksi.Close();

                    if (res == 1)
                    {
                        MessageBox.Show("Update Data Sukses ...");
                        Transaksi_Load(null, null);
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

        private void btnCL_Click(object sender, EventArgs e)
        {
            try
            {
                Transaksi_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSc_Click(object sender, EventArgs e)
        {
            try
            {
                if (CBPel.Text != "")
                {
                    // Perbaikan: Gunakan parameterized query untuk menghindari SQL injection
                    query = "SELECT * FROM tbl_transaksi WHERE id_pelanggan = @id_pelanggan";
                    ds.Clear();
                    koneksi.Open();
                    perintah = new MySqlCommand(query, koneksi);
                    perintah.Parameters.AddWithValue("@id_pelanggan", CBPel.Text);
                    adapter = new MySqlDataAdapter(perintah);
                    perintah.ExecuteNonQuery();
                    adapter.Fill(ds);
                    koneksi.Close();
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        // Catatan: Jika ada multiple rows, ini hanya mengisi dari row terakhir. Pertimbangkan untuk menggunakan DataGridView selection.
                        foreach (DataRow kolom in ds.Tables[0].Rows)
                        {
                            txtIDT.Text = kolom["id_transaksi"].ToString();
                            CBPel.Text = kolom["id_pelanggan"].ToString();
                            CBBar.Text = kolom["id_barang"].ToString();
                            // Perbaikan: Gunakan .Value untuk mengisi DateTimePicker
                            dtpM.Value = DateTime.Parse(kolom["TanggalMulai"].ToString());
                            dtpK.Value = DateTime.Parse(kolom["TanggalKembali"].ToString());
                            CBStatus.Text = kolom["Status"].ToString();
                            txtTotal.Text = kolom["BiayaTotal"].ToString();
                        }
                        CBPel.Enabled = false;
                        dataGridView1.DataSource = ds.Tables[0];
                        btnSimpan.Enabled = false;
                        btnUP.Enabled = true;
                        btnSc.Enabled = false;
                        btnCL.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Data Tidak Ada !!");
                        Transaksi_Load(null, null);
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

        private void btnBb_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void Transaksi_Load(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                query = "SELECT * FROM tbl_transaksi";
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();
                dataGridView1.DataSource = ds.Tables[0];

                // Perbaikan: Atur kolom DataGridView dengan benar (asumsi 7 kolom: id_transaksi, id_pelanggan, id_barang, TanggalMulai, TanggalKembali, Status, BiayaTotal)
                dataGridView1.Columns[0].Width = 100;
                dataGridView1.Columns[0].HeaderText = "ID Transaksi";
                dataGridView1.Columns[1].Width = 100;
                dataGridView1.Columns[1].HeaderText = "ID Pelanggan";
                dataGridView1.Columns[2].Width = 100;
                dataGridView1.Columns[2].HeaderText = "ID Barang";
                dataGridView1.Columns[3].Width = 150;
                dataGridView1.Columns[3].HeaderText = "Tanggal Mulai";
                dataGridView1.Columns[4].Width = 120;
                dataGridView1.Columns[4].HeaderText = "Tanggal Pengembalian";
                dataGridView1.Columns[5].Width = 120;
                dataGridView1.Columns[5].HeaderText = "Status";
                dataGridView1.Columns[6].Width = 120;
                dataGridView1.Columns[6].HeaderText = "Total";

                txtIDT.Clear();
                txtTotal.Clear();
                txtIDT.Focus();
                btnUP.Enabled = false;
                btnCL.Enabled = false;
                btnSimpan.Enabled = true;
                btnSc.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
