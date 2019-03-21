using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumber
{
  class ComplexTest
  {
    public static void TestAddSubMulDiv()
    {
      Complex c1 = new Complex(1, 1), c2 = new Complex(1, -1), c3 = new Complex(0, 0);
      Console.WriteLine("Complex 1+j");
      c1.print();
      Console.WriteLine("Complex 1-j");
      c2.print();
      Console.WriteLine("(1+j) + (1-j)");
      c1.add(c2).print().printPolar();
      Console.WriteLine("(1+j) - (1-j)");
      c1.sub(c2).print().printPolar();
      Console.WriteLine("(1+j) * (1-j)");
      c1.mul(c2).print().printPolar();
      Console.WriteLine("(1+j) / (1-j)");
      c1.div(c2).print().printPolar();
      Console.WriteLine("(1+j) / (0-0)");
      c1.div(c3).print().printPolar();
    }

    public static void TestSquareRootI()
    {
      Console.WriteLine("######## PART 3 (roots of i) ##########");
      var roots = Complex.SquareRootsOfi();
      Console.Write("Root One: ");
      roots[0].print();
      Console.Write("Square Root One: ");
      roots[0].mul(roots[0]).print();
      Console.Write("Root Two: ");
      roots[1].print();
      Console.Write("Square Root Two: ");
      roots[1].mul(roots[1]).print();
    }
  }
}
