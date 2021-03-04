using System;
class HelloWorld {
  static void Main() {
    int n = 3;
    int[,] twoDimArray = new int[n, n];
    for(int i=0; i<n; i++) {
        for(int j=0; j<n; j++) {
            Console.Write($"twoDimArray[{i},{j}]=");
            twoDimArray[i,j] = Int32.Parse(Console.ReadLine());
        }
    }
    
    int amount = 0;
    int sum = 0;
    for(int i=0; i<n; i++) {
        for(int j=0; j<n; j++) {
          if(twoDimArray[i, j] > 0) {
              amount++;
              sum += twoDimArray[i, j];
          }
        }
    }
    
    Console.WriteLine($"there are {amount} even numbers and their sum is {sum}");
  }
}