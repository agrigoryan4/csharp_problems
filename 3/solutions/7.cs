using System;
class HelloWorld {
  static void Main() {
    int n = 10;
    int[] oneDimArray = new int[n];
    for(int i=0; i<n; i++) {
        Console.Write($"oneDimArray[{i}]=");
        oneDimArray[i] = Int32.Parse(Console.ReadLine());
    }
    
    int max = oneDimArray[0];
    int min = oneDimArray[0];
    for(int i=0; i<oneDimArray.Length; i++) {
        if(oneDimArray[i] > max) {
            max = oneDimArray[i];
        }
        else if(oneDimArray[i] < min) {
            min = oneDimArray[i];
        }
    }
    
    Console.WriteLine($"\nthe difference between the biggest element and the smallest is {max - min}");
  }
}