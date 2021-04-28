using System;

class Program {
  static void Main() {
    int[] integers = new int[10];
    Console.WriteLine($"Enter {integers.Length} integers: ");
    for(int i = 0; i < integers.Length; i++) {
        Console.Write($"[{i}] = ");
        integers[i] = Int32.Parse(Console.ReadLine());
    }
    
    int num = 0;
    int sum = 0;
    foreach(int integer in integers) {
        if(integer % 3 == 2) {
            num++;
            sum += integer;
        }
    }
    
    Console.WriteLine($"Number of eligible integers:\t{num}, their sum:\t{sum} ");
  }
}