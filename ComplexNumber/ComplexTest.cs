﻿using System;

public class ComPlexTest
{
  public static void Test()
  {
    // create and initialize a Complex object
    Complex c1 = new Complex(1, 1), c2 = new Complex(1, -1), c3 = new Complex(0, 0);
    c1.sub(c2).print().printPolar();
    Console.WriteLine("(1+j) * (1-j)");
    c1.div(c2).print().printPolar();
    Console.WriteLine("(1+j) / (0-0)");
    c1.div(c3).print().printPolar();
    Console.ReadKey();
  }
}
