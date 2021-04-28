using System;

class Program {
  static void Main() {
    Console.Write("Enter some text: ");
    string text = Console.ReadLine();
    Console.WriteLine($"String: \"{text}\", contains {text.Length} symbols");
  }
}