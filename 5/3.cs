using System;

class MyClass {
    private int intA; private int intB; private int intC;
    private bool areEqual;
    public void setValues(int intA, int intB, int intC) {
        this.intA = intA; this.intB = intB; this.intC = intC;
    }
    public bool areAny2Equal() {
        if(intA == intB || intA == intC || intB == intC) areEqual = true;
        else areEqual = false;
        return areEqual;
    }
}
class MyProgram {
    public static void Main() {
        MyClass someObj = new MyClass();
        someObj.setValues(5, 6, 6);
        Console.WriteLine(someObj.areAny2Equal());
    }
}