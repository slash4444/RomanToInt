# RomanToInt
Challenge number 13

Solution Class for Roman Numeral Conversion:

The Solution class is defined to encapsulate the logic for converting Roman numerals to integers.
It contains a public method RomanToInt(string s) that takes a Roman numeral string as input and returns an integer representing the value of the Roman numeral.
Roman Numeral Dictionary:

Inside the RomanToInt method, a dictionary named romanValues is defined. This dictionary maps Roman numeral characters ('I', 'V', 'X', 'L', 'C', 'D', 'M') to their corresponding integer values.
Integer Result Initialization:

An integer variable result is initialized to 0. This variable will store the final integer value of the Roman numeral.
Iterating Through the Roman Numeral String:

The code uses a for loop to iterate through the characters of the input Roman numeral string s.
Checking for Subtraction Cases:

Inside the loop, there is a conditional check:
If the current character's value is less than the next character's value and if there is a next character (i.e., i < s.Length - 1), it means that subtraction is needed. For example, 'IV' represents 4 (5 - 1).
In such cases, the value of the current character is subtracted from the result.
If the subtraction condition is not met, the value of the current character is added to the result.
Returning the Result:

After processing all characters in the Roman numeral string, the result variable contains the final integer value of the Roman numeral, considering the subtraction rules.
Main Program:

The Main method of the program is the entry point.
An instance of the Solution class is created as solution.
User Input:

The program prompts the user to enter a Roman numeral by displaying the message: "Enter a Roman numeral (e.g., III, LVIII, MCMXCIV):"
The user can input a Roman numeral like "III," "LVIII," or "MCMXCIV."
Conversion and Output:

The program calls the RomanToInt method of the solution object to convert the user's input to an integer.
If the input is a valid Roman numeral, it displays the integer value in the console.
If the input is not a valid Roman numeral, it catches any exceptions that might occur and displays an error message.
In summary, this C# program provides a user-friendly console interface for converting Roman numerals to integers using the provided Solution class, which implements the conversion logic based on the Roman numeral rules, including subtraction cases.
