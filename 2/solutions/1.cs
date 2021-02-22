using System;
class HelloWorld {
  static void Main() {
    int number = 8;
    Console.WriteLine("Initial number: " + number);
    number = number << 2;
    Console.WriteLine("Shifted left by 2: " + number);
    number = number >> 3;
    Console.WriteLine("Shifted right by 3: " + number);
  }
}
