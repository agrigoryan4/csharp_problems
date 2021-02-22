using System;
class HelloWorld {
  static void Main() {
      int start = 0, end = 10;
      for(int i = start; i <= end; i++) {
        Console.WriteLine("n={0}, n^2={1}, n^3={2}", i, i*i, i*i*i);
      }
  }
}
