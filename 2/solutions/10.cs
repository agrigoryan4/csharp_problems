using System;
class HelloWorld {
  static void Main() {
      Console.WriteLine("Enter 3 strings: ");
      string Togh1 = Console.ReadLine();
      string Togh2 = Console.ReadLine();
      string Togh3 = Console.ReadLine();
      
      string max = Togh3;
      if(Togh1.Length > Togh2.Length && Togh1.Length > Togh3.Length) {
          max = Togh1;
      } else if (Togh2.Length > Togh3.Length) {
          max = Togh2;
      }
      Console.WriteLine("The longest input: " + max);
      
  }
}
