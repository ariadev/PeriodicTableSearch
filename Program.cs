using PeriodicTableSearch.Data;

using var db = new PeriodicElementsDbContext();

static void FindElement(PeriodicElementsDbContext? db)
{
    Console.WriteLine("List of all elements:");
    var list = db.PeriodicElements.ToList();
    
    foreach(var element in list)
    {
        Console.WriteLine($"{element.AtomicNumber} | {element.Element} | {element.Symbol}");
    }
}

FindElement(db);