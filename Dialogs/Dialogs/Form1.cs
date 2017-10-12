using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dialogs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Orange");
            listBox1.Items.Add("Pineapple");
            listBox1.Items.Add("Apple");
            listBox1.Items.Add("Wattermelon");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                string msg = "Please select an item";
                MessageBox.Show(msg);
            }
            else
            {
                label1.Text = listBox1.Text;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string msg = "Are you sure?!";
            if (MessageBox.Show(msg, this.Text, MessageBoxButtons.YesNoCancel) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
