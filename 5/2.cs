using System;

class MyClass {
    private int intA; private int intB; 
    private float f1; private float f2; 
    private string name;
    public void setFields(string name, int intA, int intB, float f1, float f2) {
        this.name = name;
        this.intA = intA;
        this.intB = intB;
        this.f1 = f1;
        this.f2 = f2;
    }
    public double getIntAvg() {
        Console.WriteLine("getIntAvg() - object " + name);
        return (intA + intB)/2.0;
    }
    public float getFloatMax() {
        Console.WriteLine("getFloatMax() - object " + name);
        return f1 > f2 ? f1 : f2;
    }
    
}
class MyProgram {
    public static void Main() {
        MyClass obj1 = new MyClass();
        Console.WriteLine("input object name: ");
        string name = Console.ReadLine();
        Console.WriteLine("input two integers: ");
        int intA = Int32.Parse(Console.ReadLine());
        int intB = Int32.Parse(Console.ReadLine());
        Console.WriteLine("input two floating point numbers: ");
        float f1 = Single.Parse(Console.ReadLine());
        float f2 = Single.Parse(Console.ReadLine());
        
        
        obj1.setFields(name, intA, intB, f1, f2);
        Console.WriteLine(obj1.getIntAvg());
        Console.WriteLine(obj1.getFloatMax());
    }
}