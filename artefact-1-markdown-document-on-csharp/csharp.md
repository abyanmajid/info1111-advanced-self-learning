# C# Quick Overview

## Data Types and Operators

### Data Types
C# is a strongly-typed language, meaning each variable must be declared with a data type. This ensures that operations performed on variables are type-checked at compile time. Common data types include:

- **Integer Types**: Used to store whole numbers.
  - `byte` (8-bit): Range from 0 to 255.
  - `sbyte` (8-bit): Range from -128 to 127.
  - `short` (16-bit): Range from -32,768 to 32,767.
  - `ushort` (16-bit): Range from 0 to 65,535.
  - `int` (32-bit): Range from -2,147,483,648 to 2,147,483,647.
  - `uint` (32-bit): Range from 0 to 4,294,967,295.
  - `long` (64-bit): Range from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807.
  - `ulong` (64-bit): Range from 0 to 18,446,744,073,709,551,615.

- **Floating-Point Types**: Used to store real numbers with fractional parts.
  - `float` (32-bit): Approximate range of ±1.5e−45 to ±3.4e38, 7 digits of precision.
  - `double` (64-bit): Approximate range of ±5.0e−324 to ±1.7e308, 15-16 digits of precision.
  - `decimal` (128-bit): Used for financial and monetary calculations requiring high precision (28-29 significant digits).

- **Boolean Type**: Represents true or false values.
  - `bool`: Can hold either `true` or `false`.

- **Character Type**: Used to store a single character.
  - `char`: A single 16-bit Unicode character.

- **String Type**: Used to store sequences of characters.
  - `string`: A sequence of `char` values.

- **Object Type**: The base type for all other types in C#. It can store any data type.
  - `object`: Any type can be assigned to an `object` variable.

### Operators

#### Arithmetic Operators
These operators are used for basic mathematical operations.

- `+` (Addition): Adds two operands.
- `-` (Subtraction): Subtracts the second operand from the first.
- `*` (Multiplication): Multiplies two operands.
- `/` (Division): Divides the first operand by the second. If the second operand is zero, it throws a runtime exception.
- `%` (Modulus): Returns the remainder of a division operation.

#### Comparison Operators
These operators are used to compare two values.

- `==` (Equal to): Returns `true` if both operands are equal.
- `!=` (Not equal to): Returns `true` if operands are not equal.
- `>` (Greater than): Returns `true` if the left operand is greater than the right.
- `<` (Less than): Returns `true` if the left operand is less than the right.
- `>=` (Greater than or equal to): Returns `true` if the left operand is greater than or equal to the right.
- `<=` (Less than or equal to): Returns `true` if the left operand is less than or equal to the right.

#### Logical Operators
These operators are used to perform logical operations.

- `&&` (Logical AND): Returns `true` if both operands are true.
- `||` (Logical OR): Returns `true` if at least one of the operands is true.
- `!` (Logical NOT): Reverses the logical state of its operand.

#### Assignment Operators
These operators are used to assign values to variables.

- `=` (Assign): Assigns the right-hand operand to the left-hand operand.
- `+=` (Add and assign): Adds the right-hand operand to the left-hand operand and assigns the result to the left-hand operand.
- `-=` (Subtract and assign): Subtracts the right-hand operand from the left-hand operand and assigns the result to the left-hand operand.
- `*=` (Multiply and assign): Multiplies the left-hand operand by the right-hand operand and assigns the result to the left-hand operand.
- `/=` (Divide and assign): Divides the left-hand operand by the right-hand operand and assigns the result to the left-hand operand.
- `%=` (Modulus and assign): Computes the modulus using two operands and assigns the result to the left-hand operand.

#### Unary Operators
These operators are used with only one operand.

- `+` (Unary plus): Indicates a positive value (usually redundant).
- `-` (Unary minus): Negates a value.
- `++` (Increment): Increases an integer value by one.
- `--` (Decrement): Decreases an integer value by one.
- `!` (Logical negation): Reverses the logical state of its operand.

#### Bitwise Operators
These operators are used to perform bit-level operations.

- `&` (AND): Performs a bitwise AND operation.
- `|` (OR): Performs a bitwise OR operation.
- `^` (XOR): Performs a bitwise exclusive OR operation.
- `~` (Complement): Inverts each bit of its operand.
- `<<` (Left shift): Shifts bits to the left.
- `>>` (Right shift): Shifts bits to the right.

---

## Classes, Objects, and Methods

### Classes
Classes are the blueprint for objects in C#. They encapsulate data for the object and methods to manipulate that data. A class defines properties and behaviors of the objects created from it.

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

Objects are instances of classes. When a class is defined, no memory is allocated until an object of that class is created.
```csharp
Car myCar = new Car("Toyota", "Corolla", 2020);
myCar.DisplayInfo();
```

### Methods

Methods define the behavior of a class. They are blocks of code that perform a specific task.
```csharp
public void Drive()
{
    Cosnole.WriteLine("The car is driving");
}
```

## Functions and Control Flow Statements

### Functions

Functions (also known as methods in C#) are blocks of code that perform a task. They are defined within a class and can be called to perform their task.

```csharp
public int Add(int a, int b)
{
    return a + b;
}
```

### Decision Statements

Decision statements allow you to control the flow of execution based on conditions.

#### `if` statement

Executes a block of code if a specified condition is true.

```csharp
if (condition)
{
    // Code to execute if condition is true
}
```

#### `if` and `else` statement

Executes one block of code if a condition is true and another block if the condition is false.

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

#### `else if` statement

Checks multiple conditions and executes corresponding blocks of code.

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

#### `switch` statement

Allows you to select one of many code blocks to execute based on the value of a variable.

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

Loop statements allow you to execute a block of code multiple times.

#### `for` loop

Executes a block of code a specified number of times.

```csharp
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}
```

#### `foreach` loop

Iterates through a collection (such as an array or list) and executes a block of code for each element.

```csharp
string[] fruits = { "Apple", "Banana", "Cherry" };
foreach (string fruit in fruits)
{
    Console.WriteLine(fruit);
}
```


#### `while` loop


#### `do` and `while` loop

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
