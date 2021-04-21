using System;
class A {
    protected int fA;
    protected int fB;
    protected int fC;
    public A(int fA, int fB, int fC) {
        this.fA = fA;
        this.fB = fB;
        this.fC = fC;
    }
    public virtual void printFields() {
        Console.WriteLine($"fA: {fA}, fB: {fB}, fC: {fC}");
    }
}

class B : A {
    protected int fD;
    public B(int fA, int fB, int fC, int fD) : base(fA, fB, fC) {
        this.fD= fD;
    }
    public B(C instC) : base(instC.fA, instC.fB, instC.fC) {
        this.fD = instC.fD;
    }
    public override void printFields() {
        Console.WriteLine($"fA: {fA}, fB: {fB}, fC: {fC}");
        Console.WriteLine($"fD: {fD}");
    }
}

class C : B {
    protected int fE;
    protected string fF;
    public C(int fA, int fB, int fC, int fD, int fE, string fF) : base(fA, fB, fC, fD) {
        this.fE = fE;
        this.fF = fF;
    }
    public override void printFields() {
        Console.WriteLine($"fA: {fA}, fB: {fB}, fC: {fC}");
        Console.WriteLine($"fD: {fD}");
        Console.WriteLine($"fE: {fE}, fF: {fF}");
    }
}

class MyProgram {
  static void Main() {
    A obj1 = new A(4, 3, 23);
    C obj3 = new C(7, 3, 1, 8, 9, "LOREM IPSUM");
    B obj2 = new B(obj3);
    
    Console.WriteLine("obj1: ");
    obj1.printFields();
    Console.WriteLine("obj3: ");
    obj3.printFields();
    Console.WriteLine("obj2: ");
    obj2.printFields();
  }
}