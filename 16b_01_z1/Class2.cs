using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16b_01_z1
{
    class Class2 //dectohex;hextodec

    {
        public int wejscie;
        public string wynik;    
        public string wejscie2;
        public int wyjscie;
        public string wyjscie2;

        public void DecToHex()
        {
            wynik = Convert.ToString(wejscie, 16);
        }

        public void HexToDec()
        {
            wyjscie = int.Parse(wejscie2, System.Globalization.NumberStyles.HexNumber);
            wyjscie2 = wyjscie.ToString();
        }
    
    }
    }
