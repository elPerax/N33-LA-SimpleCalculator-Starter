Simple Calculator Project:


Overview:

-This project is a simple calculator application built with C# and .NET. It allows users to perform basic arithmetic operations such as addition, subtraction, multiplication, division, and exponentiation (power). The project is structured in two parts:

-The main calculator application.
The CalculatorEngine class, which is packaged as a separate DLL for reuse in other projects.


Features:

-Static Conversion Class: The InputConverter class is designed to convert string inputs into numerical values (from string to double). The class is now static to simplify usage across the project.

-Input Validation: The application ensures that the first and second numbers, as well as the operation symbol, are correctly formatted. If the user enters a non-numeric value (e.g., "cat" instead of "2"), they are prompted to enter the input again with helpful guidance like:

"Invalid input. Please enter a valid number."
"Please enter a valid operation symbol (+, -, *, /, ^) or name (add, subtract, multiply, divide, raised)."
Human-readable Output: The result of the operation is displayed in a formatted, human-friendly way. For example:

-The result of 2 plus 3 is equal to 5.00. The result is formatted with a decimal precision of two places using StringBuilder and string formatting.
DLL Integration: The CalculatorEngine class, which handles the actual calculations, has been moved into a separate project. This allows the class to be compiled as a DLL, making it reusable for this and other projects.

-Extended Functionality: In addition to basic operations like add, subtract, multiply, and divide, the calculator now supports a power (exponentiation) function, allowing users to raise numbers to a specified power.


How to Use this project:

-Run the application.
-Enter the first number when prompted. The input is validated to ensure it's a valid number.
-Enter the second number. Again, input validation is applied.
-Enter the desired operation symbol or name:
-Supported operations: + (add), - (subtract), * (multiply), / (divide), ^ (raised).
-The result will be displayed in a human-readable format.


Code Structure:

-CalculatorEngine (DLL): This class contains the core logic for performing calculations. It is packaged as a DLL and imported into the main project.
-InputConverter: A static class responsible for converting user input into numeric values.
-Main Application: Handles user interaction, input validation, and displaying the result.


Tests:

-Unit tests are provided to validate the functionality of both the InputConverter and CalculatorEngine classes.
-InputConverterTest:
	-ConvertsValidStringInputIntoDouble(): Tests valid input conversion.
-FailsToConvertsInvalidStringInputIntoDouble(): Tests handling of invalid input.
-CalculatorEngineTest:
	-AddsTwoNumbersAndReturnsValidResultForNonSymbolOperation(): Tests the addition operation.
-SubstractsTwoNumbersAndReturnsValidResultForSymbolOperation(): Tests the subtraction operation.
-DividesTwoNumbersAndReturnsValidResultForSymbolOperation(): Tests division, ensuring proper handling of division by zero.
-MultiplyTwoNumbersAndReturnsValidResultForSymbolOperation(): Tests the multiplication operation.
-RaisedTwoNumbersAndReturnsValidResultForSymbolOperation(): Tests the power operation (exponentiation).


If you want to use this same project to improve it you should:

-Clone this repository.
-Open the solution in Visual Studio.
-Build the solution to ensure the DLL (CalculatorEngine) is properly referenced.
-Run the application and follow the instructions to use the calculator.
