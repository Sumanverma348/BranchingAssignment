using System;

class Program
{
    static void Main()
    {
        // Greet the user with the welcome message.
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Prompt the user to enter the package weight.
        Console.WriteLine("Please enter the package weight:");
        double weight = Convert.ToDouble(Console.ReadLine());

        // Check if the package weight exceeds the allowed limit (50).
        if (weight > 50)
        {
            // Display error and exit if too heavy.
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return;
        }

        // Prompt the user to enter the package width.
        Console.WriteLine("Please enter the package width:");
        double width = Convert.ToDouble(Console.ReadLine());

        // Prompt the user to enter the package height.
        Console.WriteLine("Please enter the package height:");
        double height = Convert.ToDouble(Console.ReadLine());

        // Prompt the user to enter the package length.
        Console.WriteLine("Please enter the package length:");
        double length = Convert.ToDouble(Console.ReadLine());

        // Check if the sum of dimensions exceeds the allowed total (50).
        if (width + height + length > 50)
        {
            // Display error and exit if too large.
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return;
        }

        // Calculate the shipping quote using the formula:
        // (width * height * length * weight) / 100
        double quote = (width * height * length * weight) / 100;

        // Display the final shipping quote formatted to two decimal places.
        Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("F2"));
        Console.WriteLine("Thank you!");
    }
}
