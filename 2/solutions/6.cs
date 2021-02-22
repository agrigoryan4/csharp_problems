using System;
class HelloWorld {
  static void Main() {
    
    int num = 0;
    int sum = 0;
    int product = 1;
    
    Console.Write("Odd multiples of 5 in (5, 55):\t");
    for(int i = 5; i <= 55; i++) {
        if((i % 5 == 0) && (i % 2 == 1)) {
         Console.Write(i + "\t");
         num++;
         sum += i;
         product *= i;
        }
    }
    Console.WriteLine("\nTheir number is {0}, sum is {1} and product is {2}", num, sum, product);
  }
}
