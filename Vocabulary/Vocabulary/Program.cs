
// See https://aka.ms/new-console-template for more information
// #error version




// Maybe someday you can come back to this section of code and understand it all, smile
using System.Reflection;

System.Data.DataSet ds;
HttpClient client;


Assembly? myApp = Assembly.GetEntryAssembly();

if (myApp == null) return;

foreach (AssemblyName name in
myApp.GetReferencedAssemblies()) {

    Assembly a = Assembly.Load(name);

    int methodCount = 0;

    foreach (TypeInfo t in a.DefinedTypes) {

        methodCount += t.GetMethods().Count();
    }

    Console.WriteLine(
    "{0:N0} types with {1:N0} methods in {2} assembly.",
    arg0: a.DefinedTypes.Count(),
    arg1: methodCount,
    arg2: name.Name);

}





// nameOf gives the name of the variable instead of giving the value stored inside it
double heightInMeters = 1.88;
Console.WriteLine($"The variable {nameof(heightInMeters)} has the value {heightInMeters}");


// some cool string class stuff




string horizontalLine = new('-', count: 74);
string grinningEmoji = char.ConvertFromUtf32(0x1F600);


/*
 
 To output emoji at the command line on Windows, you must use Windows Terminal because Command Prompt does not support emoji, and set the output encoding to use UTF-8

 */

Console.OutputEncoding = System.Text.Encoding.UTF8; 
Console.WriteLine(horizontalLine);
Console.WriteLine(grinningEmoji);





/*
 * Raw string literals use triple quotes so you can store strings without the need to use escape characters (in the below example I can't print text with quotes in it without the \" escape character)
 */


string rawStringLiteral = """ "My favorite drink is lemonade" """;
Console.WriteLine(rawStringLiteral);



/*
 * Raw interpolated string literals can be used in the same way, but also allow you to reference data from existing objects and place them into the string i.e.
 * 
 * 
 * var person = new { FirstName = "Alice", Age = 56 };
   string json = $$"""
              {
                "first_name": "{{person.FirstName}}",
                "age": {{person.Age}},
                "calculation", "{{{ 1 + 2 }}}"
              }
                  """;
Console.WriteLine(json);
 */










/*

    Notes:

System is a namespace, which is like an address for a type. To refer
to someone’s location exactly, you might use
Oxford.HighStreet.BobSmith, which tells us to look for a person named
Bob Smith on the High Street in the city of Oxford.

System.Console.WriteLine tells the compiler to look for a method named
WriteLine in a type named Console in a namespace named System. 

This is called importing the namespace. This is important because
entering that namespace will allow all available types within that
namespace to become available to you without having to write out the
full "address" for the types you want to use. 
 

Good practice is to import namespaces that you need. You *could* for
example put the "using System.Reflection" in the global usings file, but
it's better to hard-code the using statement if it's only in a single file.


Data usually comes into our program from files, databases, or user input, and it can be put temporarily into variables that will be stored in the memory of the running program. When the program ends, the data in memory is lost. Data is usually output to files and databases, or to the screen or a printer. When using variables, you should think about, firstly, how much space the variable takes in the memory, and, secondly, how fast it can be processed.


Use the @ symbol at the beginning of a filepath if it includes characters used for an escape sequence (such as C:\televisions\sony, the \t is a tab character).




*/