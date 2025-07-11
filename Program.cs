using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyExchange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Currency Exchange Program.

            // Amount of rubles and dollars.
            float amountOfRubles;
            float amountOfDollars;

            // Exchange rate from dollars to rubles.
            int usdToRubRate = 78;

            // Type of exchange.
            string exchangetype;

            // Amount to exchange.
            float exchangeAmount;


            // Welcome message and input prompts.
            Console.WriteLine("Welcome to the currency exchange.");
            Console.Write("Enter the number of rubles: ");
            amountOfRubles = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of dollars: ");
            amountOfDollars = Convert.ToInt32(Console.ReadLine());

            // Optins for exchanging currencies.
            Console.WriteLine("Select the currency to exchange:");
            Console.WriteLine("1 - Exchange rubles.");
            Console.WriteLine("2 - Exchange dollars.");
            Console.Write("Choose an option: ");
            exchangetype = Console.ReadLine();

            // Process the exchange based on user input.
            switch (exchangetype)
            {
                case "1":
                    Console.WriteLine("Exchange rubles for dollars.");
                    Console.WriteLine("How many rubles would you like to exchange?");
                    exchangeAmount = Convert.ToInt32(Console.ReadLine());
                    if (amountOfRubles >= exchangeAmount)
                    {
                        // Perform the exchange.
                        amountOfRubles -= exchangeAmount;
                        amountOfDollars += exchangeAmount / usdToRubRate;
                        // Display the result.
                        Console.WriteLine($"You successfully exchanged {exchangeAmount} rubles!");
                        Console.WriteLine($"You have {amountOfRubles} rubles and {amountOfDollars} dollars.");
                    }
                    else
                    {
                        // If the user tries to exchange more rubles than they have.
                        Console.WriteLine("Don't lie :)");
                    }
                    break;

                case "2":
                    Console.WriteLine("Exchange dollars for rubles.");
                    Console.WriteLine("How many dollars would you like to exchange?");
                    exchangeAmount = Convert.ToInt32(Console.ReadLine());
                    if (amountOfDollars >= exchangeAmount)
                    {
                        // Perform the exchange.
                        amountOfDollars -= exchangeAmount;
                        amountOfRubles += exchangeAmount * usdToRubRate;
                        // Display the result.
                        Console.WriteLine($"You successfully exchanged {exchangeAmount} dollars!");
                        Console.WriteLine($"You have {amountOfRubles} rubles and {amountOfDollars} dollars.");
                    }
                    else
                    {
                        // If the user tries to exchange more dollars than they have.
                        Console.WriteLine("Don't lie :)");
                    }
                    break;

                // If the user enters an invalid option.
                default:
                    Console.WriteLine("Please choose one of the options (1, 2)");
                    return;
            }

            // Thank the user for using the service.
            Console.WriteLine("Thank you for using our exchange service!");

        }
    }
}
