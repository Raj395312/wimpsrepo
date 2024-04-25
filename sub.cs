
using System;

class Program
{
    static void Main()
    {
        // Declare variables to hold the numbers
        int number1, number2, sum;

        // Ask the user to enter the first number
        Console.WriteLine("Enter the first number:");
        // Read the input from the user and convert it to an integer
        number1 = Convert.ToInt32(Console.ReadLine());

        // Ask the user to enter the second number
        Console.WriteLine("Enter the second number:");
        // Read the input from the user and convert it to an integer
        number2 = Convert.ToInt32(Console.ReadLine());

        // Add the two numbers
        sum = number1 + number2;

        // Display the result
        Console.WriteLine("The sum of {0} and {1} is {2}.", number1, number2, sum);
    }
}
