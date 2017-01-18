using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16b_01_z2
{
    public partial class Form1 : Form
    {
        public int a;
        public int b=0;
        double[] tab;

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
                label3.Text = "Podałeś wszystkie liczby. Wybierz działanie!";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Class1 oblicz = new Class1();
            oblicz.srednia(tab);
            label1.Text = oblicz.liczba.ToString();
            label2.Text = "Średnia :";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Class1 oblicz = new Class1();
            oblicz.odchylenie(tab);
            label1.Text = oblicz.liczba.ToString();
            label2.Text = "Odchylenie :";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Class1 oblicz = new Class1();
            oblicz.rozstep(tab);
            label1.Text = oblicz.liczba.ToString();
            label2.Text = "Rozstęp :";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
