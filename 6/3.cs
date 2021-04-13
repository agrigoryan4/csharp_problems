using System;
class myClass {
    private float a;
    private float b;
    private float c;
    public void setFields() {
        this.a = 10.0f;
        this.b = 10.0f;
        this.c = 10.0f;
    }
    public void setFields(float a, float b) {
        this.a = a;
        this.b = b;
        this.c = 10.0f;
    }
    public void setFields(float a, float b, float c) {
        this.a = a;
        this.b = b;
        this.c = c;
    }
    public float myMethod() {
        return (float) Math.Sqrt((a + b + c));
    }
}
class HelloWorld {
  static void Main() {
    // objects
    myClass obj1 = new myClass();
    obj1.setFields();
    myClass obj2 = new myClass();
    obj2.setFields(7.1f, 4.3f);
    myClass obj3 = new myClass();
    obj3.setFields(26.1f, 7.6f, 14.5f);
    // squares of sums
    float sumSquared1 = obj1.myMethod();
    float sumSquared2 = obj2.myMethod();
    float sumSquared3 = obj3.myMethod();
    // object with the biggest square of its members' sum
    string biggestObj = (sumSquared3 > sumSquared2 && sumSquared3 > sumSquared1) ? "obj3" : (sumSquared2 > sumSquared1 ? "obj2" : "obj1");
    // print
    Console.WriteLine($"obj1: square of its members sum - {sumSquared1}");
    Console.WriteLine($"obj2: square of its members sum - {sumSquared2}");
    Console.WriteLine($"obj3: square of its members sum - {sumSquared3}");
    Console.WriteLine($"object with the biggest square of its members' sum is {biggestObj}");
  }
}