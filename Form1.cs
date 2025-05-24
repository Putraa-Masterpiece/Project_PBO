using Npgsql;
using Project_PBO.Model;
using System;
using System.Windows.Forms;

namespace Project_PBO
{
    public partial class Form1 : Form
    {
        string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=12345;Database=project_pbo";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Harap isi username dan password!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT id_user, username, password, role FROM pengguna WHERE username = @username AND password = @password";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("username", username);
                        cmd.Parameters.AddWithValue("password", password);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Simpan ke session
                                Session.UserId = reader.GetInt32(0); // id_pengguna
                                Session.Username = reader.GetString(1);
                                Session.Role = reader.GetString(3);

                                MessageBox.Show("Login berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Pindah ke dashboard sesuai role
                                if (Session.Role == "admin")
                                {
                                    AdminDashboard admin = new AdminDashboard();
                                    admin.Show();
                                }
                                else
                                {
                                    UserDashboard user = new UserDashboard();
                                    user.Show();
                                }

                                this.Hide(); // Sembunyikan form login
                            }
                            else
                            {
                                MessageBox.Show("Username atau password salah!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm();
            register.ShowDialog();
          
        }
    }
}



        //    string username = txtUsername.Text;
        //    string password = txtPassword.Text;

//    // Validasi sederhana, bisa diganti dengan database
//    if (username == "admin" && password == "12345")
//    {
//        MessageBox.Show("Login berhasil!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

//        // Contoh membuka form baru setelah login
//        DashboardForm dashboard = new DashboardForm();
//        dashboard.Show();
//        this.Hide();
//    }
//    else
//    {
//        MessageBox.Show("Username atau password salah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//    }
//}


//}
