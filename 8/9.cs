using System;

class Program {
  static void Main() {
    Console.Write("string1 = ");
    string string1 = Console.ReadLine(); 
    Console.Write("string2 = ");
    string string2 = Console.ReadLine();
    Console.Write("string3 = ");
    string string3 = Console.ReadLine();
    
    string smallest;
    if(string3.Length < string2.Length && string3.Length < string1.Length)
        smallest = string3;
    else if(string2.Length < string1.Length) 
        smallest = string2;
        else smallest = string1;
    Console.WriteLine($"The smallest string is \"{smallest}\"");
  }
}