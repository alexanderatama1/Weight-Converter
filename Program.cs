using System;
using System.ComponentModel.Design;

class Program
{
    static void Main()
    {
        // Declare variables for the original weight, the converted weight, and the units of measurement.
        double weight, conversion;
        string unit1, unit2;

        // Display a welcome message along with instructions about the units of measurements available for conversion.
        Console.WriteLine("Welcome to Weight Converter");
        Console.WriteLine("===========================");
        Console.WriteLine("Available units are (kg)kilograms, (lbs)pounds, (st)stones");

        // Ask the user for the weight value.
        Console.Write("Enter Weight: ");
        // Read the weight value from the user's input, convert it to a double type for the mathematical operation.
        weight = double.Parse(Console.ReadLine());

        // Ask the user for the current unit of the weight.
        Console.Write("Enter the current Unit: ");
        // Read the current unit from the user's input and convert it to uppercase to maintain consistency in comparison, regardless of how the user entered it.
        unit1 = Console.ReadLine().ToUpper();

        // Ask the user for the unit they want the weight converted to.
        Console.Write("Enter the conversion unit: ");
        // Read the desired unit from the user's input and convert it to uppercase for consistency in the subsequent comparison.
        unit2 = Console.ReadLine().ToUpper();

        // Print a blank line for output clarity.
        Console.WriteLine();

        // Check if the user has entered the same unit for both the current and desired units.
        if (unit1 == unit2)
        {
            // Notify the user that they have entered the same unit, which doesn't require conversion.
            Console.WriteLine($"Both units cannot be the same!");
        }
        // Validate the entered current unit to ensure it's one of the acceptable options.
        else if (unit1 != "KG" && unit1 != "LBS" && unit1 != "ST")
        {
            // Inform the user they've entered an unrecognized unit.
            Console.WriteLine($"The unit {unit1} is not valid!");
        }
        // Validate the entered desired unit for conversion, ensuring it's a recognized option.
        else if (unit2 != "KG" && unit2 != "LBS" && unit2 != "ST")
        {
            // Inform the user they've entered an unrecognized unit.
            Console.WriteLine($"The unit {unit2} is not valid!");
        }
        else
        {
            // If both units are valid and not the same, we proceed with the conversion.
            // Depending on the current unit, the appropriate conversion calculation is applied.
            if (unit1 == "KG")
            {
                if (unit2 == "LBS")
                {
                    // Convert from Kilograms to Pounds.
                    conversion = weight * 2.20462;
                    // Round the resulting value to 2 decimal places for cleanliness and readability.
                    conversion = Math.Round(conversion, 2);
                }
                else // unit2 == "ST"
                {
                    // Convert from Kilograms to Stones.
                    conversion = weight * 0.157473;
                    // Round the resulting value to 2 decimal places.
                    conversion = Math.Round(conversion, 2);
                }
            }
            else if (unit1 == "LBS")
            {
                if (unit2 == "ST")
                {
                    // Convert from Pounds to Stones.
                    conversion = weight / 14;
                    // Round the resulting value to 2 decimal places.
                    conversion = Math.Round(conversion, 2);
                }
                else // unit2 == "KG"
                {
                    // Convert from Pounds to Kilograms.
                    conversion = weight * 0.453592;
                    // Round the resulting value to 2 decimal places.
                    conversion = Math.Round(conversion, 2);
                }
            }
            else // unit1 == "ST"
            {
                if (unit2 == "KG")
                {
                    // Convert from Stones to Kilograms.
                    conversion = weight * 6.35029;
                    // Round the resulting value to 2 decimal places.
                    conversion = Math.Round(conversion, 2);
                }
                else // unit2 == "LBS"
                {
                    // Convert from Stones to Pounds.
                    conversion = weight * 14;
                    // Round the resulting value to 2 decimal places.
                    conversion = Math.Round(conversion, 2);
                }
            }

            // Display the conversion result to the user, showing the original weight, the original unit, the converted weight, and the converted unit.
            Console.WriteLine($"A weight of {weight} {unit1} is {conversion} {unit2}.");
        }
    }
}