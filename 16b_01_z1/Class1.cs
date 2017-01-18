using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16b_01_z1
{
    class Class1 //binarka
    {
        public string dane_a;// wejsciowe
        public int dane_b;//wyjsciowe
        public string dane_b2;


        public void bintToDec()
        {
            int c = 1;
            for (int i = dane_a.Length - 1; i >= 0; i--)
            {
                if (dane_a[i] == '1')
                {
                    dane_b = dane_b + c;
                    c = c * 2;
                }
            }
        }
        public void decToBin()
        {
            int liczba = int.Parse(dane_a);
            double[] tab1 = new double[1000];
            int i = 0;
            while (liczba > 0)
            {
                double reszta = liczba % 2;
                liczba /= 2;
                tab1[i] = reszta;
                i++;
            }

            for (int j = i - 1; j >= 0; j--)
            {
                dane_b2 = dane_b2 + tab1[j].ToString();

            }
        }
    }
}
