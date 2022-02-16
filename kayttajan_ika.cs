// See https://aka.ms/new-console-template for more information

//Kysyy käyttäjän iän ja tallentaa muuttujaan
Console.Write("Minkä ikäinen olet ? ");
int ika = int.Parse(Console.ReadLine());
//Kysyy käyttäjän sukupuolen ja tallentaa muuttujaan
Console.Write("Olet nainen vai mies (N/M) ? ");
string sukup = Console.ReadLine();
/*valitsee vaihtoehtojen eli iän ja sukupuolen mukaan järjestyksessä käyden minkä
vastauksen antaa tulostukseen*/
if (ika < 14 && sukup == "M")
{
    Console.Write("Mitäs poitsu ?");
}
else if (ika < 26 && sukup == "M")
{
    Console.Write("Mitäs nuori mies ?");
}
else if (ika < 57 && sukup == "M")
{
    Console.Write("Olet mies parhaassa iässä !");
}
else if (ika > 56 && sukup == "M")
{
    Console.Write("Mitäs vanha ukko ?");
}
else if (ika < 14 && sukup == "N")
{
    Console.Write("Mitäs tyttö ?");
}
else if (ika < 26 && sukup == "N")
{
    Console.Write("Mitäs nuori nainen ?");
}
else if (ika < 57 && sukup == "N")
{
    Console.Write("Olet nainen parhaassa iässä !");
}
else if (ika > 56 && sukup == "N")
{
    Console.Write("Mitäs vanha akka ?");
}