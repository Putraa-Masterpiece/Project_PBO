using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_PBO
{
    public partial class KelolaKendaraan : Form
    {
        string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=12345;Database=project_pbo";
        int selectedId = -1;
        public KelolaKendaraan()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void KelolaKendaraan_Load(object sender, EventArgs e)
        {
            comboStatus.Items.Add("Tersedia");
            comboStatus.Items.Add("Tidak Tersedia");
            comboStatus.SelectedIndex = 0;

            LoadData();
        }

        private void LoadData()
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM mobil ORDER BY id_mobil";
                using (var da = new NpgsqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridKendaraan.DataSource = dt;
                }
            }
        }

        private void ClearForm()
        {
            txtMerek.Text = "";
            txtTipe.Text = "";
            numKapasitas.Value = 1;
            txtHarga.Text = "";
            comboStatus.SelectedIndex = 0;
            selectedId = -1;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO mobil (merek, tipe, kapasitas_penumpang, harga, status_ketersediaan) " +
                               "VALUES (@merek, @tipe, @kapasitas, @harga, @status)";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("merek", txtMerek.Text);
                    cmd.Parameters.AddWithValue("tipe", txtTipe.Text);
                    cmd.Parameters.AddWithValue("kapasitas", (int)numKapasitas.Value);
                    cmd.Parameters.AddWithValue("harga", Convert.ToDecimal(txtHarga.Text));
                    cmd.Parameters.AddWithValue("status", comboStatus.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                }
            }

            LoadData();
            ClearForm();
            MessageBox.Show("Data kendaraan berhasil disimpan.");
        }

        private void dataGridKendaraan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridKendaraan.Rows[e.RowIndex];
                selectedId = Convert.ToInt32(dataGridKendaraan.Rows[e.RowIndex].Cells["id_mobil"].Value);
                txtMerek.Text = dataGridKendaraan.Rows[e.RowIndex].Cells["merek"].Value.ToString();
                txtTipe.Text = dataGridKendaraan.Rows[e.RowIndex].Cells["tipe"].Value.ToString();
                numKapasitas.Value = Convert.ToInt32(dataGridKendaraan.Rows[e.RowIndex].Cells["kapasitas_penumpang"].Value);
                txtHarga.Text = dataGridKendaraan.Rows[e.RowIndex].Cells["harga"].Value.ToString();
                comboStatus.SelectedItem = dataGridKendaraan.Rows[e.RowIndex].Cells["status_ketersediaan"].Value.ToString();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            


        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (selectedId == -1)
            {
                MessageBox.Show("Pilih data yang ingin dihapus terlebih dahulu.");
                return;
            }

            var result = MessageBox.Show("Apakah yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM mobil WHERE id_mobil = @id_mobil";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("id_mobil", selectedId);
                        cmd.ExecuteNonQuery();
                    }
                }

                LoadData();
                ClearForm();
                MessageBox.Show("Data kendaraan berhasil dihapus.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            ClearForm();

        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            if (selectedId == -1)
            {
                MessageBox.Show("Pilih kendaraan yang ingin diedit.");
                return;
            }
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE mobil SET merek = @merek, tipe = @tipe, kapasitas_penumpang = @kapasitas, " +
                               "harga = @harga, status_ketersediaan = @status WHERE id_mobil = @id_mobil";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("merek", txtMerek.Text);
                    cmd.Parameters.AddWithValue("tipe", txtTipe.Text);
                    cmd.Parameters.AddWithValue("kapasitas", (int)numKapasitas.Value);
                    cmd.Parameters.AddWithValue("harga", Convert.ToDecimal(txtHarga.Text));
                    cmd.Parameters.AddWithValue("status", comboStatus.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("id_mobil", selectedId);
                    cmd.ExecuteNonQuery();

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data kendaraan berhasil diperbarui.");
                    }
                    else
                    {
                        MessageBox.Show("Data gagal diperbarui. Mungkin ID tidak ditemukan.");
                    }

                }
            }
            LoadData();
            ClearForm();
            MessageBox.Show("Data kendaraan berhasil diperbarui.");
        }
    }
}
