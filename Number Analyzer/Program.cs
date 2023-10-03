using System;
using System.Runtime.CompilerServices;

public class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Welcome to number analyzer. What is your name?");
        string name = Console.ReadLine();
        bool answer = true;


        while (answer == true)
        {
            Console.WriteLine("Enter an integer from 1 to 100:");
            int input = int.Parse(Console.ReadLine());


            if (input < 1 || input > 100)
            {
                Console.WriteLine("Invalid input. Please only enter an integer from 1 to 100:");
                Console.WriteLine("Would you like to continue? y/n");
                string goOn = Console.ReadLine();
                if (goOn == "n")
                {
                    answer = false;
                }
            }

            else if (input % 2 == 1 && input < 60)
            {
                Console.WriteLine($"{name}, {input} is odd and less than 60.");
                Console.WriteLine("Would you like to continue? y/n");
                string goOn = Console.ReadLine();
                if (goOn == "n")
                {
                    answer = false;
                }
            }

            else if (input % 2 == 0 && input >= 2 && input <= 24)
            {
                Console.WriteLine($"{name}, {input} is even and less than 25.");
                Console.WriteLine("Would you like to continue? y/n");
                string goOn = Console.ReadLine();
                if (goOn == "n")
                {
                    answer = false;
                }

            }

            else if (input % 2 == 0 && input >= 26 && input <= 60)
            {
                Console.WriteLine($"{name}, {input} is even and between 26 and 60 inclusive.");
                Console.WriteLine("Would you like to continue? y/n");
                string goOn = Console.ReadLine();
                if (goOn == "n")
                {
                    answer = false;
                }
            }

            else if (input % 2 == 0 && input > 60)
            {
                Console.WriteLine($"{name}, {input} is even and greater than 60.");
                Console.WriteLine("Would you like to continue? y/n");
                string goOn = Console.ReadLine();
                if (goOn == "n")
                {
                    answer = false;
                }
            }

            else if (input % 2 == 1 && input > 60)
            {
                Console.WriteLine($"{name}, {input} is odd and greater than 60.");
                Console.WriteLine("Would you like to continue? y/n");
                string goOn = Console.ReadLine();
                if (goOn == "n")
                {
                    answer = false;
                }
            }
        }
    
    }
}