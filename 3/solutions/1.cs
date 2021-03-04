using System;
class HelloWorld {
  static void Main() {
    int n = 8;
    int[] oneDimArray = new int[n];
    for(int i=0; i<n; i++) {
        Console.Write($"oneDimArray[{i}]=");
        oneDimArray[i] = Int32.Parse(Console.ReadLine());
    }
    for(int i=0; i<n; i++) {
        Console.Write($"[{i}]={oneDimArray[i]}\t");
    }
  }
}