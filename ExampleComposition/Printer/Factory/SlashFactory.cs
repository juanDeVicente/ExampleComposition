using Models;
using Models.Models;

namespace ExampleComposition.Printer.Factory;

public class SlashFactory
{
    private readonly List<IModel> _models = [];
    private readonly Dictionary<Type, IPrinter[]> _printersPerType;
    
    public SlashFactory(IEnumerable<IPrinter> printers, SuperContext context)
    {
        _models.AddRange(context.AverageModel);
        _models.AddRange(context.SuperModel);

        _printersPerType =
            printers
                .GroupBy(p => p.TypeToPrint)
                .ToDictionary(p => p.Key, p => p.ToArray());
    }

    public void Print()
    {
        const int nUnderscore = 80;

        foreach (var model in _models)
        {
            var modelPrinters = _printersPerType[model.GetType()];
            foreach (var modelPrinter in modelPrinters)
            {
                Console.Write(modelPrinter.Print(model));
                Console.WriteLine(new string('/', nUnderscore));
            }
        }
    }
}