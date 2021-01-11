using MyMLApp1ML.Model;
using System;
//opdracht 1 voor tekst
namespace  myMLApp1
{ 
    class Program
    { 
        static void Main(string[] args)
{
        String varAntwoord = "ja";
        while (varAntwoord == "ja")
        {
        Console.WriteLine("geef een zin");
        String varZin = Console.ReadLine();
        Console.WriteLine(varZin);

        // Add input data
        var input = new ModelInput();
        input.SentimentText = varZin;

        // Load model and predict output of sample data
        ModelOutput result = ConsumeModel.Predict(input);
        Console.WriteLine($"Text: {input.SentimentText}\nIs Toxic: {result.Prediction}");

        Console.WriteLine("Wil je een zin testen of deze toxic is of niet? Zo ja, antwoord ja");
        varAntwoord = Console.ReadLine();

        }
        Console.WriteLine("Press enter to close...");
        Console.ReadLine();
        }
    }
}
