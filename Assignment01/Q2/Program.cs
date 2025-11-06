using System;

namespace Q2
{
    internal class Program
    {
        static void Main()
        {
            int choice;

            

            while (true)
            {
                
                Console.WriteLine("\n1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("0. Exit");
                Console.Write("Enter choice: ");

                choice = int.Parse(Console.ReadLine());

                if (choice == 0)
                {
                    Console.WriteLine("Exiting...");
                    break;
                }

                Console.Write("Enter Number 1: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("Enter Number 2: ");
                int num2 = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine($" {num1} + {num2} = {num1 + num2}");
                        break;
                    case 2:
                        Console.WriteLine($" {num1} - {num2} = {num1 - num2}");
                        break;
                    case 3:
                        Console.WriteLine($" {num1} * {num2} = {num1 * num2}");
                        break;
                    case 4:
                        if (num2 == 0)
                            Console.WriteLine("Error: Division by zero!");
                        else
                            Console.WriteLine($" {num1} / {num2} = {num1 / num2}"); 
                        break;
                    default:
                        Console.WriteLine(" Invalid choice. Try again.");
                        break;
                }
            }
        }
    }
}