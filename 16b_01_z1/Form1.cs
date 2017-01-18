using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16b_01_z1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 oblicz = new Class1();
            oblicz.dane_a = textBox1.Text;
            oblicz.bintToDec();
            label1.Text = oblicz.dane_b.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
                label1.Text = "0";
            }
            else
            {
                Class1 oblicz = new Class1();
                oblicz.dane_a = textBox1.Text;
                oblicz.decToBin();
                label1.Text = oblicz.dane_b2.ToString();
            }
        }

        public void button3_Click(object sender, EventArgs e)
        {
            Class2 oblicz = new Class2();
            oblicz.wejscie = int.Parse(textBox1.Text);
            oblicz.DecToHex();
            label1.Text = oblicz.wynik.ToString();
            // z decymalki na hex
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Class2 oblicz = new Class2();
            oblicz.wejscie2 = textBox1.Text;
            oblicz.HexToDec();
            label1.Text = oblicz.wyjscie2;
        }
    }
}