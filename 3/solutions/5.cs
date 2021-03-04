using System;
class HelloWorld {
  static void Main() {
    int n = 10;
    int[] oneDimArray = new int[n];
    for(int i=0; i<n; i++) {
        Console.Write($"oneDimArray[{i}]=");
        oneDimArray[i] = Int32.Parse(Console.ReadLine());
    }
    Console.WriteLine("array before: ");
    for(int i=0; i<n; i++) {
        Console.Write($"{oneDimArray[i]}\t");
    }
    
    for(int i=0; i<n; i++) {
        if(oneDimArray[i] <  0) {
            oneDimArray[i] = 0;
        }
        else oneDimArray[i] *= 2;
    }
    
    Console.WriteLine("\narray after: ");
    for(int i=0; i<n; i++) {
        Console.Write($"{oneDimArray[i]}\t");
    }
  }
}