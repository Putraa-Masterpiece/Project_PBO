using Npgsql;
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
            using (var conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string username = txtUsername.Text;
                    string password = txtPassword.Text;

                    string query = "SELECT role FROM users WHERE username = @username AND password = @password";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("username", username);
                        cmd.Parameters.AddWithValue("password", password);

                        var roleObj = cmd.ExecuteScalar();

                        if (roleObj != null)
                        {
                            string role = roleObj.ToString();
                            MessageBox.Show("Login berhasil sebagai " + role + "!");

                            if (role == "Admin")
                            {
                                AdminDashboard admin = new AdminDashboard();
                                admin.Show();
                            }
                            else if (role == "User")
                            {
                                UserDashboard user = new UserDashboard();
                                user.Show();
                            }

                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Login gagal: Username atau password salah.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Koneksi gagal: " + ex.Message);
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
