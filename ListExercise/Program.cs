using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Specify the data source.
        List<int> scores = new List<int> { 97, 92, 81, 60, 90 };

        // Operations with lists
        scores.Add(30);
        scores.Add(88);
        scores.Remove(30);
        scores.Sort(); // Sort the array (default sort)

        // Display the count of elements in the list
        Console.WriteLine($"The list contains {scores.Count} elements.");

        Console.Write("Enter the index of the number you want to retrieve (-1 to exit): ");
        string? input = Console.ReadLine();
        int position;
        if (!int.TryParse(input, out position))
        {
            Console.WriteLine("Invalid input! Please enter a valid index or -1 to exit.");
            return;
        }

        while (position != -1)
        {
            if (position < 0 || position >= scores.Count)
            {
                Console.WriteLine("Index out of range! Please enter a valid index or -1 to exit.");
            }
            else
            {
                Console.WriteLine($"The number at index {position} is: {scores[position]}");

                // Ask the user if they want to remove the element at this index
                string? answer;
                do
                {
                    Console.Write($"Do you want to remove the element at index {position}? (yes/no): ");
                    answer = Console.ReadLine().ToLower();
                    if (answer != "yes" && answer != "no")
                    {
                        Console.WriteLine("Please enter either 'yes' or 'no'.");
                    }
                } while (answer != "yes" && answer != "no");

                if (answer == "yes")
                {
                    scores.RemoveAt(position);
                    Console.WriteLine($"Element at index {position} removed.");
                }
            }

            Console.Write("\nEnter the index of the number you want to retrieve (-1 to exit): ");
            input = Console.ReadLine();
            if (!int.TryParse(input, out position))
            {
                Console.WriteLine("Invalid input! Please enter a valid index or -1 to exit.");
                return;
            }
        }

        Console.WriteLine($"\nThe second last number is {scores[^2]}");

        // Use Contains method to check if the list contains a specific number
        Console.Write("\nEnter a number to check if it exists in the list: ");
        int numberToCheck;
        if (int.TryParse(Console.ReadLine(), out numberToCheck))
        {
            if (scores.Contains(numberToCheck))
            {
                Console.WriteLine($"The number {numberToCheck} exists in the list.");
            }
            else
            {
                Console.WriteLine($"The number {numberToCheck} does not exist in the list.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input! Please enter a valid number.");
        }

        // Use Find method with lambda expression to find the first number greater than 80
        int greaterThan80 = scores.Find(x => x > 80);
        Console.WriteLine($"\nThe first number greater than 80 is: {greaterThan80}");

        // Displaying the list of scores
        Console.WriteLine("\nElements of the list (sorted) were: ");
        foreach (var score in scores)
        {
            Console.Write(score + " ");
        }
    }
}
