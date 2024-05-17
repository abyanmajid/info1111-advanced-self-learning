# C# Comprehensive Guide

## Table of Contents
1. [Data Types and Operators](#data-types-and-operators)
2. [Classes, Objects, and Methods](#classes-objects-and-methods)
3. [Functions and Control Flow Statements](#functions-and-control-flow-statements)
4. [Shorthand Symbols and Type Casting](#shorthand-symbols-and-type-casting)

---

## Data Types and Operators

### Data Types
C# is a strongly-typed language, meaning each variable must be declared with a data type. Common data types include:

- **Integer Types**
  - `byte` (8-bit): 0 to 255
  - `sbyte` (8-bit): -128 to 127
  - `short` (16-bit): -32,768 to 32,767
  - `ushort` (16-bit): 0 to 65,535
  - `int` (32-bit): -2,147,483,648 to 2,147,483,647
  - `uint` (32-bit): 0 to 4,294,967,295
  - `long` (64-bit): -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
  - `ulong` (64-bit): 0 to 18,446,744,073,709,551,615

- **Floating-Point Types**
  - `float` (32-bit): ±1.5e−45 to ±3.4e38 (7 digits of precision)
  - `double` (64-bit): ±5.0e−324 to ±1.7e308 (15-16 digits of precision)
  - `decimal` (128-bit): ±1.0e−28 to ±7.9e28 (28-29 digits of precision)

- **Boolean Type**
  - `bool`: `true` or `false`

- **Character Type**
  - `char`: A single 16-bit Unicode character

- **String Type**
  - `string`: A sequence of characters

- **Object Type**
  - `object`: The base type for all other types in C#

### Operators

#### Arithmetic Operators
- `+` (Addition)
- `-` (Subtraction)
- `*` (Multiplication)
- `/` (Division)
- `%` (Modulus)

#### Comparison Operators
- `==` (Equal to)
- `!=` (Not equal to)
- `>` (Greater than)
- `<` (Less than)
- `>=` (Greater than or equal to)
- `<=` (Less than or equal to)

#### Logical Operators
- `&&` (Logical AND)
- `||` (Logical OR)
- `!` (Logical NOT)

#### Assignment Operators
- `=` (Assign)
- `+=` (Add and assign)
- `-=` (Subtract and assign)
- `*=` (Multiply and assign)
- `/=` (Divide and assign)
- `%=` (Modulus and assign)

#### Unary Operators
- `+` (Unary plus)
- `-` (Unary minus)
- `++` (Increment)
- `--` (Decrement)
- `!` (Logical negation)

#### Bitwise Operators
- `&` (AND)
- `|` (OR)
- `^` (XOR)
- `~` (Complement)
- `<<` (Left shift)
- `>>` (Right shift)

---

## Classes, Objects, and Methods

### Classes
Classes are the blueprint for objects in C#. They encapsulate data for the object and methods to manipulate that data.

```csharp
public class Car
{
    // Fields
    public string make;
    public string model;
    public int year;

    // Constructor
    public Car(string make, string model, int year)
    {
        this.make = make;
        this.model = model;
        this.year = year;
    }

    // Method
    public void DisplayInfo()
    {
        Console.WriteLine($"Make: {make}, Model: {model}, Year: {year}");
    }
}
```

### Objects

Objects are instances of classes.
```csharp
Car myCar = new Car("Toyota", "Corolla", 2020);
myCar.DisplayInfo();
```

### Methods

Methods define the behavior of a class.
```csharp
public void Drive()
{
    Cosnole.WriteLine("The car is driving");
}
```

## Functions and Control Flow Statements

### Functions

Functions (also known as methods in C\#) are blocks of code that perform a task.

### Decision Statements

#### If statement

```csharp
if (condition)
{
    // Code to execute if condition is true
}
```

#### If-else statement

```csharp
if (condition)
{
    // Code to execute if condition is true
}
else
{
    // Code to execute if condition is false
}
```

#### Else if statement

```csharp
if (condition1)
{
    // Code to execute if condition1 is true
}
else if (condition2)
{
    // Code to execute if condition2 is true
}
else
{
    // Code to execute if none of the above conditions are true
}
```

#### Switch statement

```csharp
switch (variable)
{
    case value1:
        // Code to execute if variable equals value1
        break;
    case value2:
        // Code to execute if variable equals value2
        break;
    default:
        // Code to execute if variable doesn't match any case
        break;
}
```

### Loop statements

#### for loop

```csharp
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}
```

#### foreach loop


#### while loop


#### do-while loop

### Shorthand symbols and type casting

#### Shorthand symbols

Ternary operators
```csharp
int number = 10;
string result = (number > 5) ? "Greater than 5" : "Less than or equal to 5";
```

#### Type casting

Implicit casting is done automatically when a value is converted to a larger data type

```csharp
int num = 123;
double doubleNum = num; // Automatic casting: int to double
```

Explicit casting must be done manually be placing the type in aprantheses in front of the value

```
double doubleNum = 123.45;
int num = (int)doubleNum; // Manual casting: double to int
```

Convert class using `Convert`

```
string strNum = "123";
int num = Convert.ToInt32(strNum);
```

Parse methods using `Parse`
```csharp
string strNum = "123";
int num = int.Parse(strNum);
```
