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
    public partial class HalamanWelcome : Form
    {
        public HalamanWelcome()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            HalamanRegister halamanRegister = new HalamanRegister();

            if (halamanRegister.ShowDialog() == DialogResult.OK)
            {

            }
            this.Show();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            HalamanLoginAdmin halamanLoginAdmin = new HalamanLoginAdmin();

            if (halamanLoginAdmin.ShowDialog() == DialogResult.OK)
            {

            }
            this.Show();
        }

        private void buttonKontak_Click(object sender, EventArgs e)
        {
            this.Hide();
            HalamanKontak halamanKontak = new HalamanKontak();

            if (halamanKontak.ShowDialog() != DialogResult.OK)
            {

            }
            this.Show();
        }
    }
}
