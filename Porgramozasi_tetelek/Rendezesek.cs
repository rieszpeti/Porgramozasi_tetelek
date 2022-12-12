using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porgramozasi_tetelek
{
    static class Rendezesek
    {
        public static void EgyszeruCseresRendezes(ref int[] tomb) 
        {
            for (int i = 0; i < tomb.Length - 1; i++)
            {
                for (int j = i + 1; j < tomb.Length; j++)
                {
                    if (tomb[i] > tomb[j])
                    {
                        int tmp = tomb[i];
                        tomb[i] = tomb[j];
                        tomb[j] = tmp;
                    }
                }
            }
        }
        public static void MinimumKivalasztasRendezes(ref int[] tomb)
        {
            for (int i = 0; i < tomb.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < tomb.Length; j++)
                {
                    if (tomb[min] > tomb[j])
                    {
                        min = j;
                    }
                }
                int tmp = tomb[i];
                tomb[i] = tomb[min];
                tomb[min] = tmp;
            }
        }
        public static void BuborekRendezes(ref int[] tomb)
        {
            for (int i = tomb.Length; i > 1; i--)   // i-t mindig csokkentjuk mert az utolso elem mindig a legnagyobb lesz csere utan
            {
                for (int j = 0; j < i - 1; j++)     
                {
                    if (tomb[j] > tomb[j + 1])      // ha nagyobb a j elem a j+1-nel akkor csere 
                    {
                        int tmp = tomb[j];
                        tomb[j] = tomb[j + 1];
                        tomb[j + 1] = tmp;
                    }
                }
            }
        }
        public static void BuborekRendezesJavitott(ref int[] tomb)
        {
            int i = tomb.Length;
            while (i >= 1)
            {
                int index = 0;                      // index segitsegevel csak addig megyunk ameddig tenyleg kell
                for (int j = 0; j < i - 1; j++)
                {
                    if (tomb[j] > tomb[j + 1])      // ha nagyobb a j elem a j+1-nel akkor csere 
                    {
                        int tmp = tomb[j];
                        tomb[j] = tomb[j + 1];
                        tomb[j + 1] = tmp;
                        index = j;
                    }
                }
                i = index;                          // atadjuk az i-nek az indexet,
                                                    // igy nem kell kell mindig bejarni a tombot ha mar rendezett lenne
            }
        }
        public static void BeillesztesesRendezes(ref int[] tomb) // resztombokre bontva rendezzuk a tombot
        {
            for (int i = 1; i < tomb.Length - 1; i++)            // mindig i-ig rendezunk
            {
                int j = i - 1;
                while (j > 0 && tomb[j] > tomb[j + 1])           // ha nagyobb a j-dik elem a j + 1-nel akkor csere
                {
                    int tmp = tomb[j];
                    tomb[j] = tomb[j + 1];
                    tomb[j + 1] = tmp;
                    j--;
                }
            }
        }
        public static void BeillesztesesRendezesJavitott(ref int[] tomb) // resztombokre bontva rendezzuk a tombot
        {
            for (int i = 1; i < tomb.Length - 1; i++)            // mindig i-ig rendezunk
            {
                int j = i - 1;
                int seged = tomb[j];
                while (j > 0 && tomb[j] > seged)           // ha nagyobb a j-dik elem a segednel akkor csere, mig a helyere nem kerul
                {
                    int tmp = tomb[j];
                    tomb[j] = tomb[j + 1];
                    tomb[j + 1] = tmp;
                    j--;
                }
                tomb[j + 1] = seged;
            }
        }
       
        //javitott Beilleszteses
        public static void ShellRendezes(ref int[] tomb, int d) // resztombokre bontva rendezzuk a tombot
        {
            d = tomb.Length / 2;
            int k = 2;
            while (d >= 1)
            {
                for (int i = d + 1; i < tomb.Length; i++)
                {
                    int j = i - d;
                    int seged = tomb[i];
                    while (j > 0 && tomb[j] > seged)
                    {
                        tomb[j + d] = tomb[j];
                        j = j - d;
                    }
                    tomb[j + d] = seged;
                }
                d = (int)(tomb.Length / Math.Pow(2, k)); // Donald Shell javaslata n / k^2
                k++;
            }
        }
    }
}
