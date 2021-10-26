using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Pos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            suppier1.Hide();
            stock1.Hide();
            KitchenStock_but.Hide();

        }

       
        private void Sup_but_Click_1(object sender, EventArgs e)
        {
            suppier1.Show();
            KitchenStock_but.Hide();
            stock1.Hide();
        }

        private void Stock_but_Click(object sender, EventArgs e)
        {
            stock1.Show();
           KitchenStock_but.Hide();
            suppier1.Hide();
        }

        private void KitchenStok_but_Click(object sender, EventArgs e)
        {
            KitchenStock_but.Show();
            suppier1.Hide();
            stock1.Hide();
        }
    }
}
