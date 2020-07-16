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
    public partial class Homework : UserControl
    {
        public Homework()
        {
            InitializeComponent();
        }

        int x = 10;

        public void addItem(string text)
        {
            TodoItem item = new TodoItem(text);
            panel1.Controls.Add(item);
            item.Top = x;
            x = (item.Top + item.Height + 10);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string hwName = HomeworkTextBox.Text;
            addItem(hwName);
            HomeworkTextBox.Text = "";
        }
    }
}
