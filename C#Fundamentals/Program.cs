// See https://aka.ms/new-console-template for more information

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

#endregion

#endregion


#region Data Types 

/*
 1. string ==> 16 bit per character	Stores a sequence of characters, surrounded by double quotes
 2. boolean ==> 1 bit	   true & false
 3. int  ==> 32 bit	   Stores whole numbers from -2,147,483,648 to 2,147,483,647
 4. long ==> 64 bit	   Stores whole numbers from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
 5. float ==> 32 bit	   Stores fractional numbers. Sufficient for storing 6 to 7 decimal digits
 6. double ==> 64 bit	   Stores fractional numbers. Sufficient for storing 15 decimal digits
 7. char	==> 16 bit	   Stores a single character/letter, surrounded by single quotes
 8. byte ==> Unsigned 8-bit integer	   Stores 0 to 255	
 9. uint ==> Unsigned 32-bit integer	0 to 4,294,967,295	
 

 /* See https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/value-types
   
   For C# Data Types 
 
 */

/* Q1. What's Difference Between Value Typed and Reference Types ? 

 

        
 */
double x = 10.5;
    float y = 10.5f;

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
int ascii = Console.Read(); // return ascii code of first inserted character
Console.WriteLine($"return ascii code of first inserted character :: {ascii}");

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


// see  https://www.w3resource.com/csharp-exercises/ C# Sharp Programming Exercises, Practice, Solution






