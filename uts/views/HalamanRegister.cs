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
    public partial class HalamanRegister : Form
    {
        public HalamanRegister()
        {
            InitializeComponent();
        }

        private void labelRegister_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            HalamanKontak halamanKontak = new HalamanKontak();

            if (halamanKontak.ShowDialog() != DialogResult.OK)
            {

            }
            this.Show();
        }

        private void textBoxNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonbatal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Hide();
        }
    }
}
