using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tombok_2
{
    class Program
    {
        static int[] RandomTmb = new int[20];
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            //Random szémokkal való tömb feltöltés
            Feladat1TombFeltoltes();
            Console.WriteLine("\n-------------------\n");
            Feladat2TombElemekKiiratasa();
            Console.WriteLine("\n-------------------\n");
            Feladat3OsszegzesAtlagolas();
            Console.WriteLine("\n-------------------\n");
            Feladat4Leszamolas();
            Console.WriteLine("\n-------------------\n");
            Feladat5Rendezes();
            Console.WriteLine("\n-------------------\n");
            Feledat6Minimum();
            Console.ReadKey();
        }

        private static void Feledat6Minimum()
        {
            Console.WriteLine("6.Feladatad: Minimum kiválasztás");
            int Minimum = int.MaxValue;
            int MinimumHely = 0;
            for (int i = 0; i < 20; i++)
            {
                if(RandomTmb[i]<Minimum)
                {
                    Minimum = RandomTmb[i];
                    MinimumHely = i + 1;
                }
            }
            Console.WriteLine("\tA tömb legkisebb elem: {0}", Minimum);
            Console.WriteLine("\tA tömb legkisebb elem helye a tömbben: {0}", MinimumHely);
        }

        private static void Feladat5Rendezes()
        {
            Console.WriteLine("5.Feladat: Tömb eleminek rendezése, rendező algoritmus nélkül");
            Array.Sort(RandomTmb);//Növekvő sorrenbe teszi az elemekt
            Array.Reverse(RandomTmb);//csökkenő sorrendbe teszi a már korábban rendezett tömböt
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("\t{0:00}. elem -> {1}", i + 1, RandomTmb[i]);
            }
        }

        private static void Feladat4Leszamolas()
        {
            Console.WriteLine("4.Feladat: A felhasználó által bekért szám hányszor fordul elő a tömbömben");
            Console.Write("\tKérem adjon meg egy tetszöleges értéket 1 és 35 között: ");
            int Keresett = int.Parse(Console.ReadLine());
            int db = 0;
            for (int i = 0; i < 20; i++)
            {
                if(RandomTmb[i]==Keresett)
                {
                    db++;
                }
            }
            if(db>0)
            {
                Console.WriteLine("\tA felhasználó által adott érték benne van a tömbben {0}-szor", db);
            }
            else
            {
                Console.WriteLine("\tSajnos a keresett szám nincs benne a tömbben");
            }
        }

        private static void Feladat3OsszegzesAtlagolas()
        {
            Console.WriteLine("3.Feladat a tömb eleminek összege, átlaga");
            double Osszeg = 0;
            double Atlag = 0;
            /*//foreach az egy for ciklus, annyi a különbség, hogy megállás nélkül 
            //végig fog menni minden alkalommal a tömbön vagy a listán
            foreach (var r in RandomTmb) 
            {
                Osszeg += r; //r a random tömb aktuális elemét jelöli minden alkalommal
            }
            Console.WriteLine("A tömböm eleminek összege: {0}", Osszeg);
            Atlag = Osszeg / 20;
            Console.WriteLine("A tömb eleminek átlaga: {0:0.00}", Atlag);*/
            for (int i = 0; i < 20; i++)
            {
                Osszeg += RandomTmb[i];
                Atlag = Osszeg / 20;
            }
            Console.WriteLine("A tömböm eleminek összege: {0}", Osszeg);
            Console.WriteLine("A tömböm eleminek átlaga: {0:0.00}", Atlag);
        }

        private static void Feladat2TombElemekKiiratasa()
        {
            Console.WriteLine("2.Feladat: Tömb elemeinek kiíratása");
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("\t{0:00}. elem -> {1}", i+1, RandomTmb[i]);
            }
        }

        private static void Feladat1TombFeltoltes()
        {
            Console.WriteLine("1.Feladat: Tömb feltöltés");
            RandomTmb = new int[20];
            for (int i = 0; i < 20; i++)
            {
                RandomTmb[i] = rnd.Next(1,35);
            }
        }
    }
}
