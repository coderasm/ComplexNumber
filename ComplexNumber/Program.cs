using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Creates complex numbers. Performs addition, subtraction, multiplication
 and division on the complex numbers. Displays the complex number in
 polar coordinate format. All computations are guarded against
 division by zero and undefined Complex numbers.
   */

namespace ComplexNumber
{
  class Program
  {
    static void Main(string[] args)
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
      Console.ReadKey();
    }
  }
}
