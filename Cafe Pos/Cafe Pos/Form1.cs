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
        }

       
        private void Sup_but_Click_1(object sender, EventArgs e)
        {
            suppier1.Show();
        }
    }
}
