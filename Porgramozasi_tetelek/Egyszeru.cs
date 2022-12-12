using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porgramozasi_tetelek
{
    static class Egyszeru
    {
        static int SorozatSzamitas(int[] tomb)
        {
            int ertek = tomb[0];
            for (int i = 1; i < tomb.Length; i++)
            {
                ertek += tomb[i];
            }
            return ertek;
        }
        static bool Eldontes(int[] tomb)
        {
            int i = 0;
            while (i < tomb.Length && tomb[i] != 2)
            {
                i++;
            }
            bool van = (i <= tomb.Length);
            return van;
        }
        static bool MindenElemEldontes(int[] tomb)
        {
            //Minden eleme 2?
            int i = 0;
            while (i < tomb.Length && tomb[i] == 2)
            {
                i++;
            }
            bool mindenEleme = (i > tomb.Length);
            return mindenEleme;
        }
        static bool PrimTeszt(int szam)
        {
            int i = 2;
            while (i < Math.Sqrt(szam) && (szam % i) == 0)
            {
                i++;
            }
            bool prim = (i > Math.Sqrt(szam));
            return prim;
        }
        static int Kivalasztas(int[] tomb, int szam)
        {
            int i = 0;
            while (tomb[i] != szam)
            {
                i++;
            }
            return i;
        }
        static int LinearisKereses(int[] tomb, int szam)
        {
            int i = 0;
            while (tomb[i] != szam)
            {
                i++;
            }
            if (i <= tomb.Length)
            {
                return i;
            }
            return -1;
        }
        static int Megszamlalas(int[] tomb)
        {
            int szamlalo = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] == 2)
                {
                    szamlalo++;
                }
            }
            return szamlalo;
        }
        static int MaximumKivalasztas(int[] tomb)
        {
            int max = 0;
            for (int i = 1; i < tomb.Length; i++)
            {
                if (tomb[max] < tomb[i])
                {
                    max = i;
                }
            }
            return max;
        }
    }
}
