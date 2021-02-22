using System;
class HelloWorld {
  static void Main() {
    Console.Write("Input a number:\t");
    int input = Int32.Parse(Console.ReadLine());
    
    Console.WriteLine("Number:\t{0}", input);
    Console.Write("Number reversed:\t");
    int wholePart = input;
    while(wholePart >= 1) {
        int remainder = wholePart % 10;
        wholePart /= 10;
        Console.Write(remainder);
    }
  }
}
