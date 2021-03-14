using System;


class MyProgram {
  static void Main() {
    int[,] arr = new int[5,3] {
        {4, 7, 8},
        {6, 1, 3},
        {9, 9, 5},
        {3, 7, 4},
        {11, 98, 12}
    };
    
    // printing the original array
    for(int i = 0; i < 5; i++) {
        for(int j = 0; j < 3; j++) {
            Console.Write($"{arr[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    
    // getting a new array
    
    int[] newArr = new int[5];
    
    for(int i = 0; i < 5; i++) {
        int max = arr[i, 0];
        for(int j = 0; j < 3; j++) {
            if(arr[i, j] > max) max = arr[i, j];
        }
        newArr[i] = max;
    }
    
    // printing the new array
    
    foreach(int element in newArr) Console.Write($"{element}\t");
    
  }
}