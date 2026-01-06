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

                    case 4:
                        Console.WriteLine("Enter how many numbers:");
                        int A = int.Parse(Console.ReadLine());

                        int positiveCount = 0;
                        int negativeCount = 0;

                        for (int i = 1; i <= A; i++)
                        {
                            Console.WriteLine("Enter number " + i + ":");
                            int numberA = int.Parse(Console.ReadLine());

                            if (numberA> 0)
                            {
                                positiveCount = positiveCount + 1;
                            }
                            else if (numberA < 0)
                            {
                                negativeCount = negativeCount + 1;
                            }
                        }

                        Console.WriteLine("Positive numbers count: " + positiveCount);
                        Console.WriteLine("Negative numbers count: " + negativeCount);
                        break;

                    case A:
                        Console.WriteLine("Enter a number:");
                        int N = int.Parse(Console.ReadLine());

                        for (int i = 1; i <= N; i++)
                        {
                            for (int j = 1; j <= N; j++)
                            {
                                Console.Write(i * j + " ");
                            }
                            Console.WriteLine();
                            break;

                            Task B:
                                Console.WriteLine("Enter how many numbers:");
                            int n = int.Parse(Console.ReadLine());
                            
                            int[] arr = new int[n];

                            for (int i = 0; i < n; i++)
                            {
                                Console.WriteLine("Enter number " + (i + 1) + ":");
                                arr[i] = int.Parse(Console.ReadLine());
                            }

                            for (int i = 0; i < n; i++)
                            {
                                for (int j = i + 1; j < n; j++)
                                {
                                    if (arr[i] == arr[j])
                                    {
                                        Console.WriteLine("Has duplicates");
                                        return; 
                                        
                                        // يوقف البرنامج كله
                                    }
                                }
                            }

                            Console.WriteLine("No duplicates");

                            break;
                             Task BB:
                                
                Console.WriteLine("Enter how many numbers:");
                int n = int.Parse(Console.ReadLine());

                int[] arr = new int[n];

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Enter number " + (i + 1) + ":");
                    arr[i] = int.Parse(Console.ReadLine());
                }

                bool hasDuplicate = false;

                for (int i = 0; i < n; i++)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        if (arr[i] == arr[j])
                        {
                            hasDuplicate = true;
                            break;
                        }
                    }

                    if (hasDuplicate)
                    {
                        break;
                    }
                }

                if (hasDuplicate)
                {
                    Console.WriteLine("Has duplicates");
                }
                else
                {
                    Console.WriteLine("No duplicates");

                    break;

                                Task 5:

                Console.WriteLine("Enter how many numbers:");
                int n = int.Parse(Console.ReadLine());

                List<int> numbers = new List<int>();

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Enter number " + (i + 1) + ":");
                    int num = int.Parse(Console.ReadLine());
                    numbers.Add(num);
                }

                List<int> uniqueNumbers = new List<int>();

                foreach (int num in numbers)
                {
                    if (!uniqueNumbers.Contains(num))
                    {
                        uniqueNumbers.Add(num);
                    }
                }

                Console.WriteLine("List with unique values:");
                foreach (int num in uniqueNumbers)
                {
                    Console.Write(num + " ");
                }
            }
        }
    }

}
            }
        }
    }

}
               
        