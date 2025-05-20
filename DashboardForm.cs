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
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            comboBoxRole.Items.Add("Admin");
            comboBoxRole.Items.Add("User");
            comboBoxRole.Items.Add("Guest");
            comboBoxRole.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string role = comboBoxRole.SelectedItem.ToString();
            MessageBox.Show("Role dipilih: " + role);
        }
    }
}
