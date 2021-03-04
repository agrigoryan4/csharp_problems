/*
insertion sort
*/
using System;
class InsertionSort {
    public static int[] sortAscending (int[] arr) {
        // create a copy of the array
        int[] arrCopy = new int[arr.Length];
        for(int i = 0; i < arr.Length; i++) {
            arrCopy[i] = arr[i];
        }
        
        // implement the algorithm
        for(int i = 0; i < arrCopy.Length - 1; i++) {
            if(arrCopy[i+1] < arrCopy[i]) {
                int temp = arrCopy[i+1];
                arrCopy[i+1] = arrCopy[i];
                arrCopy[i] = temp;
            }
            
            for(int j = i; j > 0 && arrCopy[j] < arrCopy[j-1]; j--) {
                int temp = arrCopy[j];
                arrCopy[j] = arrCopy[j-1];
                arrCopy[j-1] = temp;
            }
        }
        
        return arrCopy;
    }
}
class HelloWorld {
  static void Main() {
    // gets an array from the console
    int n = 10;
    int[] arr = new int[n];
    for(int i = 0; i < n; i++) {
        Console.Write($"arr[{i}]=");
        arr[i] = Int32.Parse(Console.ReadLine());
    }
    
    // creates a new sorted array from the original one
    int[] arrSorted = InsertionSort.sortAscending(arr);
    
    // displays it
    for(int i = 0; i < arrSorted.Length; i++) {
        Console.Write($"{arrSorted[i]}\t");
    }
  }
}