using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
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
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string currentText = textBox1.Text;
            currentText += "1";
            textBox1.Text = currentText;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string currentText = textBox1.Text;
            currentText += "2";
            textBox1.Text = currentText;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string currentText = textBox1.Text;
            currentText += "3";
            textBox1.Text = currentText;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            string currentText = textBox1.Text;
            currentText += "4";
            textBox1.Text = currentText;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            string currentText = textBox1.Text;
            currentText += "5";
            textBox1.Text = currentText;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            string currentText = textBox1.Text;
            currentText += "6";
            textBox1.Text = currentText;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            string currentText = textBox1.Text;
            currentText += "7";
            textBox1.Text = currentText;
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            string currentText = textBox1.Text;
            currentText += "8";
            textBox1.Text = currentText;
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            string currentText = textBox1.Text;
            currentText += "9";
            textBox1.Text = currentText;
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            string currentText = textBox1.Text;
            currentText += "*";
            textBox1.Text = currentText;
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            string currentText = textBox1.Text;
            currentText += "-";
            textBox1.Text = currentText;
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            string currentText = textBox1.Text;
            currentText += "/";
            textBox1.Text = currentText;
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            string currentText = textBox1.Text;
            currentText += "+";
            textBox1.Text = currentText;
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            string currentText = textBox1.Text;
            currentText += "0";
            textBox1.Text = currentText;
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            try
            {
                DataTable table = new DataTable();
                var result = table.Compute(textBox1.Text, ""); 
                textBox1.Text = result.ToString(); 
            }
            catch (Exception ex) 
            {
                textBox1.Text = "Ошибка";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}


