using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6_26
{
    public partial class TodoItem : UserControl
    {
        public TodoItem()
        {
            InitializeComponent();
            
        }

        public TodoItem(string text)
        {
            InitializeComponent();
            lbl.Text = text;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
