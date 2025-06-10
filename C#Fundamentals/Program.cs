// See https://aka.ms/new-console-template for more information
using St = C_Fundamentals.Classes.InternalClasses.Student; // Aliass Names
using C_Fundamentals.Classes;
using System.Text;
using C_Fundamentals.Classes.InternalClasses;
using Student = C_Fundamentals.Classes.Student;  // Aliass Names
using Std = CSharpFundamentalsCL.Modeles.Student;
//  using Emp = CSharpFundamentalsCL.Modeles.Employee;  // Internal Not Accessables Outside CSharpFundamentalsCL Assemply 
using C_Fundamentals.Enums;
using System.Collections;
using C_Fundamentals.Services;
using C_Fundamentals.Interfaces;

#region 1.Difference Between Compiler & Interpreter 

// https://www.youtube.com/watch?v=lui_SjvGl2I&list=PLoP3S2S1qTfBCtTYJ2dyy3mpn7aWAAjdN&index=6
// https://chatgpt.com/share/eae0b054-8fdf-4ead-b54c-03edd0da41e5

#endregion


#region 2. Variables
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


#region 3. Data Types 

/*
  
 https://www.javatpoint.com/primitive-vs-non-primitive-data-structure

 
 # Primitive Data Types (Value Type)

 1. boolean ==> 1 bit	   true & false
 2. int  ==> 32 bit	   Stores whole numbers from -2,147,483,648 to 2,147,483,647
 3. long ==> 64 bit	   Stores whole numbers from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
 4. float ==> 32 bit	   Stores fractional numbers. Sufficient for storing 6 to 7 decimal digits
 5. double ==> 64 bit	   Stores fractional numbers. Sufficient for storing 15 decimal digits
 6. char	==> 16 bit	   Stores a single character/letter, surrounded by single quotes
 7. byte ==> Unsigned 8-bit integer	   Stores 0 to 255	
 8. uint ==> Unsigned 32-bit integer	0 to 4,294,967,295	
 
# Non Primitive Data Types (Reference Type)

1. Classes
2. Struct 
3. Enums 
4. Arrays 
5. String 

 /* See https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/value-types
   
   For C# Data Types 
 
 */


#region Stack and Heap

// https://chatgpt.com/share/eae0b054-8fdf-4ead-b54c-03edd0da41e5

/*
Stack and heap are two types of memory used by programs to store data during execution. They are used for different purposes and have distinct characteristics:

==> Stack:

* Purpose: The stack is used for static memory allocation, primarily for storing local variables, function parameters, and return addresses.It is also used to manage the flow of function calls.
* Memory Allocation: Memory on the stack is allocated and deallocated automatically as functions are called and return.
* Size: The stack has a limited, predefined size, usually much smaller than the heap.
* Access: The stack operates on a Last-In, First-Out (LIFO) principle. When a function is called, its variables are pushed onto the stack, and when the function returns, they are popped off.
* Speed: Access to stack memory is very fast because of its simple structure and proximity to the CPU.
* Scope: Variables stored on the stack are only accessible within the function that created them.
* Lifetime: The lifetime of stack variables is limited to the duration of the function call. Once the function returns, the memory is automatically reclaimed.

==> Heap:

* Purpose: The heap is used for dynamic memory allocation, where memory is allocated and deallocated explicitly by the programmer or automatically by a garbage collector.
* Memory Allocation: Memory on the heap is managed manually in languages like C / C++(using malloc and free) or automatically in languages like Java and Python (via garbage collection).
* Size: The heap is larger than the stack and can grow as needed, up to the limits of the system's available memory.
* Access: Memory on the heap is accessed via pointers or references, and there is no particular order to how memory is allocated or freed.
* Speed: Access to heap memory is slower compared to stack memory due to the overhead of dynamic allocation and pointer dereferencing.
* Scope: Variables stored on the heap can be accessed from anywhere in the program, provided you have a reference or pointer to that memory.
* Lifetime: The lifetime of heap variables can extend beyond the scope of a single function, persisting until they are explicitly deallocated or garbage collected.

# Key Differences:

* Allocation / Deallocation: Stack memory is automatically managed, while heap memory requires explicit management.
* Size and Flexibility: The stack is limited in size and more rigid, while the heap is larger and more flexible, allowing for dynamic memory needs.
* Speed: Stack operations are faster due to their straightforward nature, while heap operations can be slower due to the complexity of dynamic memory management.
* Fragmentation: The heap can suffer from memory fragmentation, where free memory is scattered in small blocks, making it difficult to allocate large contiguous blocks of memory. The stack does not suffer from fragmentation.

# Use Cases:

* Stack: Ideal for small, temporary variables, such as function arguments or local variables that do not need to persist outside the function.
* Heap: Used for larger, complex data structures like dynamic arrays, linked lists, or objects that need to exist beyond the scope of a single function.

 */
