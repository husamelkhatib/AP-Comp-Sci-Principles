<h1>Handbook on Programming in C# </h1>

**AP Computer Science Principles 2023-2024**

Husam El-Khatib

<!-- This is a comment (which will not be displayed in the live file);
replace all "???" with your own text. -->




___





<h1>Table of Contents</h1>

- [1. Compiling and Running](#1-compiling-and-running)
- [2. Data Types](#2-data-types)
- [3. Console I/O](#3-console-io)
- [4. Arithmetic Operations](#4-arithmetic-operations)
- [5. Assignment Operations](#5-assignment-operations)
- [6. Comments](#6-comments)
- [7. Decision Structures](#7-decision-structures)
- [8. Conditional Operators](#8-conditional-operators)
- [9. Logic Operators](#9-logic-operators)
- [10. Advanced Decision Structures](#10-advanced-decision-structures)
- [11. String Methods](#11-string-methods)
- [12. Random Generation](#12-random-generation)
- [13. Looping Structures](#13-looping-structures)
- [14. Functions/Methods](#14-functionsmethods)
- [15. Elementary Data Structures](#15-elementary-data-structures)
  - [15.1 Arrays/Lists](#151-arrayslists)
  - [15.2 Matrices](#152-matrices)
- [References](#references)

<!-- 
- [16. Major Keywords](#16-major-keywords)
- [17. Error Handling](#17-error-handling)
- [18. Working with Files](#18-working-with-files)
- [19. Major Language Features](#19-major-language-features)
  - [19.1 Classes](#191-classes)
  - [19.2 Inheritance](#192-inheritance)
  - [19.3 Generic Typing (Templates)](#193-generic-typing-templates)
  - [19.4 Pointers](#194-pointers)
- [20. Importing Local Libraries](#20-importing-local-libraries)
- [21. Working with Time](#21-working-with-time)
- [22. Importing Libaries from Package managers](#22-importing-libaries-from-package-managers)
- [23. Bitwise Operators](#23-bitwise-operators)
- [24. Common Data Structures](#24-common-data-structures)
- [25. Advanced Language Features](#25-advanced-language-features)
-->




___





# 1. Compiling and Running

Compiling and running a C# program involves several steps that allow you to change your source code into an executable application.  In this section, I will go through the process of compiling and running C# programs.

## 1.1 Compiling a C# Program

To compile a C# program, you need access to the C# compiler, which is part of the .NET Framework.  Here's how you can compile a C# program using the command line:

1. ### Open a Command Prompt or Terminal:
   Depending on your operating system, open a command prompt or terminal window.
2. ### Navigate to the Program Directory:
   Use the cd command to navigate to the directory where your C# source file (with a .cs extension) is located.
3. ### Compile the Program:
   Run the following command to compile your program:
  ```cs
  csc YourProgram.cs

  ```
  Replace `YourProgram.cs` with the name of your C# source file. This command uses the C# compiler (`csc`) to generate an executable file.

4. ### Run the Program:
   After successful compilation, you will see an executable file named `YourProgram.exe` in the same directory. You can run your program using the following command:
  ```cs
  YourProgram.exe

  ```
  Replace `YourProgram.exe` with the name of your executable file.

## 1.2 Understanding Compilation Errors

During compilation, the C# compiler checks your code for syntax errors and other issues. If any errors are found, they will be displayed in the command prompt, along with information about the location of the error in your code. It is essential to review and fix these errors before running your program.

## 1.3 Running a C# Program

Once your program is successfully compiled, you can execute it by running the generated executable file. When you run your program, it starts executing from the Main method, which serves as the entry point.

Here's a simple example of a C# program:
```cs
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, C#!");
    }
}

```
After compiling this program, you can run it to see the output.

## 1.4 IDEs (Integrated Development Environments)

While using the command line for compilation and execution is a fundamental approach, many developers prefer using integrated development environments (IDEs) such as Visual Studio, Visual Studio Code, or JetBrains Rider. These IDEs offer powerful features for C# development, including code editing, debugging, and project management.

In summary, understanding how to compile and run C# programs from the command line is essential for basic development. As you progress in your C# journey, you may explore the features of IDEs to enhance your development experience.





# 2. Data Types

Data types in C# are essential for defining the kind of data that variables can hold. C# provides a rich set of built-in data types, each designed to store specific types of information. Understanding data types is fundamental to writing C# programs effectively.

## 2.1 Common Data Types

### 2.1.1 `int`: Integer
The `int` data type is used to store signed 32-bit integer values. It can represent both positive and negative whole numbers.

Example:
```cs
int age = 25;

```
### 2.1.2 `double`: Double-Precision Floating-Point
The `double` data type is used to store double-precision floating-point numbers, which are decimal numbers with high precision.

Example:
```cs
double pi = 3.14159265359;

```
### 2.1.3 `string`: String
The `string` data type is used to store sequences of characters, such as text. Strings are enclosed in double quotes.

Example:
```cs
string greeting = "Hello, World!";

```
### 2.1.4 `bool`: Boolean
The `bool` data type represents Boolean values, which can be either `true` or `false`. Booleans are used for logical operations and conditional statements.

Example:
```cs
bool isRaining = true;

```
### 2.1.5 `char`: Character
The `char` data type is used to store a single Unicode character. Characters are enclosed in single quotes.

Example:
```cs
char grade = 'A';

```
### 2.1.6 `decimal`: Decimal
The `decimal` data type is used to store decimal numbers with high precision. It is often used in financial calculations where accuracy is crucial.

Example:
```cs
decimal price = 19.99m;

```
### 2.1.7 `byte`: Byte
The `byte` data type is used to store unsigned 8-bit integer values, ranging from 0 to 255.

Example:
```cs
byte redValue = 255;

```
## 2.2 Declaring Variables
To declare a variable, you specify the data type followed by the variable name. Variables can hold data of the declared type.

Example:
```cs
int numberOfApples;
string playerName;
double temperature;

```
## 2.3 Type Inference (`var` Keyword)
C# allows type inference using the `var` keyword. The compiler determines the data type based on the assigned value.

Example:
```cs
var itemCount = 10; // Compiler infers that itemCount is of type int

```
## 2.4 Summary
Understanding and choosing the appropriate data types is essential for efficient and error-free C# programming. C# provides a range of data types to accommodate various types of data, from integers and floating-point numbers to text and Boolean values.






# 3. Console I/O

Console Input and Output (I/O) is a fundamental aspect of C# programming. It allows you to interact with the user by reading input from the console and displaying output.

## 3.1 Output with `Console.WriteLine()`

The `Console.WriteLine()` method is used to display output to the console. It automatically adds a newline character at the end of the output, so each call starts on a new line.

Example:
```cs
Console.WriteLine("Hello, C#!");

```
Output:
```cs
Hello, C#!

```
## 3.2 Input with `Console.ReadLine()`

The `Console.ReadLine()` method is used to read input from the user. It allows the user to enter text, which is returned as a string.

Example:
```cs
Console.WriteLine("Enter your name:");
string name = Console.ReadLine();
Console.WriteLine("Hello, " + name + "!");

```
In this example, the program prompts the user to enter their name and then greets them using the provided name.

## 3.3 Formatting Output

You can format output using placeholders and string interpolation. Placeholders are indicated by `{0}`, `{1}`, etc., and values are substituted accordingly.

Example:
```cs
string name = "Alice";
int age = 30;
Console.WriteLine("Name: {0}, Age: {1}", name, age);

```
Output:
```cs
Name: Alice, Age: 30

```
Alternatively, you can use string interpolation with the `$` symbol:
```cs
Console.WriteLine($"Name: {name}, Age: {age}");

```

## 3.4 Reading Numeric Input

When you read input using `Console.ReadLine()`, it's returned as a string. To work with numeric values, you need to parse the string into the desired data type using methods like `int.Parse()` or `double.Parse()`.

Example:
```cs
Console.WriteLine("Enter your age:");
string ageInput = Console.ReadLine();
int age = int.Parse(ageInput);
Console.WriteLine("You entered: " + age);

```
Ensure error handling when parsing input to handle cases where the input cannot be converted to the desired data type.

## 3.5 Summary

Console I/O is a critical part of C# programming, enabling you to communicate with users by displaying information and collecting input. Understanding how to use `Console.WriteLine()` for output and `Console.ReadLine()` for input is essential for building interactive C# applications.






# 4. Arithmetic Operations

Arithmetic operations are fundamental in C# and allow you to perform mathematical calculations on numeric data types. C# supports a variety of arithmetic operations, including addition, subtraction, multiplication, division, and more.

## 4.1 Basic Arithmetic Operators
### 4.1.1 Addition (`+`)

The addition operator `+` is used to add two or more numeric values.

Example:
```cs
int a = 5;
int b = 3;
int sum = a + b; // sum is 8

```
### 4.1.2 Subtraction (`-`)

The subtraction operator `-` is used to subtract one numeric value from another.

Example:
```cs
int x = 10;
int y = 4;
int difference = x - y; // difference is 6

```
### 4.1.3 Multiplication (`*`)

The multiplication operator `*` is used to multiply two or more numeric values.

Example:
```cs
int p = 6;
int q = 7;
int product = p * q; // product is 42

```
### 4.1.4 Division (`/`)

The division operator `/` is used to divide one numeric value by another. Note that division of integers may result in a truncated integer value.

Example:
```cs
double dividend = 10.0;
double divisor = 3.0;
double quotient = dividend / divisor; // quotient is 3.333...

```
## 4.2 Modulus Operator (`%`)

The modulus operator `%` calculates the remainder when one number is divided by another. It is often used to check if a number is even or odd.

Example:
```cs
int num = 7;
int remainder = num % 2; // remainder is 1 (7 is odd)

```
## 4.3 Order of Operations

C# follows the standard order of operations (PEMDAS/BODMAS), which determines the sequence in which arithmetic operations are evaluated:

  1. **P**arentheses (Brackets)
  2. **E**xponents (Powers and Roots)
  3. **M**ultiplication and **D**ivision (left to right)
  4. **A**ddition and **S**ubtraction (left to right)

Use parentheses to control the order of evaluation when needed.

## 4.4 Summary

Understanding arithmetic operations is crucial for performing mathematical calculations in C# programs. By using basic arithmetic operators like addition, subtraction, multiplication, and division, you can manipulate numeric data and solve a wide range of problems.






# 5. Assignment Operations

Assignment operations in C# are used to assign values to variables. These operations are fundamental for storing and manipulating data in your programs.

## 5.1 The Assignment Operator (`=`)

The most basic assignment operation in C# is performed using the assignment operator `=`. It assigns the value on the right side of the operator to the variable on the left side.

Example:
```cs
int x;          // Declare a variable
x = 10;         // Assign the value 10 to x

```
In this example, the value `10` is assigned to the variable `x`.

## 5.2 Compound Assignment Operators

C# provides compound assignment operators, which combine an arithmetic operation with assignment. These operators make code more concise and readable.

### 5.2.1 Addition Assignment (`+=`)

The addition assignment operator `+=` adds the value on the right side to the variable on the left side and assigns the result back to the variable.

Example:
```cs
int total = 5;
total += 3; // Equivalent to total = total + 3; (total is now 8)

```
### 5.2.2 Subtraction Assignment (`-=`)

The subtraction assignment operator `-=` subtracts the value on the right side from the variable on the left side and assigns the result back to the variable.

Example:
```cs
int balance = 100;
balance -= 25; // Equivalent to balance = balance - 25; (balance is now 75)

```
### 5.2.3 Multiplication Assignment (`*=`)

The multiplication assignment operator `*=` multiplies the variable on the left side by the value on the right side and assigns the result back to the variable.

Example:
```cs
double price = 10.0;
price *= 1.1; // Equivalent to price = price * 1.1; (price is now 11.0)

```
## 5.3 Summary

Assignment operations are a fundamental aspect of C# programming. They allow you to store and manipulate data by assigning values to variables. While the basic assignment operator `=` is used to assign values directly, compound assignment operators like `+=`, `-=`, and `*=` combine arithmetic operations with assignment, making code more efficient and readable.






# 6. Comments

Comments are an essential aspect of programming in C#. They allow you to include explanatory text within your code to make it more understandable for yourself and other developers. Comments are ignored by the compiler and do not affect the program's execution.

## 6.1 Single-Line Comments

Single-line comments begin with two forward slashes `//` and continue until the end of the line. They are typically used for brief explanations or annotations.

Example:
```cs
// This is a single-line comment
int x = 5; // Assigning the value 5 to variable x

```
## 6.2 Multi-Line Comments

Multi-line comments, also known as block comments, are enclosed within `/*` and `*/` and can span multiple lines. They are often used for longer explanations, documenting functions, or commenting out large sections of code.

Example:
```cs
/*
   This is a multi-line comment.
   It can span multiple lines and is useful for detailed explanations.
   Uncommented code below:
*/
int y = 10;

```
## 6.3 XML Documentation Comments

XML documentation comments are a special type of comment used for documenting code elements like classes, methods, properties, and parameters. They are enclosed within `///` and can be used to generate documentation for your code.

Example:
```cs
/// <summary>
/// This is a method that adds two numbers.
/// </summary>
/// <param name="a">The first number to be added.</param>
/// <param name="b">The second number to be added.</param>
/// <returns>The sum of the two numbers.</returns>
int Add(int a, int b)
{
    return a + b;
}

```
## 6.4 Commenting Best Practices

  - Use comments to explain complex logic, non-obvious behavior, or your intent in the code.
  - Keep comments concise and focused on the relevant information.
  - Avoid over-commenting; code should be self-explanatory when possible.
  - Update comments when code changes to ensure they remain accurate.

## 6.5 Summary

Comments play a crucial role in making your code more understandable and maintainable. Whether you're providing explanations, documenting your code, or leaving notes for yourself and other developers, using comments effectively is an important skill in C# programming.






# 7. Decision Structures

Decision structures, also known as conditional statements, are fundamental in C# programming. They allow your program to make choices and execute different blocks of code based on specified conditions.

## 7.1 The `if` Statement

The `if` statement is used to execute a block of code if a specified condition is true. If the condition is false, the code block is skipped.
```cs
int age = 18;
if (age >= 18)
{
    Console.WriteLine("You are an adult.");
}

```
In this example, the message "You are an adult." will be displayed because the condition `age >= 18` is true.

## 7.2 The `else` Clause

The `else` clause can be added to an `if` statement to specify a block of code that will execute when the condition is false.
```cs
int age = 15;
if (age >= 18)
{
    Console.WriteLine("You are an adult.");
}
else
{
    Console.WriteLine("You are not yet an adult.");
}

```
In this example, the message "You are not yet an adult." will be displayed because the condition `age >= 18` is false.

## 7.3 The `else if` Clause

The `else if` clause is used to specify additional conditions to check if the previous `if` condition is false.
```cs
int score = 75;
if (score >= 90)
{
    Console.WriteLine("A");
}
else if (score >= 80)
{
    Console.WriteLine("B");
}
else if (score >= 70)
{
    Console.WriteLine("C");
}
else
{
    Console.WriteLine("D");
}

```
In this example, the program determines the grade based on the value of the `score` variable.

## 7.4 The `switch` Statement

The `switch` statement allows you to select one of many code blocks to be executed. It is often used when you have multiple cases to consider.
```cs
int dayOfWeek = 3;
string dayName;
switch (dayOfWeek)
{
    case 1:
        dayName = "Monday";
        break;
    case 2:
        dayName = "Tuesday";
        break;
    // More cases...
    default:
        dayName = "Unknown";
        break;
}

```
In this example, the `switch` statement assigns the corresponding `dayName` based on the value of `dayOfWeek`.

## 7.5 Summary

Decision structures are essential for controlling the flow of your C# programs. They allow you to execute different code paths based on conditions, making your programs more dynamic and responsive to user input or data.






# 8. Conditional Operators

Conditional operators, also known as ternary operators, provide a concise way to write conditional expressions in C#. They allow you to assign values to a variable based on a condition in a single line of code.

## 8.1 The Conditional (`? :`) Operator

The conditional operator `? :` is a ternary operator with the following syntax:
```cs
condition ? trueExpression : falseExpression;

```
  - `condition` is a Boolean expression that determines which expression to evaluate.
  - `trueExpression` is the value or expression to return when the condition is true.
  - `falseExpression` is the value or expression to return when the condition is false.

Example:
```cs
int num = 7;
string message = (num % 2 == 0) ? "Even" : "Odd";

```
In this example, if `num` is even, the `message` variable will be assigned the value "Even"; otherwise, it will be assigned the value "Odd."

## 8.2 Benefits of Conditional Operators

  - Conciseness: Conditional operators allow you to write compact code for simple conditional assignments.
  - Readability: They make the code more readable when the condition and expressions are straightforward.
  - Expressiveness: Conditional operators express the intent of the code clearly.

## 8.3 When to Use Conditional Operators

Conditional operators are best suited for simple conditional assignments where the expressions are short and easy to understand. For complex conditions or multiple expressions, it's often more readable to use traditional `if` and `else` statements.

## 8.4 Summary

Conditional operators provide a concise way to assign values based on conditions in C# code. They are particularly useful when you need to make simple conditional assignments in a single line of code.






# 9. Logic Operators

Logic operators, also known as Boolean operators, are used to manipulate and evaluate Boolean expressions in C#. They are essential for making decisions and controlling the flow of your program based on conditions.

## 9.1 Logical AND (`&&`) Operator

The logical AND operator `&&` is used to evaluate a condition as true only if both of its operands are true.

Example:
```cs
bool isWeekday = true;
bool isSunny = false;

if (isWeekday && isSunny)
{
    Console.WriteLine("Go to the park!");
}

```
In this example, "Go to the park!" will be displayed only if both `isWeekday` and `isSunny` are `true`.

## 9.2 Logical OR (`||`) Operator

The logical OR operator `||` is used to evaluate a condition as true if at least one of its operands is true.

Example:
```cs
bool hasCoffee = true;
bool hasTea = false;

if (hasCoffee || hasTea)
{
    Console.WriteLine("Enjoy your hot beverage!");
}

```
In this example, "Enjoy your hot beverage!" will be displayed because at least one of the conditions (`hasCoffee` in this case) is `true`.

## 9.3 Logical NOT (`!`) Operator

The logical NOT operator `!` is used to negate a Boolean expression. It changes `true` to `false` and `false` to `true`.

Example:
```cs
bool isRaining = true;

if (!isRaining)
{
    Console.WriteLine("You can go for a walk.");
}

```
In this example, "You can go for a walk." will be displayed because `!isRaining` evaluates to `false`.

## 9.4 Logical Operators Precedence

Logical AND (`&&`) has higher precedence than logical OR (`||`), which, in turn, has higher precedence than logical NOT (`!`). You can use parentheses to control the order of evaluation when necessary.

## 9.5 Summary

Logic operators are crucial for working with Boolean expressions and making decisions in C# programs. By using `&&`, `||`, and `!`, you can create complex conditions and control the flow of your code based on logical criteria.






# 10. Advanced Decision Structures

???





___





# 11. String Methods

???





___





# 12. Random Generation

???





___





# 13. Looping Structures

???





___





# 14. Functions/Methods

???





___





# 15. Elementary Data Structures

???





## 15.1 Arrays/Lists

???






## 15.2 Matrices

???





___





<!-- 
EVERYTHING BELOW IS OPTIONAL; 
UNCOMMENT BY REMOVING THE ARROW TAGS SURROUNDING
(i.e., delete the "< !--" and "-- >" tags)

CHANGE THE SECTION NUMBERS AS DESIRED
-->

<!-- # 16. Major Keywords

???





___ -->





<!-- # 17. Error Handling

???





___ -->





<!-- # 18. Working with Files

???





___ -->





<!-- # 19. Major Language Features

???







## 19.1 Classes

???





## 19.2 Inheritance

???





## 19.3 Generic Typing (Templates)

???





## 19.4 Pointers

???





___ -->





<!-- # 20. Importing Local Libraries

???





___ -->





<!-- # 21. Working with Time

???





___ -->





<!-- # 22. Importing Libaries from Package managers

???





___ -->





<!-- # 23. Bitwise Operators

???





___ -->





<!-- # 24. Common Data Structures

???





___ -->





<!-- # 25. Advanced Language Features

???





___ -->





# References

* [Markdown Cheatsheet](https://gist.github.com/jonschlinkert/5854601)
* [description](http://example.com)
