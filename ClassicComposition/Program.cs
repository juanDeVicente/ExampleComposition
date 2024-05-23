// See https://aka.ms/new-console-template for more information

using Models;

const int nUnderscore = 80;

var context = new SuperContext();

foreach (var averageModel in context.AverageModel)
{
    Console.WriteLine(averageModel.Id);
    Console.WriteLine(averageModel.Description);
    Console.WriteLine(averageModel.CustomField1);
    Console.WriteLine(new string('-', nUnderscore));
}

foreach (var averageModel in context.SuperModel)
{
    Console.WriteLine(averageModel.Id);
    Console.WriteLine(averageModel.Description);
    Console.WriteLine(averageModel.CustomField2);
    Console.WriteLine(new string('-', nUnderscore));
}