#endregion


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


#region 4. Logical Operators

/*
  &   (normal and )  ,  && (Short Circuit and)
  |   (normal and )  ,  || (Short Circuit and)
 */

bool flag = false;
bool flag2 = false;
bool flag3 = true;
Console.WriteLine("========= Logical Operators ========");
Console.WriteLine(flag & flag2 & flag3); // Check All Flags

Console.WriteLine(flag && flag2 && flag3); // if first left flag is false then not complete check and result false

Console.WriteLine(flag | flag2 | flag3); // Check All Flags

Console.WriteLine(flag || flag2 || flag3); // if first left flag is true then not complete check and result true

Console.WriteLine("===========================");
// int ascii = Console.Read(); // return ascii code of first inserted character
// Console.WriteLine($"return ascii code of first inserted character :: {ascii}");

#endregion


#region 5. Arithmetic Operators

// +   -   *   /  % 
#endregion


#region 6. Implicit Typing

var data = 6.7;
var data2 = "Hossam";

#endregion


#region 7. Operator Precedence  اولويه التنفيذ
Console.WriteLine(6+7*9-1);
Console.WriteLine((6 + 7) * 9 - 1);
#endregion


#region 8. Assignment Operators

int Number = 10;
Number += 1; // Same as Number = Number + 1
Console.WriteLine($"Number  = {Number}"); // 11

#endregion


#region 9. Increment & Decrement Operators 

// Pre Increment & Decrement 

int Result1 = ++Number;
Console.WriteLine($"++Number  = {++Number}"); // 13
Console.WriteLine($"Result1  = {Result1}"); // 12
Console.WriteLine($"Number  = {Number}"); // 13

// Post Increment & Decrement

int Result2 = Number++;
Console.WriteLine($"Number++  = {Number++}"); // 14
Console.WriteLine($"Number++  = {Number++}"); // 15
Console.WriteLine($"Result2  = {Result2}"); // 13
Console.WriteLine($"Number  = {Number}"); // 16

#endregion


#region 10 Comparison Operators
// == , != , > , < , >= , <=     Return True or False 

#endregion


#region 11. String Parsing  
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


#region 12. Arrays 

/* 
 * Array Declaration
 * DataType [] ArrayName = {item1, item2, ..........}
 * DataType [] ArrayName = new DataType [ArraySize] 

 */

