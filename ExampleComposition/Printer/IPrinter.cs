using Models.Models;

namespace ExampleComposition.Printer;

public interface IPrinter<in TModel> : IPrinter where TModel : IModel
{
    Type IPrinter.TypeToPrint => typeof(TModel);
    string Print(TModel printable);

    string IPrinter.Print(object printable) => Print((TModel)printable);
}

public interface IPrinter
{
    Type TypeToPrint { get; }
    string Print(object printable);
}