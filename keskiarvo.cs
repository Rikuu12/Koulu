using System;

namespace tehtava9
{
    class Program
    {
        static void Main(string[] args)
        {
            int e;
            double summa =0;
            //tulostaa tehtävän
            Console.WriteLine("Tehtava 9");
            Console.WriteLine("-------------");
            Console.WriteLine();
            Console.WriteLine("Anna viisi lukua niin lasken niiden keskiarvon");
            //luo taulukon johon tallentuu annetut luvut
            double[] luvut = new double[5];
            //tallentaa annetut arvot luvut taulukkoon
            for (e = 0; e < 5; e++)
            {
                Console.Write("Anna " + (e + 1) + ".luku ? ");
                luvut[e] = double.Parse(Console.ReadLine());
            }
            //käy taulukosta annetut luvut vuorotellen läpi
            foreach (double luku in luvut)
            {
                summa = summa+luku;
            }
            //tulostaa ja laskee summan keskiarvon
            Console.WriteLine("Keskiarvo on "+ summa / 5);
        }
    }
}
