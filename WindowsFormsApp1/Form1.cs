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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Files bbb = new Files();
            
            string s = bbb.read();
            listBox1.Items.Clear();
            listBox1.Items.Add(s);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Files bbb = new Files();
            bbb.Write(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Files bbb = new Files();
            MessageBox.Show("Count of repeated number of numbers: " + bbb.Transform().ToString());
        }
    }
}
