using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛАБ_4_Кириленко
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.ResetText();
            if (string.IsNullOrEmpty(textBox1.Text))
                richTextBox1.AppendText("Element 1: NULL\n");
            else richTextBox1.AppendText("Element 1: " + textBox1.Text + '\n');
            if (string.IsNullOrEmpty(textBox2.Text))
                richTextBox1.AppendText("Element 2: NULL\n");
            else richTextBox1.AppendText("Element 2: " + textBox2.Text + '\n');
            if (string.IsNullOrEmpty(textBox3.Text))
                richTextBox1.AppendText("Element 3: NULL\n");


            else richTextBox1.AppendText("Element 3: " + textBox3.Text + 'n');
            if (string.IsNullOrEmpty(textBox4.Text))
                richTextBox1.AppendText("Element 4: NULL\n");


            else richTextBox1.AppendText("Element 4: " + textBox4.Text + '\n');
            if (string.IsNullOrEmpty(textBox5.Text))
                richTextBox1.AppendText("Element 5: NULL\n");
            else richTextBox1.AppendText("Element 5: " + textBox5.Text + '\n');
        }
    }
}
