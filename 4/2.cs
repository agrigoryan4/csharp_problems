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
    
    string max = arr[0];
    foreach(string element in arr) {
        Console.Write($"[{element}]");
        if(element.Length > max.Length) max = element;
    }
    
    Console.WriteLine($"\nThe longest string is <{max}>");
  }
}