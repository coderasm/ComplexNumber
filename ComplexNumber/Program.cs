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
      Console.ReadKey();
    }
  }
}
