// See https://aka.ms/new-console-template for more information
//muuttujat esitellään
int i=1, kokoluku;
Console.WriteLine("Tehtävä 11");
Console.WriteLine();
Console.WriteLine("----------");
Console.WriteLine();
//luodaan lista nimeltä kokoluvut
List<int> kokoluvut = new List<int>();
//looppi joka käy 5 kertaa läpi ja tallentaa tehdylle listalle luvun
for (int j = 0; j < 5; j++)
{
    Console.Write(i++ + ". listan luku ? ");
    kokoluku =int.Parse(Console.ReadLine());
    kokoluvut.Add(kokoluku);
    Console.WriteLine();
}
//looppi joka tulostaa listaan tallennetut luvut
for (int j = 0; j < 5; j++)
{
    Console.WriteLine(kokoluvut[j]);
}
