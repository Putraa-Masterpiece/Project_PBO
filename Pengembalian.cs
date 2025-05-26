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

namespace Project_PBO
{
    public partial class Pengembalian : Form
    {
        private string connStr = "Host=localhost;Port=5432;Username=postgres;Password=12345;Database=project_pbo";
        private int selectedSewaId = -1;
        private int mobilId = -1;
        private int? supirId = null;
        private string selectedMerek = string.Empty;
        public Pengembalian()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnKonfirmasi_Click(object sender, EventArgs e)
        {
            if (selectedSewaId == -1 || selectedMerek == string.Empty)
            {
                MessageBox.Show("Pilih data terlebih dahulu!");
                return;
            }

            using (var conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        string updateSewa = "UPDATE sewa SET status_pengembalian = 'Sudah' WHERE id_sewa = @id_sewa";
                        using (var cmdSewa = new NpgsqlCommand(updateSewa, conn))
                        {
                            cmdSewa.Parameters.AddWithValue("id_sewa", selectedSewaId);
                            cmdSewa.ExecuteNonQuery();
                        }
                        // Update status mobil
                        string updateMobil = "UPDATE mobil SET status_ketersediaan = 'Tersedia' WHERE id_mobil = @id_mobil";
                        using (var cmdMobil = new NpgsqlCommand(updateMobil, conn))
                        {
                            cmdMobil.Parameters.AddWithValue("id_mobil", mobilId);
                            cmdMobil.ExecuteNonQuery();
                        }

                        // Jika ada supir, ubah status-nya
                        if (supirId.HasValue)
                        {
                            string updateSupir = "UPDATE supir SET status = 'Tersedia' WHERE id_supir = @id_supir";
                            using (var cmdSupir = new NpgsqlCommand(updateSupir, conn))
                            {
                                cmdSupir.Parameters.AddWithValue("id_supir", supirId.Value);
                                cmdSupir.ExecuteNonQuery();
                            }
                        }

                        // Opsional: Hapus transaksi sewa atau tandai sebagai selesai
                        // Simpan ke tabel pengembalian
                        string insertPengembalian = "INSERT INTO pengembalian (id_sewa) VALUES (@id_sewa)";
                        using (var cmdPengembalian = new NpgsqlCommand(insertPengembalian, conn))
                        {
                            cmdPengembalian.Parameters.AddWithValue("id_sewa", selectedSewaId);
                            cmdPengembalian.ExecuteNonQuery();
                        }

                        


                        transaction.Commit();
                        MessageBox.Show("Mobil berhasil dikembalikan.");
                        LoadDataPengembalian(); // Refresh
                        selectedSewaId = -1;
                        mobilId = -1;
                        supirId = null;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Gagal mengembalikan mobil: " + ex.Message);
                    }
                }
            }
        }

        private void Pengembalian_Load(object sender, EventArgs e)
        {
            LoadDataPengembalian();
        }

        private void dataGridPengembalian_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridPengembalian.Rows[e.RowIndex];
                selectedSewaId = Convert.ToInt32(row.Cells["id_sewa"].Value);
                selectedMerek = row.Cells["merek"].Value.ToString();

                //if (row.Cells["id_supir"].Value != DBNull.Value)
                //    supirId = Convert.ToInt32(row.Cells["id_supir"].Value);
                //else
                //    supirId = null;
            }
        }

        private void LoadDataPengembalian()
        {
            using (var conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                string query = @"
            SELECT s.id_sewa, m.merek
            FROM sewa s
            JOIN mobil m ON s.id_mobil = m.id_mobil
            WHERE s.id_user = @user_id AND s.status_pengembalian = 'Belum'";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("user_id", Session.UserId); // ID user yang sedang login

                    using (var adapter = new NpgsqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridPengembalian.DataSource = dt;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserDashboard userDashboard = new UserDashboard();
            userDashboard.Show();
            this.Hide();
        }
    }
}
