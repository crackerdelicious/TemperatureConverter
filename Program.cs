using System;

namespace TemperatureConvertor
{
    public class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                PrintMenus();

                if(int.TryParse(Console.ReadLine(), out choice))
                {
                    HandleChoice(choice);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again.\n");
                }
            } while (choice != 3);
        }

        static void PrintMenus()
        {
            Console.WriteLine("Temperature Convertor\n");
            Console.WriteLine("1. Convert Celcius to Fahrenheit");
            Console.WriteLine("2. Convert Fahrenheit to Celcius");
            Console.WriteLine("3. Quit\n");
            Console.Write($"Enter your choice: ");
        }

        static void HandleChoice(int choice)
        {
            if (choice == 1 || choice == 2)
            {
                PerformConversion(choice);
            }
            else if (choice == 3)
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid input. Please select 1 - 3.\n");
            }
        }

        static void PerformConversion(int choice)
        {
            string[] operationChoices = { "Celsius", "Fahrenheit" };
            double temperature;

            Console.Write($"Enter temperature in {operationChoices[choice - 1]}");

            if (!double.TryParse(Console.ReadLine(), out temperature))
            {
                Console.WriteLine("Invalid input. Please provide a numeric value.\n");
            }

            switch (choice)
            {
                case 1:
                    Console.WriteLine($"{temperature}°C is equal to {CelsiusToFahrenheit(temperature):N2}°F\n");
                    break;
                case 2:
                    Console.WriteLine($"{temperature}°F is equal to {FahrenheitToCelsius(temperature):N2}°C\n");
                    break;
                default:
                    Console.WriteLine("Invalid input. Please try again.");
                    break;
            }
        }

        static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}