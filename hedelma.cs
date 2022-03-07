using System;

namespace tehtava8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Tehtävä 8.1");
            Console.WriteLine();
            Console.WriteLine("-----------------");
            Console.WriteLine();
            Console.Write("Montako hedelmää haluat nähdä ? ");
            int maara = int.Parse(Console.ReadLine());
            string[] hedelmat = { "Omena", "Banaani", "Luumu" };
            for (i = 0; i < maara; i++)
            {
                Console.WriteLine(hedelmat[i]);
            }
        }
    }
}
