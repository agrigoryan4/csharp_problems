using System;
class HelloWorld {
  static void Main() {
    int n = 8;
    int[] oneDimArray = new int[n];
    for(int i=0; i<n; i++) {
        Console.Write($"oneDimArray[{i}]=");
        oneDimArray[i] = Int32.Parse(Console.ReadLine());
    }
    Console.WriteLine("array: ");
    for(int i=0; i<n; i++) {
        Console.Write($"{oneDimArray[i]}\t");
    }
    
    Console.WriteLine("\nnegative numbers it contains: ");
    for(int i=0; i<n; i++) {
        if(oneDimArray[i] < 0) {
            Console.Write($"{oneDimArray[i]}\t");
        }
    }
  }
}