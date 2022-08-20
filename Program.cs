using ConsoleTables;
using PeriodicTableSearch.Data;

class Program
{
    private static readonly PeriodicElementsDbContext _context = new PeriodicElementsDbContext();
    
    static void FindElementBySymbol(String symbol)
    {
        symbol = char.ToUpper(symbol[0]) + symbol.Substring(1);

        var element = _context.PeriodicElements
            .Where(x => x.Symbol == symbol)
            .FirstOrDefault()!;

        PrintOutput(element);
    }

    static void FindElementByAtomicNumber(String atomicNumber)
    {
        var element = _context.PeriodicElements
            .Where(x => x.AtomicNumber == atomicNumber)
            .FirstOrDefault()!;

        PrintOutput(element);
    }

    static void FindElementByElementName(String elementName)
    {
        elementName = char.ToUpper(elementName[0]) + elementName.Substring(1);
        
        var element = _context.PeriodicElements
            .Where(x => x.Element == elementName)
            .FirstOrDefault()!;
        
        PrintOutput(element);
    }

    static void PrintOutput(PeriodicElement element)
    {
        var table = new ConsoleTable(
            "AtomicNumber",
            "Element",
            "Symbol",
            "AtomicMass",
            "Phase",
            "Type"
        );
        table.AddRow(
            element.AtomicNumber,
            element.Element,
            element.Symbol,
            element.AtomicMass,
            element.Phase,
            element.Type
        );

        Console.Clear();
        table.Write();
        Console.WriteLine();
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

        if (args[0] == "element")
        {
            FindElementByElementName(args[1]);
        }

        if (args[0] == "atomic-number")
        {
            FindElementByAtomicNumber(args[1]);
        }
    }
}
