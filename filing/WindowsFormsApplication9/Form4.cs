using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication9
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.Text = "Copy";
            this.label1.Text = "Source Address";
            this.label2.Text = "File Name";
            this.label3.Text = "Destination Address";
            this.label4.Text = "File Name";
            this.button1.Text = "Copy";
            this.button2.Text = "Clear";
            this.button3.Text = "Cancel";
            this.textBox4.ReadOnly = true;

            string[] ext = { ".txt", ".docx", ".xlxs" };
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(ext);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
            this.textBox2.Clear();
            this.textBox3.Clear();
            this.textBox4.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox4.Text = textBox2.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text + textBox2.Text;
            string d = textBox3.Text + textBox2.Text;
            textBox2.Text += comboBox1.Text;
            if (File.Exists(s))
            {
                File.Copy(s,d);
                MessageBox.Show("File Copied");
            }
            else
            {
                MessageBox.Show("File does not exist");
            }
        }
    }
}
