using System;

class Program {
  static void Main() {
    int[,] integers = new int[4, 3] {
        {7, 8, 9},
        {4, 5, 6},
        {11, 7, 7},
        {3, 8, 44}
    };
    
    int[] sums = new int[integers.GetLength(0)];
    for(int i = 0; i < integers.GetLength(0); i++) {
        int iRowSum = 0;
        for(int j = 0; j < integers.GetLength(1); j++) {
            iRowSum += integers[i, j];
        }
        sums[i] = iRowSum;
    }
    
    Console.Write("[\t");
    foreach(int integer in sums) {
        Console.Write($" <{integer}> ");
    }
    Console.Write("\t]");
  }
}