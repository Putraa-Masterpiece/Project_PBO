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
        private string selectedJenisPembayaran = "";




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

            comboBox1.Items.Clear();
            comboBox1.Items.Add("Tunai");
            comboBox1.Items.Add("Bank BCA");
            comboBox1.Items.Add("Bank BNI");
            comboBox1.Items.Add("Bank Mandiri");
            comboBox1.Items.Add("Bank BRI");
            comboBox1.Items.Add("QRIS / E-wallet");
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
                string query = "SELECT * FROM supir WHERE status = 'Tersedia'";
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
                DataGridViewRow row = dataGridSupir.Rows[e.RowIndex];
                selectedSupirId = Convert.ToInt32(row.Cells["id_supir"].Value);



                // Refresh tampilan supir agar supir tersebut hilang


                // Simpan id_supir jika perlu
                txtNamaSupir.Text = selectedSupirId.ToString(); // TextBox tersembunyi misalnya
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

            if (string.IsNullOrEmpty(selectedJenisPembayaran))
            {
                MessageBox.Show("Silakan pilih metode pembayaran terlebih dahulu.");
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

                using (var transaction = conn.BeginTransaction()) // Transaksi database agar aman
                {
                    try
                    {
                        // Simpan data sewa
                        // Simpan data sewa
                        string insert = "INSERT INTO sewa (id_user, id_mobil, id_supir, durasi_peminjaman, tanggal_peminjaman, tanggal_pengembalian, total_harga, dengan_supir) " +
                                        "VALUES (@id_user, @id_mobil, @id_supir, @durasi, @tgl_pinjam, @tgl_kembali, @total, @dengan_supir) RETURNING id_sewa";

                        int idSewaBaru;
                        using (var cmd = new NpgsqlCommand(insert, conn))
                        {
                            cmd.Parameters.AddWithValue("id_user", Session.UserId);
                            cmd.Parameters.AddWithValue("id_mobil", selectedMobilId);
                            cmd.Parameters.AddWithValue("id_supir", (object?)selectedSupirId ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("durasi", (int)numDurasi.Value);
                            cmd.Parameters.AddWithValue("tgl_pinjam", datePeminjaman.Value);
                            cmd.Parameters.AddWithValue("tgl_kembali", datePengembalian.Value);
                            cmd.Parameters.AddWithValue("total", Convert.ToDecimal(txtTotalHarga.Text));
                            cmd.Parameters.AddWithValue("dengan_supir", checkSupir.Checked);

                            idSewaBaru = (int)cmd.ExecuteScalar(); // ambil id_sewa yang baru dimasukkan
                        }

                        // Jika supir dipakai, ubah status-nya
                        if (checkSupir.Checked && selectedSupirId.HasValue)
                        {
                            string updateSupir = "UPDATE supir SET status = 'Tidak Tersedia' WHERE id_supir = @id_supir";

                            using (var cmdUpdate = new NpgsqlCommand(updateSupir, conn))
                            {
                                cmdUpdate.Parameters.AddWithValue("id_supir", selectedSupirId.Value);
                                cmdUpdate.ExecuteNonQuery();
                            }
                        }

                        // Simpan ke tabel pembayaran
                        string insertPembayaran = "INSERT INTO pembayaran (id_sewa, jenis_pembayaran) VALUES (@id_sewa, @jenis)";
                        using (var cmdBayar = new NpgsqlCommand(insertPembayaran, conn))
                        {
                            cmdBayar.Parameters.AddWithValue("id_sewa", idSewaBaru);
                            cmdBayar.Parameters.AddWithValue("jenis", selectedJenisPembayaran);
                            cmdBayar.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        MessageBox.Show("Transaksi berhasil!.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback(); // Rollback jika ada error
                        MessageBox.Show("Terjadi kesalahan: " + ex.Message);
                        return;
                    }
                }

                // Lanjut ke halaman pembayaran

            }
        }
        


        private void btnKembali_Click(object sender, EventArgs e)
        {
            UserDashboard userDashboard = new UserDashboard();
            userDashboard.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedJenisPembayaran = comboBox1.SelectedItem.ToString();

            switch (selectedJenisPembayaran)
            {
                case "Tunai":
                    MessageBox.Show("Silakan bayar secara langsung ke kasir.");
                    break;
                case "Bank BCA":
                    MessageBox.Show("Transfer ke rekening BCA: 123-456-7890 a.n. PT. FASTRENT");
                    break;
                case "Bank BNI":
                    MessageBox.Show("Transfer ke rekening BNI: 987-654-3210 a.n. PT. FASTRENT");
                    break;
                case "Bank Mandiri":
                    MessageBox.Show("Transfer ke rekening Mandiri: 112-233-4455 a.n. PT. FASTRENT");
                    break;
                case "Bank BRI":
                    MessageBox.Show("Transfer ke rekening BRI: 556-677-8899 a.n. PT. FASTRENT");
                    break;
                case "QRIS / E-wallet":
                    MessageBox.Show("Silakan scan QRIS atau gunakan e-wallet (OVO, DANA, GoPay)");
                    break;
                default:
                    MessageBox.Show("Metode pembayaran tidak dikenali.");
                    break;
            }
        }

    }
}
