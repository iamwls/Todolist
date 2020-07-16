using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6_26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            food1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            homework1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            date1.BringToFront();
        }
    }
}
