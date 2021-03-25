using System;

class A {
    private int intA; private int intB;
    public void setFields(int intA, int intB) {
        this.intA = intA;
        this.intB = intB;
    }
    public void print() {
        Console.WriteLine($"intA: {intA}, intB: {intB}");
        int Max = intA > intB ? intA : intB;
        Console.WriteLine($"max = {Max}");
    }
}
class MyProgram {
    public static void Main() {
        A obj1 = new A();
        obj1.setFields(7, 5);
        obj1.print();
    }
}