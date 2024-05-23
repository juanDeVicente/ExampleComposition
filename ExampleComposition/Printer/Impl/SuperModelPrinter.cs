using System.Text;
using Models.Models;

namespace ExampleComposition.Printer.Impl;

public class SuperModelPrinter : IPrinter<SuperModel>
{
    public string Print(SuperModel printable)
    {
        var sb = new StringBuilder();
        sb.AppendLine(printable.Id.ToString());
        sb.AppendLine(printable.Description);
        sb.AppendLine(printable.CustomField2);
        return sb.ToString();
    }
}