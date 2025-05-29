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
    public partial class RiwayatPengembalian : Form
    {
        private string connStr = "Host=localhost;Port=5432;Username=postgres;Password=12345;Database=project_pbo";
        public RiwayatPengembalian()
        {
            InitializeComponent();
        }

        private void RiwayatPengembalian_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadRiwayatPengembalian()
        {

            using (var conn = new NpgsqlConnection(connStr))
            {
                conn.Open();

                string query = @"
                    SELECT 
                        p.id_pengembalian,
                        p.id_sewa,
                        m.merek,
                        m.tipe,
                        s.tanggal_peminjaman,
                        s.tanggal_pengembalian AS tanggal_jatuh_tempo,
                        p.tanggal_pengembalian,
                        p.denda
                    FROM pengembalian p
                    JOIN sewa s ON p.id_sewa = s.id_sewa
                    JOIN mobil m ON s.id_mobil = m.id_mobil
                    WHERE s.id_user = @user_id
                    ORDER BY p.tanggal_pengembalian DESC";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("user_id", Session.UserId);

                    using (var adapter = new NpgsqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridRiwayatPengembalian.DataSource = dt;

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

        private void RiwayatPengembalian_Load_1(object sender, EventArgs e)
        {
            LoadRiwayatPengembalian();
        }
    }
}