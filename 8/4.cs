using System;

class Program {
  static void Main() {
    int[] integers = new int[10];
    Console.WriteLine($"Enter {integers.Length} integers: ");
    for(int i = 0; i < integers.Length; i++) {
        Console.Write($"[{i}] = ");
        integers[i] = Int32.Parse(Console.ReadLine());
    }
    
    Console.WriteLine("The positive even numbers are: ");
    foreach(int integer in integers) {
        if((integer > 0) && (integer % 2 == 0)) Console.Write($"\t<{integer}>");
    }
  }
}