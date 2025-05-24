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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KelolaKendaraan kelolaKendaraan = new KelolaKendaraan();
            kelolaKendaraan.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataSupircs dataSupir = new DataSupircs();
            dataSupir.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Transaksi transaksi = new Transaksi();
            transaksi.Show();
            this.Hide();
        }
    }
}