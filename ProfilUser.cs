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
    public partial class ProfilUser : Form
    {
        string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=12345;Database=project_pbo";
        public ProfilUser()
        {
            InitializeComponent();
        }

        private void ProfilUser_Load(object sender, EventArgs e)
        {
            LoadUserProfile();
        }

        private void LoadUserProfile()
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT username, email, nomer_telepon FROM pengguna WHERE username = @username";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("username", Session.Username);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtUsername.Text = reader["username"].ToString();
                                txtEmail.Text = reader["email"].ToString();
                                txtNoTelepon.Text = reader["nomer_telepon"].ToString();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal memuat profil: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            UserDashboard userDashboard = new UserDashboard();
            userDashboard.Show();
            this.Hide();
        }
    }
}
