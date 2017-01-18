using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16b_01_z3
{
    class Class1
    {
        public void bombelkowe(double[] tab)
        {
            int n = tab.Length;
            do
            {
                for (int i = 0; i < n - 1; i++)
                {
                    if (tab[i] > tab[i + 1])
                    {
                        double tmp = tab[i];
                        tab[i] = tab[i + 1];
                        tab[i + 1] = tmp;
                    }
                }
                n--;
            }
            while (n > 1);


        }


        public void selection(double[] tab)
        {
            double temp;

            for (int i = 0; i < tab.Length - 1; i++)
            {
                int pos_min = i;

                for (int j = i + 1; j < tab.Length; j++)
                {
                    if (tab[j] < tab[pos_min])
                    {
                        pos_min = j;
                    }
                }
                if (pos_min != i)
                {
                    temp = tab[i];
                    tab[i] = tab[pos_min];
                    tab[pos_min] = temp;
                }


            }
        }
        public void quicksort(double[] tab, int left, int right)
        {
            var i = left;
            var j = right;
            var pivot = tab[(left + right) / 2];
            while (i < j)
            {
                while (tab[i] < pivot) i++;
                while (tab[j] > pivot) j--;
                if (i <= j)
                {

                    var tmp = tab[i];
                    tab[i++] = tab[j];
                    tab[j--] = tmp;
                }
            }
            if (left < j) quicksort(tab, left, j);
            if (i < right) quicksort(tab, i, right);

        }
    }
}