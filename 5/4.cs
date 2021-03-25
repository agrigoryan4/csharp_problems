using System;

class Xoranard {
    double side;
    public void setSide(double side) {
        this.side = side;
    }
    public double getVolume() {
        return Math.Pow(side, 3.0);
    }
    public double getSurfaceArea() {
        return 6*(side * side);
    }
}
class MyProgram {
    public static void Main() {
        Xoranard cube1 = new Xoranard();
        cube1.setSide(7.0);
        Console.WriteLine($"Volume: {cube1.getVolume()}");
        Console.WriteLine($"Surface Area: {cube1.getSurfaceArea()}");
    }
}