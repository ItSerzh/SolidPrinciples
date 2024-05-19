// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.Configuration;
using SolidPrinciples;



var cfg = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

var configReader = new ConfigurationReader(cfg);
var numberGenerator = new NumberGenerator(configReader);
var number = numberGenerator.GetRandomNumber();
var numberAnalyzer = new NumberAnalyzer(number, configReader.GetAttemptsCount());

Console.WriteLine($"Please guess the number from {configReader.GetMinVal()} to {configReader.GetMaxVal()} in {configReader.GetAttemptsCount()} attempts.");

for (int i = 1; i <= configReader.GetAttemptsCount(); i++)
{
    Console.WriteLine("Enter your number:");
    var supposed = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(numberAnalyzer.AnalyzeVal(supposed));
    if (supposed == number)
    {
        break;
    }
    Console.WriteLine(numberAnalyzer.AnalyzeAttempts(i));
}