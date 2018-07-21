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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.Text = "Delete";
            this.label1.Text = "File Address";
            this.label2.Text = "File Name";
            this.button1.Text = "Delete";
            this.button2.Text = "Clear";
            this.button3.Text = "Cancel";
            string[] ext = { ".txt", ".docx", ".xlxs" };
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(ext);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
            this.textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text + textBox2.Text;
            textBox2.Text += comboBox1.Text;
            if (File.Exists(s))
            {
                File.Delete(s);
                MessageBox.Show("File Deleted");
            }
            else
            {
                MessageBox.Show("File does not exist");
            }
        }
    }
}
