using System; // Imports basic .NET functionality, including Console for displaying output.

// Defines a class that contains our math operation method.
class MathOperations
{
    // Defines a public void method that accepts two integer parameters.
    // The first parameter is used in a math operation.
    // The second parameter is displayed on the screen.
    public void PerformOperation(int firstNumber, int secondNumber)
    {
        // Multiplies the first integer by 2 and stores the result.
        int result = firstNumber * 2;

        // Displays the result of the math operation.
        Console.WriteLine("First number multiplied by 2: " + result);

        // Displays the second integer passed to the method.
        Console.WriteLine("Second number: " + secondNumber);
    }
}

// Defines the main class that starts the console application.
class Program
{
    // The Main method is the entry point of the application.
    static void Main(string[] args)
    {
        // Preserve the original top-line output by moving it here.
        Console.WriteLine("");

        // Creates an instance (object) of the MathOperations class.
        MathOperations math = new MathOperations();

        // Calls the method using positional arguments.
        // The first value (5) goes to firstNumber; the second value (10) goes to secondNumber.
        math.PerformOperation(5, 10);

        // Prints a blank line to separate the two method calls in the output.
        Console.WriteLine();

        // Calls the same method using named arguments.
        // Each value is assigned explicitly to its corresponding parameter name.
        math.PerformOperation(firstNumber: 7, secondNumber: 20);

        // Keeps the console window open until the user presses a key.
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}
