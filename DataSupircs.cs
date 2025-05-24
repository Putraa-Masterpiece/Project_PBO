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
    public partial class DataSupircs : Form
    {
        string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=12345;Database=project_pbo";
        int selectedId = -1;
        public DataSupircs()
        {
            InitializeComponent();
        }

        private void txtNamaSupir_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataSupircs_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM supir ORDER BY id_supir";
                using (var da = new NpgsqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridSupir.DataSource = dt;
                }
            }
        }

        private void ClearForm()
        {
            txtNamaSupir.Text = "";
            txtNoTelepon.Text = "";
            selectedId = -1;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO supir (nama_supir, nomer_telepon) VALUES (@nama, @telepon)";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("nama", txtNamaSupir.Text);
                    cmd.Parameters.AddWithValue("telepon", txtNoTelepon.Text);
                    cmd.ExecuteNonQuery();
                }
            }

            LoadData();
            ClearForm();
            MessageBox.Show("Data supir berhasil disimpan.");
        }

        private void dataGridSupir_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridSupir_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridSupir.Rows[e.RowIndex];
                selectedId = Convert.ToInt32(row.Cells["id_supir"].Value);
                txtNamaSupir.Text = row.Cells["nama_supir"].Value.ToString();
                txtNoTelepon.Text = row.Cells["nomer_telepon"].Value.ToString();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnHapus_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnSimpan_Click_1(object sender, EventArgs e)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO supir (nama_supir, nomer_telepon) VALUES (@nama, @telepon)";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("nama", txtNamaSupir.Text);
                    cmd.Parameters.AddWithValue("telepon", txtNoTelepon.Text);
                    cmd.ExecuteNonQuery();
                }
            }

            LoadData();
            ClearForm();
            MessageBox.Show("Data supir berhasil disimpan.");
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            if (selectedId == -1)
            {
                MessageBox.Show("Pilih supir yang ingin diedit.");
                return;
            }

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE supir SET nama_supir = @nama, nomer_telepon = @telepon WHERE id_supir = @id";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("nama", txtNamaSupir.Text);
                    cmd.Parameters.AddWithValue("telepon", txtNoTelepon.Text);
                    cmd.Parameters.AddWithValue("id", selectedId);
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                        MessageBox.Show("Data supir berhasil diperbarui.");
                    else
                        MessageBox.Show("Gagal memperbarui data.");
                }
            }

            LoadData();
            ClearForm();
        }

        private void btnHapus_Click_1(object sender, EventArgs e)
        {
            if (selectedId == -1)
            {
                MessageBox.Show("Pilih supir yang ingin dihapus.");
                return;
            }

            var result = MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM supir WHERE id_supir = @id";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("id", selectedId);
                        cmd.ExecuteNonQuery();
                    }
                }

                LoadData();
                ClearForm();
                MessageBox.Show("Data supir berhasil dihapus.");
            }
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            AdminDashboard dashboard = new AdminDashboard();
            dashboard.Show();
            this.Hide();
        }
    }
}
