Console.WriteLine("Är du 18? (ja/nej)");
string svar = Console.ReadLine();

if (svar == "ja")
{
    Console.WriteLine("Har du körkort? (ja/nej)");
    string korkort = Console.ReadLine();

    if (korkort == "ja")
    {
        Console.WriteLine("Ja, eftersom du är över 18 år och har körkort så får du köra bil");
    }
    else
    {
        Console.WriteLine("Nej, du får inte köra bil utan körkort");
    }
}
else
{
    Console.WriteLine("Nej, Du är inte 18 år och du får inte köra bil utan körkort");
}