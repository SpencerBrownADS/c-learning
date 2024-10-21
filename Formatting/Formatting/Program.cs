// See https://aka.ms/new-console-template for more information

using System.Runtime.CompilerServices;
//using static System.Console;
//this works because we imported System.Console and don't have to write Console. before any WriteLine in this file if the code is uncommented

//You can also import System.Console in the .csproj file and add it using an <ItemGroup> tag

int numberOfApples = 12;
decimal pricePerApple = 0.35M;

Console.WriteLine( 
    format: "{0} apples cost {1:C}",
    arg0: numberOfApples,
    arg1: pricePerApple * numberOfApples);

string formatted = string.Format(
    format: "{0} apples cost {1:C}",
    arg0: numberOfApples,
    arg1: pricePerApple * numberOfApples);



Console.WriteLine($"{numberOfApples} apples cost {pricePerApple * numberOfApples:C}");

Console.WriteLine("Type your first name and press ENTER:");
string ? firstName = Console.ReadLine(); // question marks tell the compiler not to worry about null values
Console.WriteLine("Type your age and  press ENTER:");
string  age = Console.ReadLine()!; // exclaimation mark is a null-forgiving operator
Console.WriteLine($"Hello {firstName}, you look good for {age}");


Write("Press any key combination: "); //write doesn't print a new line like writeline does
ConsoleKeyInfo key = ReadKey();
WriteLine();
WriteLine("Key: {0}, Char: {1}, Modifiers: {2}",
    arg0: key.Key,
    arg1: key.KeyChar,
    arg2: key.Modifiers);

