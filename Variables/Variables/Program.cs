// See https://aka.ms/new-console-template for more information

using System.Xml;

/***
 * There are flexible types called object and dynamic that can change based on the value assigned, but they come at the cost of performance and also sometimes require explicit mention of their flexibility when using those assigned values
 * A limitation of the dynamic object type is that IntelliSense cannot help you write code as the compiler cannot check what the object type is during build time
 * // suffixes for number values

    //L: Compiler infers long
    //UL: Compiler infers ulong
    //M: Compiler infers decimal
    //D: Compiler infers double
    //F: Compiler infers float

 */

object height = 1.88;
object name = "Amir";

Console.WriteLine($"{name} is {height} metres tall.");

//int length1 = name.Length;
int length2 = ((string)name).Length; // you have to specify that name is a string when using the object type

Console.WriteLine($"{name} has {length2} characters.");


dynamic something = "Ahmed";

//something = 12;

//something = new[] {3, 5, 7};
Console.WriteLine($"Length is {something.Length}");




/***
 * A good practice is to use var when the data type is obvious. For example, the Xml instantiations below are fairly obvious as to what they are, but the "var file1" is a bit ambiguous as to what it could be, so the StreamWriter example is better.
 */


var population = 67_000_000;
var weight = 1.88;
var price = 4.99M;
var fruit = "Apples";
var letter = 'Z';
var happy = true;

var xml1 = new XmlDocument();
XmlDocument xml2 = new XmlDocument();


var file1 = File.CreateText("something1.txt");
StreamWriter file2 = File.CreateText("something2.txt");


//shorthand object instatiation starting from C#9
XmlDocument xml3 = new();

//if the object has fields, then you can instantiate it and fill them out later

/***
 * i.e. Person kim = new();
 * kim.BirthDate = new(1967, 12, 26);
 */


 // Most types are value types, which means they contain the value (int, bool, etc.), but string is a *reference* type, meaning it only contains the memory address of the value itself


Console.WriteLine($"default(int) = {default(int)}");
Console.WriteLine($"default(bool) = {default(bool)}");
Console.WriteLine($"default(DateTime) = {default(DateTime)}");
Console.WriteLine($"default(string) = {default(string)}");

int number = 13;
Console.WriteLine($"number has been set to: {number}");
number = default;
Console.WriteLine($"number has been reset to its default: {number}");







