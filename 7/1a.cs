using System;

public class A {
    public int fA = 1;
    public int fB = 2;
    public int fC = 3;
    public virtual void printFields() {
        Console.WriteLine($"A: {fA}, B: {fB}, C: {fC}");
    }
}

public class B : A {
    public int fD = 4;
    public int fE = 5;
    public override void printFields() {
        Console.WriteLine($"A: {fA}, B: {fB}, C: {fC}, D: {fD}, E: {fE}");
    }
}

class HelloWorld {
  static void Main() {
    A objA = new A();
    B objB = new B();
    objA.printFields();
    objB.printFields();
  }
}