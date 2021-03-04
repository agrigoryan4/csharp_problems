using System;
class HelloWorld {
  static void Main() {
    int n = 3;
    int m = 4;
    int[,] twoDimArray = new int[n, m];
    for(int i=0; i<n; i++) {
        for(int j=0; j<m; j++) {
            Console.Write($"twoDimArray[{i},{j}]=");
            twoDimArray[i,j] = Int32.Parse(Console.ReadLine());
        }
    }
    
    Console.WriteLine("the array: ");
    for(int i=0; i<n; i++) {
        for(int j=0; j<m; j++) {
            Console.Write($"[{i},{j}]={twoDimArray[i,j]}\t");
        }
        Console.Write("\n");
    }
    
    Console.WriteLine("the array transposed: ");
    int[,] transposed = new int[m, n];
    for(int i=0; i<n; i++) {
        for(int j=0; j<m; j++) {
            transposed[j, i] = twoDimArray[i,j];
        }
    }
    
    for(int i=0; i<m; i++) {
        for(int j=0; j<n; j++) {
            Console.Write($"[{i},{j}]={transposed[i,j]}\t");
        }
        Console.Write("\n");
    }
    
  }
}