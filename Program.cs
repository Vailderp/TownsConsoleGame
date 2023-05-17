using CsvHelper;
using CsvHelper.Configuration;
using programm;
using System.Globalization;


Towns towns = new Towns("town_names.txt");

var town_name = Searcher.Search(towns, "томск");

Console.WriteLine(town_name);

string? town = Computer.FindByFirstLetter(towns, 'А');

while (towns.UnUsedNames.Count != 0)
{
    if (town == null)
    {
        Console.WriteLine("Компьютер больше не нашёл городов! Вы выиграли!");
        return;
    }
    Console.WriteLine($"Город {town}.");
    Console.Write($"Вам на букву {Searcher.SearchLastPermissibleLetter(town)}: ");
    town = null;
    while ((town = Searcher.Search(towns, Console.ReadLine() ?? "")) == null)
    {
        Console.WriteLine($"Такгого орода не существует!");
    }
    town = Computer.FindByFirstLetter(towns, Searcher.SearchLastPermissibleLetter(town));
}


