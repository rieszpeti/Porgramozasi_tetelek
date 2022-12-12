using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porgramozasi_tetelek
{
    static class EgyszeruEsOsszetettOsszeepitese
    {
        public static int MasolasEsSorozatSzamitas(int[] tomb)
        {
            int ertek = tomb[0];
            for (int i = 1; i < tomb.Length; i++)
            {
                ertek += tomb[i] / 2;
            }
            return ertek;
        }
        public static void MasolasEsMaximumKivalasztas(int[] tomb, ref int maxIndex, ref int maxErtek)
        {
            maxIndex = 0;
            maxErtek = tomb[0] / 2; // valamilyen fuggveny altal modositott ertek

            for (int i = 1; i < tomb.Length; i++)
            {
                int seged = tomb[i] / 2;      // itt modositani kell a tomb ertekeit valamilyen fv altal
                if (maxErtek < seged)
                {
                    maxIndex = i;
                    maxErtek = tomb[i];
                }
            }
        }
        public static bool MegszamolasEsKeres(int[] tomb, ref int index, int k) //tombben van-e legalabb k tulajdonsagu elem
        {
            int db = 0;
            int i = 0;

            while (i < tomb.Length && db < k)
            {
                if (tomb[i] % 2 == 0)           // ha paros akkor k tulajdonsagu
                {
                    db++;
                }
            }
            bool van = (db == k);
            if (van)
            {
                index = i;
                return van;
            }
            return false;
        }
        public static int[] MaximumKivalasztasEsKivalogatas(int[] tomb, ref int maxErtek, int k)
        {                   //Visszaadja az osszes max indexet, illetve a max erteket
            int[] kimenet = new int[tomb.Length];
            maxErtek = tomb[0];
            int db = 0;
            kimenet[db] = 0;

            for (int i = 1; i < tomb.Length; i++)
            {
                if (tomb[i] > maxErtek)
                {
                    maxErtek = tomb[i];
                    kimenet[db] = i;
                    db++;
                }
                else
                {
                    if (tomb[i] == maxErtek)
                    {
                        kimenet[db] = tomb[i];
                        db++;
                    }
                }
            }
            return kimenet;
        }
        public static int KivalogatasEsSorozatszamitas(int[] tomb)
        {
            int ertek = tomb[0];
            for (int i = 1; i < tomb.Length; i++)
            {
                if (tomb[i] % 2 == 0)       //ha paros akkor...
                {
                    ertek = tomb[i] + 2;
                }
            }
            return ertek;
        }
        public static bool KivalogatasEsMaximumKivalasztas(int[] tomb, ref int maxIndex, ref int maxErtek)
        {
            maxErtek = int.MinValue;                              // min value kell az elso paros elem megtalalasa vegett
            maxIndex = 0;
            for (int i = 1; i < tomb.Length; i++)
            {
                if (tomb[i] % 2 == 0 && tomb[i] > maxErtek)       //ha paros es nagyobb a max
                {
                    maxIndex = i;
                    maxErtek = tomb[i];
                }
            }
            bool van = (maxErtek > int.MinValue);
            if (van)
            {
                return van;
            }
            return false;
        }
        public static int[] KivalogatasEsMasolas(int[] tomb, ref int db)
        {
            int[] kimenet = new int[tomb.Length];
            db = 0;

            for (int i = 1; i < tomb.Length; i++)
            {
                if (tomb[i] % 2 == 0)
                {
                    kimenet[db] = tomb[i];
                    db++;
                }
            }

            return kimenet;
        }
    }
}
