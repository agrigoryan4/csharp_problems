using System;

class MyClass {
    protected int A;
    protected int B;
    protected int C;
    public void setFields(int A, int B, int C) {
        this.A = A;
        this.B = B;
        this.C = C;
    }
    public virtual void printArithmeticMean() {
        double mean = (double) (A+B+C) / 3;
        Console.WriteLine($"Arithmetic mean from MyClass: {mean}");
    }
}

class YourClass : MyClass {
    private string name;
    public void setFields(int A, int B, int C, string name) {
        base.setFields(A, B, C);
        this.name = name;
    }
    public override void printArithmeticMean() {
        double mean = (double) (A+B+C) / 3;
        Console.WriteLine($"Arithmetic mean from YourClass: {mean}");
    }
}

class TheirClass : MyClass {
    private string name;
    private string surname;
    public void setFields(int A, int B, int C, string name, string surname) {
        base.setFields(A, B, C);
        this.name = name;
        this.surname = surname;
    }
    public override void printArithmeticMean() {
        double mean = (double) (A+B+C) / 3;
        Console.WriteLine($"Arithmetic mean from TheirClass: {mean}");
    }
}

class HelloWorld {
  static void Main() {
    MyClass obj1 = new MyClass();
    obj1.setFields(4, 5, 1);
    YourClass obj2 = new YourClass();
    obj2.setFields(3, 5, 54, "John");
    TheirClass obj3 = new TheirClass();
    obj3.setFields(6, 7, 6, "John", "Doe");

    obj1.printArithmeticMean();
    obj2.printArithmeticMean();
    obj3.printArithmeticMean();
  }
}