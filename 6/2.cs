using System;
class myClass {
    private float a;
    private float b;
    private float c;
    public myClass() {
        this.a = 10.0f;
        this.b = 10.0f;
        this.c = 10.0f;
    }
    public myClass(float a, float b) {
        this.a = a;
        this.b = b;
        this.c = 10.0f;
    }
    public myClass(float a, float b, float c) {
        this.a = a;
        this.b = b;
        this.c = c;
    }
    public float getArithmeticMean() {
        return (a + b + c) / 2.0f;
    }
}
class HelloWorld {
  static void Main() {
    // objects
    myClass obj1 = new myClass();
    myClass obj2 = new myClass(7.1f, 4.3f);
    myClass obj3 = new myClass(1.5f, 3.2f);
    // arithmetic means
    float mean1 = obj1.getArithmeticMean();
    float mean2 = obj2.getArithmeticMean();
    float mean3 = obj3.getArithmeticMean();
    // object with the biggest arithmetic mean
    string biggestObj = (mean3 > mean2 && mean3 > mean1) ? "obj3" : (mean2 > mean1 ? "obj2" : "obj1");
    // print
    Console.WriteLine($"obj1: arithmetic mean - {mean1}");
    Console.WriteLine($"obj2: arithmetic mean - {mean2}");
    Console.WriteLine($"obj3: arithmetic mean - {mean3}");
    Console.WriteLine($"object with the biggest arithmetic mean is {biggestObj}");
  }
}