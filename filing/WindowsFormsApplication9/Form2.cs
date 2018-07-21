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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Text = "File exist";
            this.button1.Text = "Exist";
            this.button2.Text = "Clear";
            this.button3.Text = "Cancel";
            this.label1.Text = "File Address";
            this.label2.Text = "File Name";
            string[] ext = { ".txt", ".docx", ".xlxs" };
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(ext);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text + textBox2.Text;
            textBox2.Text += comboBox1.Text;
            if (File.Exists(s))
            {
                
                MessageBox.Show("File Exist");
            }
            else
            {
                MessageBox.Show("File does not exist");
            }
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
