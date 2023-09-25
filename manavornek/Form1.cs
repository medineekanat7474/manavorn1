using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manavornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            lstManav.Items.Add(txtsepet.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSepettenKaldır_Click(object sender, EventArgs e)
        {
            lstManav.Items.Clear();
        }

        private void lstManav_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSeçilenelemanisil_Click(object sender, EventArgs e)
        {
            lstManav.Items.Remove(lstManav.SelectedItem);
               
        }
    }
}
