using OOP_AccessModifiers.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_AccessModifiers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Category c = new Category(textBox1.Text, textBox2.Text);
            listBox1.Items.Add(c);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if(listBox1.SelectedItem!=null)
                {
                    Product p = new Product(textBox3.Text, Convert.ToDecimal(textBox4.Text),listBox1.SelectedItem as Category );
                    (listBox1.SelectedItem as Category).Products.Add(p);
                }
                else
                {
                    MessageBox.Show("Please select a Category");
                }
            }
            catch
            {
                MessageBox.Show("Please input in correct format");

            }

        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();


            if(listBox1.SelectedItem != null)
            {
                Text = (listBox1.SelectedItem as Category).Name;

                foreach(Product item in (listBox1.SelectedItem as Category).Products)
                {
                    listBox2.Items.Add(item);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = -1;
        }

        private void listBox2_Click(object sender, EventArgs e)
        {
            if(listBox2.SelectedItem!=null)
            {
                MessageBox.Show((listBox2.SelectedItem as Product).ReflectInfo());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            listBox2.Items.Clear();
        }
    }
}
