// See https://aka.ms/new-console-template for more information

#region Difference Between Compiler & Interpreter 

// https://www.youtube.com/watch?v=lui_SjvGl2I&list=PLoP3S2S1qTfBCtTYJ2dyy3mpn7aWAAjdN&index=6

#endregion

#region Variables
// Variables : is a Data Holder 


#region Variable Decleration 

/*Variable Decleration 
    DataType VariableName = VariableValue ; 

    DataType VariableName  ===> Variable Declaration 
    VariableValue ;  ===> Vaiable Assignment
    
    ex ==>  string Name = "Hossam Emara" ;

*/

string Name = "Hossam Emara";
string @float = "Hossam Emara"; // if you need to use reserved keywork we use @
double x = 10.5;
float y = 10.5f;

#endregion

#endregion

#region Data Types 

/*
  
 https://www.javatpoint.com/primitive-vs-non-primitive-data-structure

 
 # Primitive Data Types (Value Type)

 1. string ==> 16 bit per character	Stores a sequence of characters, surrounded by double quotes
 2. boolean ==> 1 bit	   true & false
 3. int  ==> 32 bit	   Stores whole numbers from -2,147,483,648 to 2,147,483,647
 4. long ==> 64 bit	   Stores whole numbers from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
 5. float ==> 32 bit	   Stores fractional numbers. Sufficient for storing 6 to 7 decimal digits
 6. double ==> 64 bit	   Stores fractional numbers. Sufficient for storing 15 decimal digits
 7. char	==> 16 bit	   Stores a single character/letter, surrounded by single quotes
 8. byte ==> Unsigned 8-bit integer	   Stores 0 to 255	
 9. uint ==> Unsigned 32-bit integer	0 to 4,294,967,295	
 
# Non Primitive Data Types (Reference Type)

1. Classes
2. Struct 
3. Enums 
4. Arrays 
5. String 

 /* See https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/value-types
   
   For C# Data Types 
 
 */




#region string Methods

Console.WriteLine("======== string Methods ========");
string UserName = "Hossam Emara";
Console.WriteLine($" .Length :: {UserName.Length}");   // Return int
Console.WriteLine($" ToUpper :: {UserName.ToUpper()}");
Console.WriteLine($" ToLower :: {UserName.ToLower()}");
Console.WriteLine($" StartsWith :: {UserName.StartsWith("H")}");  // Return Boolean
Console.WriteLine($" EndsWith :: {UserName.EndsWith("A")}");  // Return Boolean
Console.WriteLine($" Contains :: {UserName.Contains("H")}");  // Return Boolean


#endregion

#region Characters

char c = 'A';
Console.WriteLine($" Ascii Code for {c} {(int)c}"); // cast as int (ascii code)
Console.WriteLine($"{c} is digit ? {Char.IsDigit(c)}");
Console.WriteLine($"{c} is letter ? {Char.IsLetter(c)}");
char w = '1';
Console.WriteLine($"{w} is digit ? {Char.IsDigit(w)}");
Console.WriteLine($"{w} is letter ? {Char.IsLetter(w)}");
#endregion



#endregion

#region Logical Operators

/*
  &   (normal and )  ,  && (Short Circuit and)
  |   (normal and )  ,  || (Short Circuit and)
 */

bool flag = false;
bool flag2 = false;
bool flag3 = true;
Console.WriteLine("========= Logical Operators ========");
Console.WriteLine(flag & flag2 & flag3); // Check All Flags

Console.WriteLine(flag & flag2 & flag3); // if first left flag is false then not complete check and result false

Console.WriteLine(flag | flag2 | flag3); // Check All Flags

Console.WriteLine(flag || flag2 || flag3); // if first left flag is true then not complete check and result true

Console.WriteLine("===========================");
// int ascii = Console.Read(); // return ascii code of first inserted character
// Console.WriteLine($"return ascii code of first inserted character :: {ascii}");

#endregion

#region Arithmetic Operators

// +   -   *   /  % 
#endregion

#region Implicit Typing

var data = 6.7;
var data2 = "Hossam";

#endregion

#region Operator Precedence  اولويه التنفيذ
Console.WriteLine(6+7*9-1);
Console.WriteLine((6 + 7) * 9 - 1);
#endregion

#region Assignment Operators

int Number = 10;
Number += 1; // Same as Number = Number + 1
Console.WriteLine($"Number  = {Number}"); // 11

#endregion

#region Increment & Decrement Operators 

