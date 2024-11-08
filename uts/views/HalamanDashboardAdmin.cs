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
    public partial class HalamanDashboardAdmin : Form
    {
        public HalamanDashboardAdmin()
        {
            InitializeComponent();
        }

        private void buttonTambahKontak_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormKontakBaru formKontakBaru = new FormKontakBaru();

            if (formKontakBaru.ShowDialog() != DialogResult.OK)
            {

            }
            this.Show();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
