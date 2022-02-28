// See https://aka.ms/new-console-template for more information
Console.Write("Anna luku 1 ja 10 väliltä ? ");
int luku = int.Parse(Console.ReadLine());
Console.WriteLine();

for (int i = 1; i < 6; i++)
{
    int kerto = i * luku;
    int jako = i / luku;
    int jaannos = i % luku;
    Console.WriteLine(i + " * " + luku + " = " + kerto + "  " + i +
        " / " + luku + " = " + jako + "  " + i + " % "
        + luku + " = " + jaannos);
}