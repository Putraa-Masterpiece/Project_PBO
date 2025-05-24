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
    public partial class UserDashboard : Form
    {
        public UserDashboard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SewaKendaraan sewaKendaraan = new SewaKendaraan();
            sewaKendaraan.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProfilUser profil = new ProfilUser();
            profil.ShowDialog();
            this.Hide();
        }
    }
}
