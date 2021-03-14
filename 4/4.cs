using System;


class MyProgram {
  static void Main() {
    string[] arr = new string[] {
        "Rainbow",
        "Red hat",
        "Car",
        "Longest distance",
        "Program"
    };
    
    // printing the initial array
    foreach(string element in arr) {
        Console.Write($"[{element}]");
    }
    Console.WriteLine();
    
    
    // getting a new array
    string[] newArr = new string[5];
    for(int i = 0; i < 5; i++) newArr[i] = $"{arr[i].Length}";
    
    // printing the new array
    foreach(string element in newArr) {
        Console.Write($"[{element}]");
    }
    
  }
}