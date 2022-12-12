using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porgramozasi_tetelek
{
    static class Osszetett
    {
        static int[] Masolas(int[] tomb)
        {
            int[] kimenet = new int[tomb.Length];
            for (int i = 0; i < tomb.Length; i++)
            {
                kimenet[i] = tomb[i] + 1;
            }
            return kimenet;
        }
        static int[] Kivalogatas(int[] tomb)
        {
            int[] kimenet = new int[tomb.Length];
            int szamlalo = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] == 2)
                {
                    kimenet[szamlalo] = tomb[i];
                    szamlalo++;
                }
            }
            return kimenet;
        }
        static int KivalogatasEredetiTombben(ref int[] tomb)
        {
            int szamlalo = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] == 2)
                {
                    tomb[szamlalo] = tomb[i];
                    szamlalo++;
                }
            }
            return szamlalo;
        }
        static int KivalogatasEredetiTombbenElemekMegtartasaval(int[] tomb)
        {
            int szamlalo = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] == 2)
                {
                    int tmp = tomb[i];
                    tomb[i] = tomb[szamlalo];
                    tomb[szamlalo] = tmp;
                    szamlalo++;
                }
            }
            return szamlalo;
        }
        public static void Szetvalogatas(int[] tombBe, ref int[] tomb1, ref int db1, ref int[] tomb2, ref int db2)
        {
            for (int i = 0; i < tombBe.Length; i++)
            {
                if (tombBe[i] == 2)
                {
                    tomb1[db1] = tombBe[i];
                    db1++;
                }
                else
                {
                    tomb2[db2] = tombBe[i];
                    db2++;
                }
            }
        }
        public static int[] SzetvalogatasEgyetlenUjTombbe(int[] tomb, ref int db)
        {
            int[] kimenet = new int[tomb.Length];
            db = 0;
            int jobb = tomb.Length;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] % 2 == 0)
                {
                    kimenet[db] = tomb[i];
                    db++;
                }
                else
                {
                    kimenet[jobb] = tomb[i];
                    jobb--;
                }
            }
            return kimenet;
        }
        public static int KivalogatasEredetiTombbenElemekMegtartasavalSzepen(ref int[] tomb) // szep megoldas kivalogatasra ugyanazon tombben
        {
            int bal = 0;
            int jobb = tomb.Length;
            int seged = tomb[0];
            int db = 0;
            while (bal < jobb)
            {
                while (bal < jobb && tomb[jobb] % 2 != 0)
                {
                    jobb--;
                }
                if (bal < jobb)
                {
                    tomb[bal] = tomb[jobb];
                    bal++;
                    while (bal < jobb && tomb[bal] % 2 == 0)
                    {
                        bal++;
                    }
                    if (bal < jobb)
                    {
                        tomb[jobb] = tomb[bal];
                        jobb--;
                    }
                }
            }
            tomb[bal] = seged;
            if (tomb[bal] % 2 == 0)
            {
                db = bal;
            }
            else
            {
                db = bal - 1;
            }
            return db;
        }
        public static int[] Metszet(int[] tomb1, int[] tomb2, ref int db)
        {
            int[] kimenet = new int[tomb1.Length + tomb2.Length];
            db = 0;

            for (int i = 0; i < tomb1[i]; i++)
            {
                int j = 0;
                while (j < tomb2.Length && tomb1[i] != tomb2[j])
                {
                    j++;
                }
                if (j <= tomb2.Length)
                {
                    kimenet[db] = tomb1[i];
                    db++;   
                }
            }
            return kimenet;
        }
        public static int[] Unio(int[] tomb1, int[] tomb2, ref int db)
        {
            int[] kimenet = new int[tomb1.Length + tomb2.Length];

            for (int i = 0; i < tomb1.Length; i++)
            {
                kimenet[i] = tomb1[i];
            }

            db = tomb1.Length;

            for (int i = 0; i < tomb2.Length; i++)
            {
                int j = 0;
                while (j < tomb2.Length && tomb1[j] != tomb2[i])
                {
                    j++;
                }
                if (j > tomb1.Length)
                {
                    kimenet[db] = tomb2[i];
                    db++;
                }
            }
            return kimenet;
        }
        public static int IsmetlodesekKiszurese(ref int[] tomb)
        {
            int db = 0;
            for (int i = 1; i < tomb.Length; i++)
            {
                int j = 0;
                while (j <= db && tomb[i] != tomb[j])
                {
                    j++;
                }
                if (j > db)
                {
                    tomb[db] = tomb[i];
                    db++;
                }
            }
            return db;
        }
        public static int[] OsszefuttatasStrazsaElemmel(int[] tomb1, int[] tomb2, ref int db) // Rendezett tombok
        {
            Array.Resize(ref tomb1, tomb1.Length + 1); // hozzaadok a tombok vegehez egy-egy legnagyobb letezo int elemet
            tomb1[tomb1.Length] = int.MaxValue;

            Array.Resize(ref tomb2, tomb2.Length + 1);
            tomb1[tomb2.Length] = int.MaxValue;

            int[] kimenet = new int[tomb1.Length + tomb2.Length];
            db = 0;

            int i = 0;
            int j = 0;

            while (i < tomb2.Length || j < tomb2.Length)
            {
                if (tomb1[i] < tomb2[j])
                {
                    kimenet[db] = tomb1[i];
                    i++;
                }
                else if (tomb1[i] > tomb2[j])
                {
                    kimenet[db] = tomb2[i];
                    j++;
                }
                else
                {
                    kimenet[db] = tomb1[i];                 // ha a ket elem egyenlo akkor 
                    i++;                                    // iteralok mindkettovel es az egyik elemet beteszem a tombbe
                    j++;
                }
            }
            return kimenet; // ref db
        }
    }
}
