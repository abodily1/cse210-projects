using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int inputNumber = -1;
        // Enter numbers, 0 when done 
        while (inputNumber != 0)
        {
            Console.Write("Enter a list of numbers, type 0 when finished.\n");
            Console.Write("Enter number: ");
            string userResponse = Console.ReadLine();
            inputNumber = int.Parse(userResponse);
            
            if (inputNumber != 0)
            {
                // add number to list
                numbers.Add(inputNumber);
            }

        }

        int sum = 0;
        // compute sum
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        // compute average
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // compute maximum 
        int max = numbers.Max();
        Console.WriteLine($"The largest number is: {max}");       
    }
}