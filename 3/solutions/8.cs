using System;
class HelloWorld {
  static void Main() {
    int n = 10;
    int[] oneDimArray = new int[n];
    for(int i=0; i<n; i++) {
        Console.Write($"oneDimArray[{i}]=");
        oneDimArray[i] = Int32.Parse(Console.ReadLine());
    }
    
    int amount = 0;
    int sum = 0;
    int product = 1;
    for(int i=0; i<oneDimArray.Length; i++) {
        if(oneDimArray[i] % 5 == 0) {
            amount++;
            sum += oneDimArray[i];
            product *= oneDimArray[i];
        }
    }
    
    Console.WriteLine($"there are {amount} multiples of 5 in the array");
    Console.WriteLine($"their sum is {sum} and their product is {product}");
  }
}