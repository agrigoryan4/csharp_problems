using System;
class MyProgram {
  static void Main() {
    int arrayLength = 3;
    string[] arr = new string[arrayLength];
    for(int i = 0; i < arrayLength; i++) {
        arr[i] = Console.ReadLine();
    }
    
    string max = arr[0];
    foreach(string element in arr) {
        if(element.Length > max.Length) max = element;
    }
    
    Console.WriteLine($"The longest string is {max}");
  }
}