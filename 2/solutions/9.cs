using System;
class HelloWorld {
  static void Main() {
      Console.WriteLine("Enter the coefficients of a quadratic equation:");
      Console.Write("a:\t"); double a = Double.Parse(Console.ReadLine());
      Console.Write("b:\t"); double b = Double.Parse(Console.ReadLine());
      Console.Write("c:\t"); double c = Double.Parse(Console.ReadLine());
      
      double D = (b*b) - (4*a*c);
      if(D < 0) Console.WriteLine("No real solution");
      else if(D == 0) {
          double x = -b / 2*a;
          Console.WriteLine("x = " + x);
      }
      else if(D > 0) {
        double x1 = (-b - Math.Sqrt(D)) / 2*a;
        double x2 = (-b + Math.Sqrt(D)) / 2*a;;
        Console.WriteLine("x1 = {0}, x2 = {1}", x1, x2);
      }
  }
}
