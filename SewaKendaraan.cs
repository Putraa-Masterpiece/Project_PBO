using Npgsql;
using Project_PBO.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace Project_PBO
{
    public partial class SewaKendaraan : Form
    {
        private string connStr = "Host=localhost;Port=5432;Username=postgres;Password=12345;Database=project_pbo";
        private decimal hargaMobil = 0;
        private int? selectedSupirId = null;
        private int selectedMobilId = -1;

        public SewaKendaraan()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol.Name = "Foto";
            imgCol.HeaderText = "Foto Mobil";
            imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom; // Agar gambar tidak terpotong
            dataGridMobil.Columns.Add(imgCol);

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SewaKendaraan_Load(object sender, EventArgs e)
        {
            LoadDataMobil();
            dataGridSupir.Visible = false;
            datePengembalian.Enabled = false;
        }

        private void LoadDataMobil()
        {
            using (var conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT * FROM mobil WHERE status_ketersediaan = 'Tersedia'";
                using (var da = new NpgsqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridMobil.DataSource = dt;
                }
            }
        }

        private void LoadDataSupir()
        {
            using (var conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT * FROM supir";
                using (var da = new NpgsqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridSupir.DataSource = dt;
                }
            }
        }

        private void dataGridMobil_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridMobil.Rows[e.RowIndex];
                selectedMobilId = Convert.ToInt32(row.Cells["id_mobil"].Value);
                txtMerek.Text = row.Cells["merek"].Value.ToString();
                txtTipe.Text = row.Cells["tipe"].Value.ToString();
                txtKapasitas.Text = row.Cells["kapasitas_penumpang"].Value.ToString();
                txtHarga.Text = row.Cells["harga"].Value.ToString();
                txtStatus.Text = row.Cells["status_ketersediaan"].Value.ToString();

                hargaMobil = Convert.ToDecimal(row.Cells["harga"].Value);
                HitungTotalHarga();
            }
        }

        private void dataGridSupir_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridSupir.Rows[e.RowIndex];
                selectedSupirId = Convert.ToInt32(row.Cells["id_supir"].Value);
            }
        }

        private void checkSupir_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void numDurasi_ValueChanged(object sender, EventArgs e)
        {
            HitungTotalHarga();
        }

        private void datePeminjaman_ValueChanged(object sender, EventArgs e)
        {
            datePengembalian.Value = datePeminjaman.Value.AddDays((int)numDurasi.Value);
        }

        private void HitungTotalHarga()
        {
            int durasi = (int)numDurasi.Value;
            decimal total = hargaMobil * durasi;
            txtTotalHarga.Text = total.ToString("N0");

            datePengembalian.Value = datePeminjaman.Value.AddDays(durasi);
        }

        private void btnKonfirmasi_Click(object sender, EventArgs e)
        {
            if (selectedMobilId == -1)
            {
                MessageBox.Show("Silakan pilih mobil terlebih dahulu.");
                return;
            }

            using (var conn = new NpgsqlConnection(connStr))
            {
                conn.Open();

                string insert = "INSERT INTO sewa (id_user, id_mobil, id_supir, durasi_peminjaman, tanggal_peminjaman, tanggal_pengembalian, total_harga, dengan_supir) " +
                                "VALUES (@id_user, @id_mobil, @id_supir, @durasi, @tgl_pinjam, @tgl_kembali, @total, @dengan_supir)";

                using (var cmd = new NpgsqlCommand(insert, conn))
                {
                    cmd.Parameters.AddWithValue("id_user", Session.UserId); // asumsikan Anda punya class Session
                    cmd.Parameters.AddWithValue("id_mobil", selectedMobilId);
                    cmd.Parameters.AddWithValue("id_supir", (object?)selectedSupirId ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("durasi", (int)numDurasi.Value);
                    cmd.Parameters.AddWithValue("tgl_pinjam", datePeminjaman.Value);
                    cmd.Parameters.AddWithValue("tgl_kembali", datePengembalian.Value);
                    cmd.Parameters.AddWithValue("total", Convert.ToDecimal(txtTotalHarga.Text));
                    cmd.Parameters.AddWithValue("dengan_supir", checkSupir.Checked);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Transaksi berhasil!");
            DashboardPembayaran pembayaran = new DashboardPembayaran();
            pembayaran.Show();
            this.Hide();
        }

        private void checkSupir_CheckedChanged_1(object sender, EventArgs e)
        {
            dataGridSupir.Visible = checkSupir.Checked;
            if (checkSupir.Checked)
                LoadDataSupir();
        }

        private void dataGridMobil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnKonfirmasi_Click_1(object sender, EventArgs e)
        {
            if (selectedMobilId == -1)
            {
                MessageBox.Show("Silakan pilih mobil terlebih dahulu.");
                return;
            }

            using (var conn = new NpgsqlConnection(connStr))
            {
                conn.Open();

                string insert = "INSERT INTO sewa (id_user, id_mobil, id_supir, durasi_peminjaman, tanggal_peminjaman, tanggal_pengembalian, total_harga, dengan_supir) " +
                                "VALUES (@id_user, @id_mobil, @id_supir, @durasi, @tgl_pinjam, @tgl_kembali, @total, @dengan_supir)";

                using (var cmd = new NpgsqlCommand(insert, conn))
                {
                    cmd.Parameters.AddWithValue("id_user", Session.UserId); // asumsikan Anda punya class Session
                    cmd.Parameters.AddWithValue("id_mobil", selectedMobilId);
                    cmd.Parameters.AddWithValue("id_supir", (object?)selectedSupirId ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("durasi", (int)numDurasi.Value);
                    cmd.Parameters.AddWithValue("tgl_pinjam", datePeminjaman.Value);
                    cmd.Parameters.AddWithValue("tgl_kembali", datePengembalian.Value);
                    cmd.Parameters.AddWithValue("total", Convert.ToDecimal(txtTotalHarga.Text));
                    cmd.Parameters.AddWithValue("dengan_supir", checkSupir.Checked);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Transaksi berhasil!");
            DashboardPembayaran pembayaran = new DashboardPembayaran();
            pembayaran.Show();
            this.Hide();
        }
    }
}
