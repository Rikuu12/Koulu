using System;

namespace tehtävä4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tulostaa laskurin ja viivoituksen
            Console.WriteLine("VALUUTTALASKURI");
            Console.WriteLine("---------------");
            Console.WriteLine();

            // Tulostaa ja tallentaa annetun summan "summa" muuttujaan
            Console.Write("Anna summa euroina ? ");
            int summa = int.Parse(Console.ReadLine());
            Console.WriteLine();

            /*Tekee muuttujan joka laskee summan ja kertoo sen annetun kurssin mukaan. Muuttaa myös tulostamaan
            kahden desimaalin tarkkuudella.*/
            string dollaria = string.Format("{0,10:0.00}",summa * 1.21f);
            string puntaa = string.Format("{0,10:0.00}",summa * 0.87f);

            //Tulostaa lasketut summat
            Console.WriteLine(dollaria + " $");
            Console.WriteLine(puntaa + " £");

        }
    }
}
