using Microsoft.EntityFrameworkCore;
using PeriodicTableSearch.Data;

class Program
{
    private static readonly PeriodicElementsDbContext _context = new PeriodicElementsDbContext();
    
    static void FindElementBySymbol(String symbol)
    {
        symbol = char.ToUpper(symbol[0]) + symbol.Substring(1);

        var element = _context.PeriodicElements
            .Where(x => x.Symbol == symbol)
            .FirstOrDefault();

        Console.WriteLine(element);
    }

    static void FindElementByAtomicNumber(String atomicNumber)
    {
        var element = _context.PeriodicElements
            .Where(x => x.AtomicNumber == atomicNumber)
            .FirstOrDefault();

        Console.WriteLine(element);
    }

    static void Main(string[] args)
    {
        /*
            getting two argument [0] => unit and [1] => value and pass it
            to the FindElement method. 
        */
        if (args.Length == 0)
        {
            Console.WriteLine("You must enter --unit and --value");
        }

        if (args[0] == "symbol")
        {
            FindElementBySymbol(args[1]);
        }

        if (args[0] == "atomic-number")
        {
            FindElementByAtomicNumber(args[1]);
        }
    }
}
