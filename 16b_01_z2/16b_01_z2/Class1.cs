using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16b_01_z2
{
    class Class1
    {
        public double liczba;
        public double wynik = 0;
        public double minimum, maximum;//

        public void srednia(double[] tab)// liczenie sredniej
        {
            for (int i = 0; i < tab.Length; i++)

            {
                wynik = wynik + tab[i];

            }

                liczba = wynik / tab.Length;
        }

        public void odchylenie(double[] tab)
        {
            double odchylenie_2;

            for (int i = 0; i < tab.Length; i++)
            {
                wynik = wynik + tab[i];

            }
            odchylenie_2 = wynik / tab.Length;

            for (int i = 0; i < tab.Length; i++)
            {
                liczba = liczba + Math.Pow(tab[i] - odchylenie_2, 2);


            }

            liczba = liczba / tab.Length;
            liczba = Math.Sqrt(liczba);

        }

        public void rozstep(double[] tab)//rozstep-->najwieksza-najmniejsza
        {
            maximum = tab[0];
            minimum = tab[0];
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] > maximum)
                {
                    maximum = tab[i];
                }

                if (tab[i] < minimum)
                {
                    minimum = tab[i];
                }
            }
            liczba = maximum - minimum;
        }

    }
}
