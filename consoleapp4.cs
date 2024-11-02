using System;
using System.Collections.Generic;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part 1, 2, and 3 code from previous assignments can be kept here

            // Part 4: Unique List of Strings
            List<string> uniqueList = new List<string> { "apple", "banana", "cherry", "date", "elderberry" };

            Console.WriteLine("\nHere is the list of items:");
            foreach (string item in uniqueList)
            {
                Console.WriteLine(item);
            }

            // Ask the user to input text to search for in the list
            Console.Write("\nPlease enter text to search for in the list: ");
            string searchText = Console.ReadLine();

            // Flag to indicate if a match was found
            bool matchFound = false;

            // Loop through the list and search for the text
            for (int i = 0; i < uniqueList.Count; i++)
            {
                if (uniqueList[i].Contains(searchText, StringComparison.OrdinalIgnoreCase)) // Case-insensitive search
                {
                    Console.WriteLine($"Match found at index {i}: {uniqueList[i]}");
                    matchFound = true;
                    break; // Stop the loop once a match is found
                }
            }

            // If no match was found, inform the user
            if (!matchFound)
            {
                Console.WriteLine("Your input is not on the list.");
            }

            Console.ReadLine(); // Keep the console open
        }
    }
}