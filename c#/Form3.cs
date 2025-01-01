using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace C_Project01
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = comboBox1.SelectedItem.ToString();
            int index = selectedItem.IndexOf('$');
            double price = double.Parse(selectedItem.Substring(index + 1));
            double subtotal = double.Parse(textBox5.Text.Substring(1));
            double sum = price + subtotal;
            textBox5.Text = "$" + sum;
            double Tax = sum * 16 / 100;
            textBox4.Text = "$" + Tax;
            textBox3.Text = "$" + (Tax + sum);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }


        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = comboBox4.SelectedItem.ToString();
            int index = selectedItem.IndexOf('$');
            double price = double.Parse(selectedItem.Substring(index + 1));
            double subtotal = double.Parse(textBox5.Text.Substring(1));
            double sum = price + subtotal;
            textBox5.Text = "$" + sum;
            double Tax = sum * 16 / 100;
            textBox4.Text = "$" + Tax;
            textBox3.Text = "$" + (Tax + sum);

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = comboBox2.SelectedItem.ToString();
            int index = selectedItem.IndexOf('$');
            double price = double.Parse(selectedItem.Substring(index + 1));
            double subtotal = double.Parse(textBox5.Text.Substring(1));
            double sum = price + subtotal;
            textBox5.Text = "$" + sum;
            double Tax = sum * 16 / 100;
            textBox4.Text = "$" + Tax;
            textBox3.Text = "$" + (Tax + sum);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = comboBox3.SelectedItem.ToString();
            int index = selectedItem.IndexOf('$');
            double price = double.Parse(selectedItem.Substring(index + 1));
            double subtotal = double.Parse(textBox5.Text.Substring(1));
            double sum = price + subtotal;
            textBox5.Text = "$" + sum;
            double Tax = sum * 16 / 100;
            textBox4.Text = "$" + Tax;
            textBox3.Text = "$" + (Tax + sum);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox5.Text = "$0.00";
            textBox4.Text = "$0.00";
            textBox3.Text = "$0.00";
        }
    }
}
