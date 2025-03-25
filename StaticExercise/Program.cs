using System.Net.Security;

namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var conversion = "0";
            do
            {
                Console.WriteLine($"Hello, please choose a conversion:\n " +
                                  $"1. Fahrenheit to Celsius\n " +
                                  $"2. Celsius to Fahrenheit\n " +
                                  $"3. Exit Program");
                conversion = Console.ReadLine();

                if (conversion == "1")
                {
                    Console.WriteLine("Please input Fahrenheit temperature: ");
                    double inputFar = double.Parse(Console.ReadLine());

                    double convertedTemp = TempConverter.FahToCel(inputFar);
                    Console.WriteLine($"Celsius temperature: {convertedTemp} \n\n");
                }
                else if (conversion == "2")
                {
                    Console.WriteLine("Please input Celsius temperature: ");
                    double inputCel = double.Parse(Console.ReadLine());

                    double convertedTemp = TempConverter.CelToFah(inputCel);
                    Console.WriteLine($"Fahrenheit temperature: {convertedTemp} \n\n");
                }
                else if (conversion == "3")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid selection, please try again.\n\n");
                }
            } while (conversion != "3");
        }
    }
}