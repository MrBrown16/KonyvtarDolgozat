// See https://aka.ms/new-console-template for more information
using KonyvtarNo2Library.Data;
using KonyvtarNo2Library.Models;

Console.WriteLine("Hello, World!");

KonyvtarNo2ContextLib _context = new KonyvtarNo2ContextLib();


if (!_context.Kolcsonzo.Any())
{


    var sorok = File.ReadAllLines(@"C:\Users\diak\Mora-Barna\csharp\Konyvtar\Forras\csv\Kolcsonzok.csv").Skip(1);

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

_context.SaveChanges();


if (!_context.Kolcsonzes.Any())
{


    var sorok = File.ReadAllLines(@"C:\Users\diak\Mora-Barna\csharp\Konyvtar\Forras\csv\Kolcsonzesek.csv").Skip(1);

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




_context.SaveChanges();