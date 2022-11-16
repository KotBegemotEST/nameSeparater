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

namespace NameSeparater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> cities2 = new List<string>();
        List<string> university2 = new List<string>();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            {
                //local variables
                string line1;
                System.IO.StreamReader file = new System.IO.StreamReader("cities.txt");

                while ((line1 = file.ReadLine()) != null)
                {
                    listBox1.Items.Add(line1);
                    cities2.Add(line1);

                }

            }


            {
                //local variales
                string line2;
                System.IO.StreamReader file2 = new System.IO.StreamReader("unversities.txt");

                while ((line2 = file2.ReadLine()) != null) { 
                    listBox2.Items.Add(line2);
                    university2.Add(line2);
                }
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            string сity = textBox1.Text;
            int i = 0;
            while (i < cities2.Count)
            {
                if (cities2[i] == сity)
                {
                    MessageBox.Show("city is popular");
                }
                i++;
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e)
        {
            string uni = textBox2.Text;
            int k = 0;
            while (k < university2.Count)
            {
                if (university2[k] == uni)
                {
                    MessageBox.Show("uni is popular");
                }
                k++;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
