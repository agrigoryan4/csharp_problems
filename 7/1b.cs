using System;

class A {
    public int fA;
    public int fB;
    public int fC;
    public A(int fA, int fB, int fC) {
        this.fA = fA;
        this.fB = fB;
        this.fC = fC;
    }
    public virtual void printFields() {
        Console.WriteLine($"A: {fA}, B: {fB}, C: {fC}");
    }
}

class B : A {
    public int fD;
    public int fE;
    public B(int fA, int fB, int fC, int fD, int fE) : base(fA, fB, fC) {
        this.fD = fD;
        this.fE = fE;
    }
    public override void printFields() {
        Console.WriteLine($"A: {fA}, B: {fB}, C: {fC}, D: {fD}, E: {fE}");
    }
}

class HelloWorld {
  static void Main() {
    A objA = new A(1, 4, 5);
    B objB = new B(7, 4, 3, 1, 7);
    objA.printFields();
    objB.printFields();
  }
}