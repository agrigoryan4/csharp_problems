using System;

class Program {
  static void Main() {
    Console.Write("string1 = ");
    string string1 = Console.ReadLine(); 
    Console.Write("string2 = ");
    string string2 = Console.ReadLine();
    
    string largerString = string1.Length > string2.Length ? string1 : string2;
    Console.WriteLine($"The larger string is \"{largerString}\"");
  }
}