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
    public partial class Transaksi : Form
    {
        string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=12345;Database=project_pbo";
        public Transaksi()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Transaksi_Load(object sender, EventArgs e)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
SELECT 
    sewa.id_sewa,
    sewa.id_user,
    sewa.id_mobil,
    sewa.id_supir,
    sewa.durasi_peminjaman,
    sewa.tanggal_peminjaman,
    sewa.total_harga,
    sewa.dengan_supir,
    pengembalian.tanggal_pengembalian
FROM 
    sewa
LEFT JOIN 
    pengembalian ON sewa.id_sewa = pengembalian.id_sewa
ORDER BY 
    sewa.id_sewa";

                using (var da = new NpgsqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridTransaksi.DataSource = dt;
                }
            }
        }

        //private void button1_Click(object sender, EventArgs e)
        //{

        //}

        private void btnKembali_Click(object sender, EventArgs e)
        {
            AdminDashboard dashboard = new AdminDashboard();
            dashboard.Show();
            this.Hide();
        }

        private void dataGridTransaksi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
