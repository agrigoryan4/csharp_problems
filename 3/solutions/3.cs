using System;
class HelloWorld {
  static void Main() {
    int n = 10;
    int[] oneDimArray = new int[n];
    for(int i=0; i<n; i++) {
        Console.Write($"oneDimArray[{i}]=");
        oneDimArray[i] = Int32.Parse(Console.ReadLine());
    }
    Console.WriteLine("array: ");
    for(int i=0; i<n; i++) {
        Console.Write($"{oneDimArray[i]}\t");
    }
    
    int posNumbersAmount = 0;
    for(int i=0; i<n; i++) {
        if(oneDimArray[i] > 0) {
            posNumbersAmount++;
        }
    }
    Console.WriteLine($"\n{posNumbersAmount} positive numbers in total");
  }
}