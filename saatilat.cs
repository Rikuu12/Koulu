// See https://aka.ms/new-console-template for more information
Console.Write("Paistaako aurinko (K/E) ? ");
string aurinko = Console.ReadLine();
Console.Write("Sataako vettä (K/E) ? ");
string sade = Console.ReadLine();
Console.Write("Onko lämpötila >0 (K/E) ? ");
string lampo = Console.ReadLine();
Console.WriteLine();

if (aurinko=="K" && sade=="K" && lampo=="K")
{
    Console.Write("Aurinko paistaa ja vettä sataa, taitaa tulla kesä.");
}
else if (aurinko == "E" && sade == "K" && lampo == "K")
{
    Console.Write("Syksy saapui tuuli vei lehdet mennessään.");
}
else if (aurinko == "E" && sade == "E" && lampo == "K")
{
    Console.Write("Jo joutui armas aika ja suvi suloinen.");
}
else if (aurinko == "K" && sade == "E" && lampo == "E")
{
    Console.Write("Keväinen talvi kesän tuo");
}
else
{
    Console.Write("Ompa erikoinen sää!");
}

