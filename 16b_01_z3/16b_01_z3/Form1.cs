using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16b_01_z3
{
    public partial class Form1 : Form
    {
        public int a;
        public int b = 0;
        double[] tab;
        //public int c = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
            tab = new double[a];
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tab[b] = int.Parse(textBox1.Text);
            textBox1.Text = "";
            ++b;
            if (a == b)
            {
                textBox1.Enabled = false;
                label3.Text = "Podałeś wszystkie liczby. Wybierz sortowanie!";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Class1 oblicz = new Class1();
            oblicz.bombelkowe(tab);

                for (int j = 0; j < tab.Length; j++)
                {
                    label1.Text = label1.Text + ' ' + tab[j];
                }

                label2.Text = "Bąbelkowe :";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Class1 oblicz = new Class1();
            oblicz.selection(tab);

                for (int j = 0; j < tab.Length; j++)
                {
                    label1.Text = label1.Text + ' ' + tab[j];
                }

                label2.Text = "Selection Sort :";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Class1 oblicz = new Class1();
            oblicz.quicksort(tab, 0, tab.Length - 1);

                for (int j = 0; j < tab.Length; j++)
                {

                    label1.Text = label1.Text + ' ' + tab[j];

                }
                label2.Text = "Quick Sort :";

        }
    }
}