int[] Numbers = { };
int[] Nums = new int[5];
for (int i = 0; i < Nums.Length; i++)
{
    Console.WriteLine($"Please Enter Item {i + 1}");
    bool Num = int.TryParse(Console.ReadLine(),out Nums[i]);
    Console.WriteLine($"Num Bool is {Num}");
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
Array.Copy(Nums, Nums2, 4);
foreach (int i in Nums2)
    Console.WriteLine($"Array Nums2 Items :: {i}");

#endregion


#region 13. Ternary Operators

// Condition ? TrueOutput : TrueOutput ;
Console.WriteLine(1 == 2 ? "Hossam" : "Siro");

#endregion


#region 14. Foreach && For


// foreach (DataType i in IterableName)

/* 
 
for(int x = 0; x<10 ; x++)
{

}

 */
#endregion


#region 15. While & Do While

int n = 5;
while(n < 10)
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


#region 16. Switch
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


#region 17. Methods or Functions

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

int[] numbersArray = new int[] {1,2,3,4,5 };
CalculateAverage(numbersArray);  // Method Invoke , Trigger or Calling
CalculateAverage(numbersArray, false);  // Method Invoke , Trigger or Calling
CalculateAverage(numbersArray, PrintAverage: false);  // Method Invoke , Trigger or Calling


static double CalculateAverage(int[] numbers,bool PrintAverage = true, bool PrintSum = false) // bool PrintAverage = false is Optional Parameters
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


#region 18. Comments

/* 
 Comments 
1. Single Line Comment
2. Multi Line Comment
3. Todo Comment //todo: This Todo
4. Xml Documentation /// Summary For Methods

 */
// todo: Take From User
// Xml Documnetation


#endregion


// todo: Study Value Types && Reference Type
#region 19. Value Types && Reference Type

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
Console.WriteLine($"array2[0] = {array2[0]}");
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


#region 20. Value Type Casting

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


#region 21. Goto

int r = 0;
start:
Console.WriteLine(r);
r++;
if (r < 5)
    goto start;

Console.ReadLine();

#endregion


#region 22. String Split and Join

// Split(Seperator)  == > Convert String To Array of Strings

Console.WriteLine("Please enter string Words Sperrated by , ");
string? words = Console.ReadLine();
if (string.IsNullOrEmpty(words))
{
    Console.WriteLine("No words entered.");
}

else
{
    string[] WordsArray = words.Split(",");
    foreach (var item in WordsArray)
    {
        Console.WriteLine(item);
    }
}

// Join (Seperator, Input Array)  == > Convert Array to Strings
string[] Words = { "Hossam", "Siro" };
string StringWords = string.Join(",", Words);
Console.WriteLine(StringWords);

#endregion


#region 23. String Builder

// String Builder Use Linked list Data Structure
string str = "Hello";
str = "Hello Pacionate ";
str+= "World";
// We Have 3 Memory Locations In Heap This Will Make Low Performance
Console.WriteLine(str);


/* 
 String Builder Have Default Capacity This Capacity Extends Automatically
 This Make Memory High Performance
*/
StringBuilder sb = new StringBuilder();
sb.Append("Hello Pacionate");
Console.WriteLine($"Lenght {sb.Length}");
Console.WriteLine($"Capacity {sb.Capacity}");
Console.WriteLine($"MaxCapacity {sb.MaxCapacity}");

sb.Append("Coders");

Console.WriteLine($"Lenght {sb.Length}");
Console.WriteLine($"Capacity {sb.Capacity}");
Console.WriteLine($"MaxCapacity {sb.MaxCapacity}");
// We Can Set Default Capacity Using ===> 
StringBuilder sb2 = new StringBuilder(4095); // Default Capacity 4096

Console.WriteLine($"Lenght {sb.Length}");
Console.WriteLine($"Capacity {sb.Capacity}");
Console.WriteLine($"MaxCapacity {sb.MaxCapacity}");

#endregion


#region 24. Compilation Process



#endregion


#region 25. Class  & Object

// Class is Complex Reference Type Data Type 
St s = new St("Cairo"); // To Solve Conflict
C_Fundamentals.Classes.Student s1 = new C_Fundamentals.Classes.Student(30) { Name="Hossam",Salary=100};  // Object Initializer // init only
s1.GetHashCode();  // Class Inherit From Object
//Student s2 = new Student(30, Id = 1); // Can't Set Id
C_Fundamentals.Classes.Student [] students = new C_Fundamentals.Classes.Student [] {} ;

/* 
 
Constructor ==> Special Type of Method Used For Class Initialization
    This Methos Executed When We Create Object From Class
    There's Default and User Defined Constructor
    


  Properties (Data, Attributes): Code Member to Control Reading and Writing For Variables 




Student st1 = new Student(30);
st1.Gender = "Male";
//Console.WriteLine(st1.Gender); this set only property


*/




#endregion


#region 26. Constant and Readonly

const float Pi = 3.14f;

// s1._message Readonly Can't Chage Here 

//const float Pi; // Not Allowed

// const vs readonly 

/*
 const :

1. compile time execution
2. We Can't Change its Value 
3. We Must Give it Value at Same line

 readonly:

1. runtime execution
2. We Can Change its Value at it's Class Constructor only
3. We Mustn't Give it Value at Same line
 */


#endregion

#region 27. Access Modifiers 

var Stu = new Std();


//1. puplic ==> all type
//2. internal ==>  the same project
//3. private ==> the same type
//4. protected ==>  the same class and it's child classs
//5. protected internal ==>  the same project and every type inherit from this assemply


// Types  (internal) ==> Default


// Type Members  (Private) ==> Default 



#endregion

#region 28. Static Class vs Non Static Class 

/* 
  Static Class
 
We Can't Have Instance From Static Class 
 Static Constructor Excecute One Time When We Use This Static Class 

 */

StaticClass.Name = "Hossam";
StaticClass.Name = "Siro";
Console.WriteLine(StaticClass.PrintHello());

/* 

  Non Static Class
 
We Can Have Instance From Non Static Class 
Non Static Constructor Excecute everytime We Use This Non Static Class 



 */
NonStaticClass nsc = new NonStaticClass();
NonStaticClass nsc2 = new NonStaticClass();
NonStaticClass nsc3 = new NonStaticClass();
NonStaticClass nsc4 = new NonStaticClass();
NonStaticClass.Name = "Hossam";
NonStaticClass.Name = "Siro";
Console.WriteLine(NonStaticClass.PrintHello());


#endregion


#region 29. Variables Scope

/*

 1. Class Level Scope 
 2. Method Level Scope 
 3. Block Level Scope

 */



#endregion


#region 30. Pass by Value & Pass by Reverence



//Cast value type to be reverence type 

bool isSucess = true;
var result = Divide(10, 0, isSucess);
Console.WriteLine(isSucess);
Console.WriteLine(result);

bool isSucess2 = true; // Must Assign value
var result2 = Divide2(10, 0,ref isSucess2);
Console.WriteLine(isSucess2);
Console.WriteLine(result2);

bool isSucess3; // Mustn't Assign value
var result3 = Divide3(10, 0, out isSucess3);
Console.WriteLine(isSucess3);
Console.WriteLine(result3);

static double Divide(double number , double divisor, bool isSucess)
{
    if (divisor == 0)
    {
        isSucess = false;
        return 0;
    }
    isSucess = true;
    return number / divisor;
        
}
static double Divide2(double number, double divisor,ref bool isSucess)
{
    if (divisor == 0)
    {
        isSucess = false; // We Can Comment This 
        return 0;
    }
    isSucess = true; // We Can Comment This
    return number / divisor;

}

static double Divide3(double number, double divisor, out bool isSucess)
{
    if (divisor == 0)
    {
        isSucess = false; // If We Comment This This Raise Compilation Errror 
        return 0;
    }
    isSucess = true; // If We Comment This This Raise Compilation Errror 
    return number / divisor;

}


#endregion


#region 31. Exceptions

try
{
    int g1 = 10;
    int g2 = 0;
    Console.WriteLine(g1/g2);
}
catch (Exception e)
{
    Console.WriteLine(e);
}
finally
{
    Console.WriteLine("Always Executed");
}


#endregion


#region 32. Enums

// Enums : Range of Related Constans Like Week Days, Month Days , or Genders

/* 
  Types: 
  1. Simple Enum 
  2. Flags Enums 
  
 */





WeekDays weekEndDays = WeekDays.Saturday ;
Console.WriteLine(weekEndDays);


/*  bitwise operators (|, &, ~, ^)
 
  |  ==> Compite operator
  &  ==> Common operator
  ~  ==> Except operator
  ^  ==> Toogle operator

 */


//   |  ==> Compite operator
Seasons ColdSeasons = Seasons.Winter | Seasons.Autumn;
Seasons HotSeasons = Seasons.Spring | Seasons.Summer;
Console.WriteLine($"ColdSeasons :: {ColdSeasons}");
Console.WriteLine($"HotSeasons :: {HotSeasons}");

// &  ==> Common operator
Seasons se1 = Seasons.Winter | Seasons.Summer;
Seasons se2 = Seasons.Spring | Seasons.Summer;
Console.WriteLine(se1 & se2);


// ~  ==> Except operator
Seasons se3 = Seasons.Winter | Seasons.Summer;
Seasons se4 = Seasons.Summer;
Console.WriteLine(se3 & ~ se4);


Seasons se5 = Seasons.Winter | Seasons.Spring;
Console.WriteLine(se5 & ~ Seasons.Summer);

// ^ ==> Toogle operator
Seasons se6 = Seasons.Winter | Seasons.Spring;
Console.WriteLine(se6 ^ Seasons.Summer);
Console.WriteLine(se6 ^ Seasons.Winter);






#endregion


#region 33. Abstract Class vs Sealed Class 

/*
1. Instantiation:

* Abstract classes cannot be instantiated directly.

* Sealed classes can be instantiated.

2. Inheritance:

* Abstract classes are meant to be inherited from.

* Sealed classes cannot be inherited.

3. Purpose:

* Abstract classes provide a template and enforce implementation in derived classes.

* Sealed classes restrict inheritance to ensure the class's implementation remains unchanged.

4. Conclusion

* Abstract Class: Use when you need to define a base class that provides some implementation and defines a contract for derived classes.

* Sealed Class: Use when you want to prevent any further subclassing of a class to finalize its implementation and ensure it cannot be altered through inheritance.

 */

Circle cr1 = new Circle { raduis = 5 };
cr1.PrintArea();   
Rectangle rc1 = new Rectangle { width = 5 , height =6};
rc1.PrintArea();

// AbstractShape shape2 = new AbstractShape { raduis = 3 }; Can't be instantiated directly

AbstractShape cr2 = new DerivedCircle { raduis = 3 };
cr2.PrintArea();

AbstractShape rc2 = new DerivedRectangle { width = 3, height = 7 };
rc2.PrintArea();


SealedClass sc = new SealedClass(); // Sealed classes cannot be inherited.
sc.MyProperty = "Hello";
Console.WriteLine(sc.MyProperty);


#endregion


#region 34. virtual and protected members

// virtual 
// protected : متشاف داخل الكلاس اللى انا فيه واى كلاس بيورث منه 
// protected internal : متشاف داخل الكلاس اللى انا فيه واى كلاس بيورث منه 

/*
 //////   https://chatgpt.com/share/3c748164-6dea-4c54-811a-c10988355407
Protected ===> 

Definition:

* The protected access modifier limits the visibility of a member to the containing class and any class derived from it.
Usage:

* Use protected when you want to allow derived classes to access the member but prevent access from other classes, even those in the same assembly.

Accessibility:

* Accessible within the same class.
* Accessible within derived classes (regardless of whether they are in the same assembly or not).
 

Protected Internal ===> 

 Definition:

* The protected internal access modifier combines the functionalities of protected and internal. It makes a member accessible within its own assembly and also in derived classes.
Usage:

* Use protected internal when you want to allow access to the member by any code in the same assembly, as well as by derived classes, even if they are in a different assembly.

Accessibility:

* Accessible within the same class.
* Accessible within derived classes (regardless of the assembly).
* Accessible within any class in the same assembly.
 
 */

#endregion


#region 35. Member Hiding/Shadowing or Static binding & dynamic binding 


// used if yo can't edit the base class 
AbstractShape rc3 = new DerivedRectangle { width = 5, height = 6 };
rc3.PrintArea2();

DerivedRectangle rc4 = new DerivedRectangle { width = 5, height = 6 };
rc4.PrintArea2();

#endregion


#region 36. Interface


/* interface :
 
 is a contract that defines a set of methods, properties, events, or indexers without implementing them. 
Classes or structs that implement an interface must provide implementations for all its members
 

Practical Uses of Interfaces ===> 

* Dependency Injection:

Interfaces are often used in dependency injection to decouple the implementation from the abstraction, 
allowing for more flexible and testable code.

* Decoupling Code:

By programming to an interface rather than an implementation, 
you can change the underlying implementation without changing the code that depends on the interface.

* Multiple Inheritance of Behavior:

Since C# does not support multiple inheritance for classes, interfaces provide a way to achieve 
a similar effect by allowing a class to implement multiple interfaces.

 * Design Patterns:

Interfaces are a key component in many design patterns (e.g., Strategy, Observer, Factory) 
to achieve flexibility and extensibility.

Conclusion :::

Interfaces in C# are a powerful tool for defining contracts and achieving polymorphism. 

They promote code reusability, flexibility, and maintainability 
by allowing different classes or structs to implement the same set of methods and properties 
in their own way.
Understanding how and when to use interfaces is crucial for designing robust and scalable applications.


 */


// interface vs abstract class 
/*
 
 ============ Abstract Class  ===========
Definition:

An abstract class is a class that cannot be instantiated on its own and must be subclassed. It can contain both abstract members (which must be implemented by derived classes) and concrete members (with implementation).

Characteristics 

Implementation: Can contain method implementations.
Members: Can have fields, properties, methods, events, and constructors.
Access Modifiers: Members can have different access levels (public, protected, private, etc.).
Multiple Inheritance: A class can inherit from only one abstract class due to single inheritance.

Use Cases: 

When you want to share common code among related classes.
When you want to provide default behavior that derived classes can override.
When you want to define non-public members.


============ Interface ============
Definition:  
An interface defines a contract with no implementation. Classes or structs that implement an interface must provide implementations for all its members.

Characteristics 

Implementation: Cannot contain method implementations (except for default implementations in C# 8.0 and later).
Members: Can only contain method signatures, properties, events, and indexers; no fields or constructors.
Access Modifiers: Members are implicitly public and cannot have access modifiers.
Multiple Inheritance: A class or struct can implement multiple interfaces.

Use Cases: 

When you want to define a contract that can be implemented by any class or struct, regardless of its position in the class hierarchy.
When you want to achieve polymorphism.
When you want to decouple the definition of behavior from the implementation.



 */


// todo: Inteface and abstract class 

Tv tv = new Tv();
tv.TurnOn();
tv.TurnOff();

Phone ph = new Phone();
ph.TurnOn();
ph.TurnOff();

IDevice tv1 = new TVService();
tv1.TurnOn();
tv1.TurnOff();

IRestartable rst1 = new TVService();
rst1.Restart();

IDevice ph1 = new PhoneService();
ph1.TurnOn();
ph1.TurnOff();

IRestartable rst2 = new PhoneService();
rst2.Restart();

IDevice lm1 = new LampService();
lm1.TurnOn();
lm1.TurnOff();

// Implicit Implementation (ضمنى) or default vs Explicit Implementation (صريح) or force

// Explicit Implementation: used if more than interface have same method signature we neet to know
// which one to be executed

IDevice div1 = new TVService();
div1.Restart();

IRestartable div2 = new TVService();
div2.Restart();

TVService div3 = new TVService();
div3.Restart();

IDevice div4 = new PhoneService();
div4.Restart();

IRestartable div5 = new PhoneService();
div5.Restart();

PhoneService div6 = new PhoneService();
// div6.Restart(); PhoneService Doesn't Contain Restart and It's Restart Related to IDevice

#endregion


#region 37. Array List

ArrayList list = new ArrayList();
list.Add(1);
list.Add(true);
list.Add("Siro");
list.Add(1.5);
list.Add(false);
list.Remove(false);
list.Remove(1);
list.Insert(3,"Hossam");
list.InsertRange(3, new string[] { "Hossam", "Emara"});
list.AddRange(new int[] { 5, 6, 7 });
foreach (var item in list)
{
    Console.WriteLine(item);
}

Console.WriteLine(list.IndexOf(false));

// Boxing ==> store value type in reference type
// UnBoxing ==> store  reference type in  value type

int u1 = 10;
object u2 = u1; // Boxing u1
int u3 = u1 + (int)u2; // unboxing u2

#endregion


#region 38. Generic List and Dictionary

// Generic List

// Dictionary



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


#region OOP

/* OOP Pillars 
 
1. Encapsulation
2. Inheritance
3. Pplymerphism
4. Abstraction
 
 */

#region 1. Encapsulation

var employee = new CompanyEmployee();
// employee.FirstName = "Hossam"; can't be set direct
// No Last Name Provided !!!!!
employee.SetFullName("Hossam", "Emara");

//employee.BirthDate = new DateOnly(1900, 1, 1);  // Accept Invalid Date
//employee.BasicSalary = -5000; // Accept Minus Salary
employee.SetBasicSalary(6000);
employee.SetBirthDate(new DateOnly(1900, 1, 1));
// by using Encapsulation we can protect properties from not logic values

// Encapsulation depend on access modifiers
// Encapsulation protect the object from invalid state using filter or validation



#endregion

#region 2. Inheritance

// Classes should be related to each other , then we can use inheritance
// Inheritance increase system complexty and make tight coupling

#endregion



#endregion


