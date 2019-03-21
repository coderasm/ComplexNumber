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
      ComplexTest.TestSquareRootI();
      Console.WriteLine("########## Part 4 ##########");
      //For (1 - i)^500
      var value = Math.Pow(2, 250) * Math.Pow(-1, -125);
      var complexOne = new Complex(1, -1);
      Console.Write("Calculated: ");
      complexOne.toPow(500).print();
      Console.WriteLine("(1 - i)^500) = " + string.Format("{0:#.#######E+0}", value));
      //For (-1/2 + sqrt(3)i/2)^300 = (1*e^(2*pi/3))^300
      value = Math.Pow(-1, 200);
      var complexTwo = new Complex(-.5, Math.Sqrt(3)/2);
      Console.Write("Calculated: ");
      complexTwo.toPow(300).print();
      Console.WriteLine("(-1/2 + sqrt(3)i/2)^300 = (1*e^(2*pi/3))^300 = (e^((i*pi)*200) = " + value);
      //For i^1003 = e^((i*pi/2)*1003) = i^1002 * i = -i
      var complexThree = new Complex(0, 1);
      Console.Write("Calculated: ");
      complexThree.toPow(1003).print();
      Console.WriteLine("i^1003 = e^((i*pi/2)*1003) = i^1002 * i = -i");
      Console.ReadKey();
    }
  }
}
