// Import System to use Console.WriteLine.
using System;

// Keep the application classes in the same namespace.
namespace MathConsoleApp
{
    // Define a class that processes two integers.
    public class NumberProcessor
    {
        // Accept two integers and return no value.
        public void ProcessNumbers(int firstNumber, int secondNumber)
        {
            // Double the first integer. Use a long so the result can hold twice any int value.
            long doubledNumber = firstNumber * 2L;

            // Display the result of the calculation.
            Console.WriteLine($"Doubled first number: {doubledNumber}");

            // Display the second integer as received.
            Console.WriteLine($"Second number: {secondNumber}");
        }
    }

    // Define the class that contains the application's entry point.
    internal class Program
    {
        // Start the console application here.
        private static void Main()
        {
            // Instantiate NumberProcessor so we can call its instance method.
            NumberProcessor processor = new NumberProcessor();

            // Pass arguments by position. The first number is 5 and the second is 10.
            processor.ProcessNumbers(5, 10);

            // Pass arguments by name in reverse order. The first number is 7 and the second is 20.
            processor.ProcessNumbers(secondNumber: 20, firstNumber: 7);
        }
    }
}
