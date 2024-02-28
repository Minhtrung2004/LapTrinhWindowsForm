using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchName searchName = new SearchName();
            searchName.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TinhDiemHB tinhDiemHB = new TinhDiemHB();
            tinhDiemHB.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SearchNganh searchNganh = new SearchNganh();
            searchNganh.ShowDialog();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
