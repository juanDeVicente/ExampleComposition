using System.Text;
using Models.Models;

namespace ExampleComposition.Printer.Impl;

public class AverageModelPrinter : IPrinter<AverageModel>
{
    public string Print(AverageModel printable)
    {
        var sb = new StringBuilder();
        sb.AppendLine(printable.Id.ToString());
        sb.AppendLine(printable.Description);
        sb.AppendLine(printable.CustomField1);
        return sb.ToString();
    }
}