using System;
class Arman {
    private float r;
    public Arman() {
        r = 1.0f;
    }
    public Arman(float r) {
        this.r = r;
    }
    public float getArea() {
        return (float) (r * Math.PI);
    }
    public float getCircumference() {
        return (float) (r * 2 * Math.PI);
    }
}
class HelloWorld {
  static void Main() {
    Arman obj1 = new Arman();
    Arman obj2 = new Arman(3.3f);
    Console.WriteLine($"Obj1 - area: {obj1.getArea()}, circumference: {obj1.getCircumference()}");
    Console.WriteLine($"Obj2 - area: {obj2.getArea()}, circumference: {obj2.getCircumference()}");
  }
}