// Pre Increment & Decrement 

int Result1 = ++Number;
Console.WriteLine($"Result1  = {Result1}");
Console.WriteLine($"Number  = {Number}"); // 12

// Post Increment & Decrement

int Result2 = Number++;
Console.WriteLine($"Result2  = {Result2}");
Console.WriteLine($"Number  = {Number}"); // 13

#endregion

#region Comparison Operators
// == , != , > , < , >= , <=     Return True or False 

#endregion

#region String Parsing  
// Convert String To Differnet Data Types 

// 1. Parse 

Console.WriteLine("Enter Num1");
int Num1 = int.Parse(Console.ReadLine());
Console.WriteLine($"Num1  = {Num1}");
Console.WriteLine("Enter Num2");
double Num2 = double.Parse(Console.ReadLine());
Console.WriteLine($"Num2  = {Num2}");

// 2. Try Parse

string numberString = "123";
int number;
bool success = int.TryParse(numberString, out number);

if (success)
{
    Console.WriteLine("Parsing succeeded. Number: " + number); // Output: Parsing succeeded. Number: 123
}
else
{
    Console.WriteLine("Parsing failed.");
}


#endregion

#region Arrays 

/* 
 * Array Declaration
 * DataType [] ArrayName = {item1, item2, ..........}
 * DataType [] ArrayName = new DataType [ArraySize] 

 */

int[] Numbers = { };
int[] Nums = new int[5];
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Please Enter Item {i + 1}");
    bool Num = int.TryParse(Console.ReadLine(),out Nums[i]);
    //Console.WriteLine($"Num Bool is {Num}");
}

foreach (int i in Nums)
    Console.WriteLine($"Array Items :: {i}");

/*
 Sort()  , Copy()

 */
Array.Sort(Nums);

foreach (int i in Nums)
    Console.WriteLine($"Array Nums Items :: {i}");
int[] Nums2 = new int[5];
Array.Copy(Nums, Nums2, 3);
foreach (int i in Nums2)
    Console.WriteLine($"Array Nums2 Items :: {i}");

#endregion

#region Ternary Operators

// Condition ? TrueOutput : TrueOutput ;
Console.WriteLine(1 == 2 ? "Hossam" : "Siro");

#endregion

#region Foreach


// foreach (DataType i in IterableName)

#endregion

#region While & Do While

int n = 5;
while( n < 10 )
{
    Console.WriteLine(n++);
}

int n2 = 5;
do
{
    Console.WriteLine(n2++);
}
while (n2 < 5);


#endregion

#region Switch
Console.WriteLine("Please Enter Your Selection :: ");
string Option = Console.ReadLine();
switch(Option)
{
    case "1":
        Console.WriteLine(Name.ToUpper());
        break;
    case "2":
        Console.WriteLine(Name.ToLower());
        break;
    default:
        Console.WriteLine("Invalid Option !");
        break;
}

#endregion

#region Methods or Functions

/*
 Decleration 

 DataType FunctionName(Parameters)
 {
 
 }

 */

// Method Naming Should Start With Verb
/* Methods Types 
  1 . With Return Type 
  2. Without Return Type
 */


static void PrintHello(string welcome)
{

    Console.WriteLine(welcome);
}
PrintHello("Hello World"); // Method Invoking , Calling or Triggering

// Optional Parameters 
/* 
 Comments 
1. Single Line Comment
2. Multi Line Comment
3. Todo Comment //todo: This Todo
4. Xml Documentation /// Summary For Methods

 */
// todo: Take From User 
int[] numbersArray = new int[] {1,2,3,4,5 };
CalculateAverage(numbersArray);  // Method Invoke , Trigger or Calling
CalculateAverage(numbersArray, true);  // Method Invoke , Trigger or Calling
CalculateAverage(numbersArray, PrintAverage: true);  // Method Invoke , Trigger or Calling
// Xml Documnetation


static double CalculateAverage(int[] numbers,bool PrintAverage = false, bool PrintSum = false) // bool PrintAverage = false is Optional Parameters
{
    int sum = 0;
    double average = 0;
    foreach (int number in numbers)
    {
        sum += number;
    }
    average = sum / numbers.Length;
    if (PrintAverage)
        Console.WriteLine($"Average = {average}");
    return average;
}

#endregion

#region Value Types && Reference Type

