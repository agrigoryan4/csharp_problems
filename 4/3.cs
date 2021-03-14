using System;

class InsertionSort {
    public static string[] sortAscending (string[] arr) {
        // creating a copy of the array
        string[] arrCopy = new string[arr.Length];
        for(int i = 0; i < arr.Length; i++) {
            arrCopy[i] = arr[i];
        }
        
        // implementing the algorithm
        for(int i = 0; i < arrCopy.Length - 1; i++) {
            if(arrCopy[i+1].Length < arrCopy[i].Length) {
                string temp = arrCopy[i+1];
                arrCopy[i+1] = arrCopy[i];
                arrCopy[i] = temp;
            }
            
            for(int j = i; j > 0 && arrCopy[j].Length < arrCopy[j-1].Length; j--) {
                string temp = arrCopy[j];
                arrCopy[j] = arrCopy[j-1];
                arrCopy[j-1] = temp;
            }
        }
        
        return arrCopy;
    }
}

class MyProgram {
  static void Main() {
    string[] arr = new string[] {
        "Rainbow",
        "Red hat",
        "Car",
        "Longest distance",
        "Program"
    };
    
    foreach(string element in arr) {
        Console.Write($"[{element}]");
    }
    Console.WriteLine();
    
    string[] arrSorted = InsertionSort.sortAscending(arr);
    
    foreach(string element in arrSorted) {
        Console.Write($"[{element}]");
    }
    
  }
}