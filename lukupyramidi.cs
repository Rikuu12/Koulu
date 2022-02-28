Console.Write("Anna lukupyramidin kerrosten määrä ? ");
int kerroksia = int.Parse(Console.ReadLine());

for (int i = 1; i <= kerroksia; i++)
{
    Console.WriteLine();
    for (int j = 1; j <= i; j++)
    {
        Console.Write(j);
    }
    
}