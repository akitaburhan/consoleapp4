# consoleapp4
Unique List of Strings:

The List<string> named uniqueList contains unique items. For example, "apple", "banana", "cherry", etc.
Search Text:

The program prompts the user to enter text they wish to search for in the list.
Loop and Match Check:

A for loop iterates through the uniqueList to find a match for the searchText.
If a match is found, it displays the index and item, sets matchFound to true, and then uses break to stop the loop.
No Match:

If no match is found after the loop, the program checks the matchFound flag. If it’s still false, it displays a message indicating that the user’s input is not on the list.
Case-Insensitive Search:

The code performs a case-insensitive search using StringComparison.OrdinalIgnoreCase to make it more user-friendly.
