using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uts.apss.Context;

namespace uts.views
{
    public partial class HalamanKontak : Form
    {
        public HalamanKontak()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            HalamanWelcome halamanWelcome = new HalamanWelcome();

            if (halamanWelcome.ShowDialog() != DialogResult.OK)
            {
                //LoadDataKontak;
            }
            this.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //LoadDataKontak;
        }

        private void LoadDataKontak()
        {
            {
            //    try
            //    {
            //        dataGridView1.AllowUserToAddRows = false;

            //        LoadDataKontak();
                }

            }
        }
    }
}
