// Aliohjelma
int laskuri(int summa1, int summa2, int summa3)
{
    int summa = summa1 + summa2 + summa3;
    return summa;
}
//muuttujat
int i = 1, j;
int luku1=0, luku2=0, luku3=0;
//tehtävänanto
Console.WriteLine("Tehtävä 13");
Console.WriteLine("----------");
Console.WriteLine();
Console.WriteLine("Anna 3 lukua niin lasken niiden summan...");
Console.WriteLine();
//looppi joka pyytää luvut
for (j = 1; j < 4; j++)
{
    Console.Write("Anna " + i++ + " luku ? ");
    int luku = int.Parse(Console.ReadLine());
    //määritetään muuttujat annetun luvun mukaan
    if (j==1)
    {
        luku1 = luku;
    }
    else if(j==2)
    {
        luku2 = luku;
    }
    else
    {
        luku3 = luku;
    }
    
}
//tulostetaan annetut luvut ja aliohjelma laskee ne yhteen
Console.WriteLine("Kolmen luvun " + luku1 + ", " + luku2 + " ja " + luku3 + " summa on " + laskuri(luku1, luku2, luku3));
