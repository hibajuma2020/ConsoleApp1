using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {


                Console.WriteLine("Welcome to our system ");
                Console.WriteLine("choose a services you need");
                Console.WriteLine("1. add two numbers");
                Console.WriteLine("2. find averge of list ");
                Console.WriteLine("3.check if input number is even or odd");
                Console.WriteLine("4.Find the smallest number ");
                Console.WriteLine("5.conut number of positive numbers and number of negative numbers");
                Console.WriteLine("6. output prime numbers");
                int option = int.Parse(Console.ReadLine());
switch (option)
                {

                    case 1:
                        Console.WriteLine("Enter how many numbers you want:");
                        int n = int.Parse(Console.ReadLine());

                        float sum = 0;
                        int count = 0;

                        for (int i = 0; i <= n; i++)
                        {
                            Console.WriteLine("Enter number " + i + ":");
                            float numberN = float.Parse(Console.ReadLine());

                            sum = sum + numberN;
                            count = count + 1;
                        }

                        Console.WriteLine("Sum = " + sum);
                        Console.WriteLine("Count = " + count);
                        break;

                    case 2:
                        
                        Console.WriteLine("Enter a number:");
                        int number = int.Parse(Console.ReadLine());

                        if (number % 2 == 0)
                        {
                            Console.WriteLine("Even");
                        }
                        else
                        {
                            Console.WriteLine("Odd");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Enter how many numbers:");
                        int N = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter number 1:");
                        int smallest = int.Parse(Console.ReadLine());

                        for (int i = 2; i <= N; i++)
                        {
                            Console.WriteLine("Enter number " + i + ":");
                            int numberN = int.Parse(Console.ReadLine());

                            if (numberN < smallest)
                            {
                                smallest = numberN;
                            }
                        }

                        Console.WriteLine("The smallest number is: " + smallest);
                        break;
                }
            }
        }


    }
}
        
        