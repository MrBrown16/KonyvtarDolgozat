// See https://aka.ms/new-console-template for more information
using KonyvtarNo2Library.Data;
using KonyvtarNo2Library.Models;

Console.WriteLine("Hello, World!");

KonyvtarNo2ContextLib _context = new KonyvtarNo2ContextLib();

Console.WriteLine("Másold be a Kolcsonzok.csv, és Kolcsonzesek.csv mappájának útvonalát: ");
var path=Console.ReadLine();

if (!_context.Kolcsonzo.Any())
{
    var sorok = File.ReadAllLines($"{path}\\Kolcsonzok.csv").Skip(1);

    foreach (var sor in sorok)
    {
        try
        {
            Kolcsonzo kolcsonzo = new Kolcsonzo(sor);
            Console.WriteLine("Okés: " + sor + kolcsonzo);
            _context.Kolcsonzo.Add(kolcsonzo);
            //_context.SaveChanges();
        }
        catch
        {
            Console.WriteLine("Hibás: " + sor);
        }
    }

}
else
{
    Console.WriteLine("Az adatbázis már initializált");
}

Console.WriteLine($"A Kolcsonzo táblába {_context.SaveChanges()} rekordot szúrt be sikeresen ");



if (!_context.Kolcsonzes.Any())
{


    var sorok = File.ReadAllLines($"{path}\\Kolcsonzesek.csv").Skip(1);

    foreach (var sor in sorok)
    {
        try
        {
            Kolcsonzes kolcsonzes = new Kolcsonzes(sor);
            Console.WriteLine("Okés: " + sor + kolcsonzes);
            _context.Kolcsonzes.Add(kolcsonzes);

            //_context.SaveChanges();
        }
        catch
        {
            Console.WriteLine("Hibás: " + sor);
        }
    }
}
else
{
    Console.WriteLine("Az adatbázis már initializált");
}

Console.WriteLine($"A Kolcsonzes táblába {_context.SaveChanges()} rekordot szúrt be sikeresen ");



