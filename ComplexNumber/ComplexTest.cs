using System;

public class ComPlexTest
{
  public static void Test()
  {
    // create and initialize a Complex object
    Complex c1 = new Complex(1, 1), c2 = new Complex(1, -1), c3 = new Complex(0, 0);
    Console.WriteLine("Complex 1+j");
    c1.print();
    Console.WriteLine("Complex 1-j");
    c2.print();
    Console.WriteLine("(1+j) + (1-j)");
    c1.add(c2).print();
    Console.WriteLine("(1+j) - (1-j)");
    c1.sub(c2).print();
    Console.WriteLine("(1+j) * (1-j)");
    c1.mul(c2).print();
    Console.WriteLine("(1+j) / (1-j)");
    c1.div(c2).print();
    Console.WriteLine("(1+j) / (0-0)");
    var result = c1.div(c3);
    if (result == null)
      Console.WriteLine("Undefined");
    else
      result.print();
    Console.ReadKey();
  }
}