/*

Value Type (Imutable): like  (int, uint, double , float, char , bool, struct)

1. value and Addresse Stored In Stack
2. Stack :  عباره عن مصفوفه يتم تخزين الذاكره فى كتل متجاوره ويتم الحذف والاضافه LIFO
3. يتم تخصيص الذاكره والغائها بواسطه الكومبيلر

Reference Type (mutable): (arrays, string)

1. value Stored in Heap and Addresse Stored In Stack 
2.  يتم التخصيص والحذف والاضافه بشكل عشوائى
3. يتم التخصيص بواسطه المبرمج ويتم الاغاء بواسطه ال GC
 
 */

// Value Type

int q1 = 5; // Addresse 1
int q2 = q1; // Addresse 2
q1 = 10; // Addresse 3
Console.WriteLine($"q1 = {q1}");
Console.WriteLine($"q2 = {q2}");

// Reference Types

int[] array1 = { 1,2,3}; // Addresse 1  , Value Stored in Heap Location
int[] array2 = array1; // Same Addresse 1, , Value Stored in Same Heap Location
array1[0] = 4;
array1[1] = 5;
array1[2] = 6;
Console.WriteLine($"array1[0] = {array1[0]}");
Console.WriteLine($"array1[0] = {array1[1]}");
Console.WriteLine($"array1[0] = {array1[2]}");
Console.WriteLine($"array2[0] = {array1[0]}");
Console.WriteLine($"array2[0] = {array2[1]}");
Console.WriteLine($"array2[0] = {array2[2]}");

int num = 5;
DuplicateNumber(num);
Console.WriteLine($"num = {num}");
int [] numbersArr = { 1, 2, 3 };
DuplicateNumbers(numbersArr);
Console.WriteLine($"numbersArr[0]}}  = {numbersArr[0]}");
Console.WriteLine($"numbersArr[1]}}  = {numbersArr[1]}");
Console.WriteLine($"numbersArr[2]}}  = {numbersArr[2]}");
static void DuplicateNumber(int num)
{
    num *= 2;
}

static void DuplicateNumbers(int [] nums)
{
    for (int i = 0; i < nums.Length; i++)
        nums[i] *= 2; 
}

#endregion

#region Value Type Casting

// 1. Implicit Casting (Boxing)(Safe Casting) Put Small Size Into Big Size i.e 
// Put int Into float , byte into int ....

byte S1 = 200;
int S2 = S1;
Console.WriteLine(S2);
int S3 = 200;
long S4 = S3;
Console.WriteLine(S4);



// 2. Explicit Casting (Unboxing)(Unsafe Casting) Put Big Size Into Small Size

// if You Need This Casting Raise Exception
checked
{

    //long U1 = 33333;
    //byte U2 = (byte)U1;
    //Console.WriteLine(U2);

}

// if You Need This Casting Not Raise Exception This Only Brackets Block
unchecked
{
   

}

// 3. Convert

int Age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Age  = {Age}");


// 4. Parse

// Parse 

Console.WriteLine("Enter Num3");
int Num3 = int.Parse(Console.ReadLine());
Console.WriteLine($"Num3  = {Num3}");
Console.WriteLine("Enter Num4");
double Num4 = double.Parse(Console.ReadLine());
Console.WriteLine($"Num4  = {Num4}");

// Try Parse

string NumberString = "123";
int Number0;
bool SuccessConvert = int.TryParse(NumberString, out Number0);

if (SuccessConvert)
{
    Console.WriteLine("Parsing succeeded. Number: " + Number0); // Output: Parsing succeeded. Number: 123
}
else
{
    Console.WriteLine("Parsing failed.");
}




#endregion

#region Goto

int r = 0;
start:
Console.WriteLine(r);
r++;
if (r < 5)
    goto start;

Console.ReadLine();

#endregion

#region C# Exercises

// see  https://www.w3resource.com/csharp-exercises/ C# Sharp Programming Exercises, Practice, Solution

// C# Sharp Basic Algorithm: Exercises, Practice, Solution

// 1. Write a C# Sharp program to compute the sum of the two numerical values. If the two values are the same, return triple their sum.

Console.WriteLine("Please Enter The First Number :: \n");
int FirstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Please Enter The Second Number :: ");
int SecondNumber = int.Parse(Console.ReadLine());
int Sum = FirstNumber + SecondNumber;
if(FirstNumber == SecondNumber)
    Console.WriteLine($"3 * FirstNumber {3 * FirstNumber}");
else
    Console.WriteLine($"The Sum of Two Number {FirstNumber} &&  {SecondNumber} = {Sum}");


#endregion


