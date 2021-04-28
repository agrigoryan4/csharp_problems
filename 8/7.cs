using System;

class A {
    string field1;
    string field2;
    public A() {
        initializeField1();
        initializeField2();
    }
    private void initializeField1() {
        field1 = "String1";
    }
    private void initializeField2() {
        field2 = "String2";
    }
    public void setFields(string a, string b) {
        field1 = a;
        field2 = b;
    }
    public void printFields() {
        Console.WriteLine($"field1: {field1}, field2: {field2}");
    }
}

class Program {
  static void Main() {
    A obj = new A();
    Console.Write("field1 = ");
    string field1 = Console.ReadLine(); 
    Console.Write("field1 = ");
    string field2 = Console.ReadLine();
    obj.setFields(field1, field2);
    obj.printFields();
  }
}