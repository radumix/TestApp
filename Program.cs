// See https://aka.ms/new-console-template for more information
using TestApp;

DisplayClass displayClass = new DisplayClass();


Console.WriteLine("Display palindrome.");

string display = Console.ReadLine();
Console.WriteLine(displayClass.messages(display));

display = Console.ReadLine();
Console.WriteLine(displayClass.messages(display));

display = Console.ReadLine();
Console.WriteLine(displayClass.messages(display));

Console.WriteLine("Enter to quit");
Console.ReadLine();

