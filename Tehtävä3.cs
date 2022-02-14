using System;

namespace tehtävä3
{
    class Program
    {
        static void Main(string[] args)
        {
            float pituus;
            Console.Write("Anna pituutesi senttimetreinä ? ");
            pituus = float.Parse(Console.ReadLine());
            Console.WriteLine();

            string metria = string.Format("{0:0.00}", pituus / 100f);
            string mailia = string.Format("{0:0.00}", pituus / 160934f);
            string jaardia = string.Format("{0:0.00}", pituus / 91.44f);
            string tuumaa = string.Format("{0:0.00}", pituus / 2.54f);
            Console.WriteLine( metria+ " metriä");
            Console.WriteLine( mailia + " mailia");
            Console.WriteLine( jaardia + " jaardia");
            Console.WriteLine( tuumaa + " tuumaa");
        }
    }
}
