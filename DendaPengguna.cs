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
    public partial class DendaPengguna : Form
    {
        private int selectedPengembalianId = -1;
        private string connStr = "Host=localhost;Port=5432;Username=postgres;Password=12345;Database=project_pbo";
        public DendaPengguna()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                selectedPengembalianId = Convert.ToInt32(row.Cells["id_pengembalian"].Value);
                txtDenda.Text = row.Cells["denda"].Value.ToString();
            }
        }
        private void DendaPengguna_Load(object sender, EventArgs e)
        {
            using (var conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                string query = @"
SELECT 
    pb.id_pengembalian,
    pgn.username,
    m.merek,
    s.tanggal_peminjaman AS tanggal_sewa,
    s.tanggal_pengembalian AS tanggal_jatuh_tempo,
    pb.tanggal_pengembalian,
    pb.denda
FROM 
    pengembalian pb
JOIN 
    sewa s ON pb.id_sewa = s.id_sewa
JOIN 
    pengguna pgn ON s.id_user = pgn.id_user
JOIN 
    mobil m ON s.id_mobil = m.id_mobil
ORDER BY 
    pb.id_pengembalian";


                using (var da = new NpgsqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void btnSimpanDenda_Click(object sender, EventArgs e)
        {
            if (selectedPengembalianId == -1)
            {
                MessageBox.Show("Pilih data pengembalian terlebih dahulu.");
                return;
            }

            if (!decimal.TryParse(txtDenda.Text, out decimal denda))
            {
                MessageBox.Show("Masukkan nilai denda yang valid.");
                return;
            }

            using (var conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                string query = "UPDATE pengembalian SET denda = @denda WHERE id_pengembalian = @id";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@denda", denda);
                    cmd.Parameters.AddWithValue("@id", selectedPengembalianId);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Denda berhasil disimpan.");
            DendaPengguna_Load(null, null); // reload data
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminDashboard admindashboard = new AdminDashboard();   
            admindashboard.Show();
            this.Hide();
        }
    }

}       
