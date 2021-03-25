using System;

class Erankyuni {
    private double side1; private double side2; private double side3;
    public void setSides(double a, double b, double c) {
        side1 = a; side2 = b; side3 = c;
    }
    public double getPerimeter() {
        double p = side1 + side2 + side3;
        return p;
    }
}
class MyProgram {
    public static void Main() {
        Erankyuni er1 = new Erankyuni(); er1.setSides(5.1, 6.4, 8.3);
        Erankyuni er2 = new Erankyuni(); er2.setSides(9.2, 11.3, 45.1);
        Erankyuni er3 = new Erankyuni(); er3.setSides(4.7, 4.3, 9.2);
        
        if(er1.getPerimeter() > er2.getPerimeter() && er1.getPerimeter() > er3.getPerimeter()) {
            Console.WriteLine($"Aravelaguyny er1-n e");
        } else {
            if(er2.getPerimeter() > er3.getPerimeter()) Console.WriteLine($"Aravelaguyny er2-n e");
            else Console.WriteLine($"Aravelaguyny er3-n e");
        }
    }
}