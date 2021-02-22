using System;
class HelloWorld {
  static void Main() {
		Console.Write("Input a number:\t");
    long input = Int64.Parse(Console.ReadLine());
    
    long num = input;
    int numOfDigits = 0;
    while(num >= 1) {
        num = num / 10;
        numOfDigits++;
    }
    Console.WriteLine("The number has {0} digits", numOfDigits);
  }
}
