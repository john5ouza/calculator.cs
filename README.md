# C#LCULATOR.CS

This repository contains a straightforward yet functional C# program acting as a basic calculator. The application allows users to select from basic arithmetic operations: addition, subtraction, multiplication, and division. It's designed to be user-friendly and provides prompt feedback.

## Code Description

The code has been systematically organized into distinct methods for improved clarity and maintenance.

1. `Menu()`:
   This method takes the primary role in displaying the calculator's interface. It presents a series of options to the user: addition, subtraction, multiplication, division, or exit.

2. `Addition()`:
   Here, the user can perform addition by inputting two numbers. After computation, the result is displayed.

3. `Subtraction()`:
   In this method, users can subtract one number from another. Once the user provides the two numbers, the difference is shown.

4. `Multiplication()`:
   Users enter two numbers, and this function will multiply them, presenting the product.

5. `Division()`:
   This method divides one number by another. It's designed to handle division, and if the divisor is zero, a different prompt should ideally be presented (though this is a suggested improvement).

In the program's main body, these methods are looped in a manner where the user can keep making selections until they choose to exit. The Menu method serves as a core driver, ensuring the user is always presented with choices after each operation.

## Future Improvements
Please note that this code will undergo refactoring in the future to enhance its efficiency, usability, and to incorporate additional features based on user feedback.

## How to Use
To utilize this C# calculator:

- Clone the repository to your local machine.
- Navigate to the directory containing the C# file.
- If you have the .NET SDK installed, you can use the command `dotnet run <filename>.cs` to execute the program.

Once initiated, you'll be welcomed with a greeting and a list of operations you can perform. Simply key in the desired operation's number, followed by the necessary inputs when prompted.

I trust this C# calculator will be of value to you! Should you have any suggestions, concerns, or improvements, kindly raise an issue or make a pull request.
