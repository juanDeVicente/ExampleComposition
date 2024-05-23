// See https://aka.ms/new-console-template for more information

using ExampleComposition.Printer;
using ExampleComposition.Printer.Factory;
using Microsoft.Extensions.DependencyInjection;
using Models;

var context = new SuperContext();

var serviceCollection = new ServiceCollection();

serviceCollection.Scan(scan =>
{
    scan.FromAssemblyOf<IPrinter>()
        .AddClasses(cls => cls.AssignableTo<IPrinter>())
        .AsImplementedInterfaces()
        .WithTransientLifetime();
});
serviceCollection.AddTransient<SlashFactory>();
serviceCollection.AddTransient<UnderscoreFactory>();
serviceCollection.AddTransient(_ => context);

var serviceProvider = serviceCollection.BuildServiceProvider();

using var scope = serviceProvider.CreateScope();

var slashFactory = scope.ServiceProvider.GetService<SlashFactory>();
var underscoreFactory = scope.ServiceProvider.GetService<UnderscoreFactory>();

Console.WriteLine("_-_-_-_- SLASH FACTORY _-_-_-_-");
slashFactory?.Print();
Console.WriteLine("_-_-_-_- UNDERSCORE FACTORY _-_-_-_-");
underscoreFactory?.Print();