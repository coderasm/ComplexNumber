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
      //ComplexTest.TestAddSubMulDiv();
      //ComplexTest.TestSquareRootI();
      Console.WriteLine("########## Part 4 ##########");
      //For (1 - i)^500
      var value = Math.Pow(2, 250) * Math.Pow(-1, -125);
      Console.WriteLine("(1 - i)^500) = " + string.Format("{0:#.#######E+0}", value));
      //For (-1/2 + sqrt(3)i/2)^300 = (1*e^(2*pi/3))^300
      value = Math.Pow(-1, 200);
      Console.WriteLine("(-1/2 + sqrt(3)i/2)^300 = (1*e^(2*pi/3))^300 = (e^((i*pi)*200) = " + value);
      Console.ReadKey();
    }
  }
}
