using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porgramozasi_tetelek
{
    static class Rekurziv
    {
        public static int FaktorialisIterativ(int n)
        {
            int ertek = 1;
            for (int i = 1; i < n; i++)
            {
                ertek = ertek * i;
            }
            return ertek;
        }
        public static int FaktorialisRekurziv(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * FaktorialisRekurziv(n - 1);
            }
        }
        public static int FibonacciIterativ(int n)
        {
            int aktualis = 1;
            int elozo = 1;
            for (int i = 0; i < n - 1; i++)
            {
                int atmeneti = aktualis + elozo;
                elozo = aktualis;
                aktualis = atmeneti;
            }
            return aktualis;
        }
        public static int FibonacciRekurziv(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            else
            {
                return FibonacciRekurziv(n - 2) + FibonacciRekurziv(n - 1);
            }
        }
        public static int HatvanyozasIterativan(int a, int n)
        {
            int ertek = a;
            for (int i = 1; i < n; i++)
            {
                ertek = ertek * a;
            }
            return ertek;
        }
        public static int HatvanyozasRekurziv(int a, int n)
        {
            if (n == 1)
            {
                return a;
            }
            else
            {
                return a * HatvanyozasRekurziv(a, n - 1);
            }
        }
        public static int HatvanyozasFelezesselRekurzivan(int a, int n)
        {
            if (n == 1)
            {
                return a;
            }
            else
            {
                if (n % 2 == 0)
                {
                    int seged = HatvanyozasFelezesselRekurzivan(a, n / 2);
                    return seged * seged;
                }
                else
                {
                    int seged = HatvanyozasFelezesselRekurzivan(a, (n - 1) / 2);
                    return a * seged * seged;
                }
            }
        }
    }
}
