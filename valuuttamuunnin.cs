using System;

namespace valuuttamuunnin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("VALUUTTALASKURI");
            Console.WriteLine("---------------");
            Console.WriteLine();
            Console.Write("Anna summa euroina ? ");
            double summa = int.Parse(Console.ReadLine());

            Console.Write("Vastaa 1 jos haluat muuntaa dollareiksi ja 2 jos haluat muuntaa punniksi ? ");
            int valinta = int.Parse(Console.ReadLine());
            Console.WriteLine();
            string tulos = string.Format("{0,10:0.00}", summa * 1.21);
            string tulos2 = string.Format("{0,10:0.00}", summa * 0.87);
            if (valinta == 1)
            {
                Console.WriteLine(tulos + "$");
            }
            else
            {
                Console.WriteLine(tulos2 + "£");
            }

        }
    }
}
