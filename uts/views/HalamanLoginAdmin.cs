using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uts.views
{
    public partial class HalamanLoginAdmin : Form
    {
        public HalamanLoginAdmin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonMasuk_Click(object sender, EventArgs e)
        {
            this.Hide();
            HalamanDashboardAdmin halamanDashboardAdmin = new HalamanDashboardAdmin();

            if (halamanDashboardAdmin.ShowDialog() != DialogResult.OK)
            {

            }
            this.Show();
        }

        private void buttonbatal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Hide();
        }
    }
}
