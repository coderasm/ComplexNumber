﻿using System; // namespace containing ArgumentOutOfRangeException

public class Complex
{
  private double rP = 0; // real part
  private double iP = 0; // imaginary part
  //tracks if the complex object is undefined
  private bool isUndefined = false;

  public Complex()
  {

  }

  //initializing constructor
  public Complex(double r, double i)
  {
    SetComplex(r, i);
  }

  //represents a null/undefined complex object.
  //allows a null/undefined complex object to
  //to behave as a defined/non-null complex object.
  public Complex(object nullObject)
  {
    //If we pass in null, mark the object as undefined
    if (nullObject == null)
      isUndefined = true;
  }

  public void SetComplex(double r, double i)
  {
    rP = r;
    iP = i;
  }

  public Complex add(Complex c1)
  {
    //check if this complex number or the other complex number is undefined
    //if either are undefined, then return an undefined complex number
    if (isUndefined || c1.isUndefined)
      return new Complex(null);
    var realPart = rP + c1.rP;
    var imaginaryPart = iP + c1.iP;
    //return a new complex number to prevent mutation of other two complex numbers
    return new Complex(realPart, imaginaryPart);
  }

  public static Complex addTwo(Complex c1, Complex c2)
  {
    //check if this complex number or the other complex number is undefined
    //if either are undefined, then return an undefined complex number
    if (c1.isUndefined || c2.isUndefined)
      return new Complex(null);
    var realPart = c1.rP + c2.rP;
    var imaginaryPart = c1.iP + c2.iP;
    //return a new complex number to prevent mutation of other two complex numbers
    return new Complex(realPart, imaginaryPart);
  }

  public Complex sub(Complex c1)
  {
    //check if this complex number or the other complex number is undefined
    //if either are undefined, then return an undefined complex number
    if (isUndefined || c1.isUndefined)
      return new Complex(null);
    var realPart = rP - c1.rP;
    var imaginaryPart = iP - c1.iP;
    //return a new complex number to prevent mutation of other two complex numbers
    return new Complex(realPart, imaginaryPart);
  }

  public static Complex subTwo(Complex c1, Complex c2)
  {
    //check if this complex number or the other complex number is undefined
    //if either are undefined, then return an undefined complex number
    if (c1.isUndefined || c2.isUndefined)
      return new Complex(null);
    var realPart = c1.rP - c2.rP;
    var imaginaryPart = c1.iP - c2.iP;
    //return a new complex number to prevent mutation of other two complex numbers
    return new Complex(realPart, imaginaryPart);
  }

  public Complex mul(Complex c1)
  {
    //check if this complex number or the other complex number is undefined
    //if either are undefined, then return an undefined complex number
    if (isUndefined || c1.isUndefined)
      return new Complex(null);
    // use the formula (a+bj) * (c+dj) = (ac-bd) + (ad+bc)j
    var realPart = rP * c1.rP - iP * c1.iP;
    var imaginaryPart = rP * c1.iP + iP * c1.rP;
    //return a new complex number to prevent mutation of other two complex numbers
    return new Complex(realPart, imaginaryPart);
  }

  public static Complex mulTwo(Complex c1, Complex c2)
  {
    //check if this complex number or the other complex number is undefined
    //if either are undefined, then return an undefined complex number
    if (c1.isUndefined || c2.isUndefined)
      return new Complex(null);
    // use the formula (a+bj) * (c+dj) = (ac-bd) + (ad+bc)j
    var realPart = c1.rP * c2.rP - c1.iP * c2.iP;
    var imaginaryPart = c1.rP * c2.iP + c1.iP * c2.rP;
    //return a new complex number to prevent mutation of other two complex numbers
    return new Complex(realPart, imaginaryPart);
  }

  public Complex div(Complex c1)
  {
    //check if this complex number or the other complex number is undefined
    //if either are undefined, then return an undefined complex number
    if (isUndefined || c1.isUndefined || isZero(c1))
      return new Complex(null);
    // use the formula (a+bj) / (c+dj) = (1/(c^2 + d^2)) * (ac+bd) + (1/(c^2 + d^2)) * (bc - ad)j
    var realPart = (1 / (c1.rP * c1.rP + c1.iP * c1.iP))*(rP * c1.rP + iP * c1.iP);
    var imaginaryPart = (1 / (c1.rP * c1.rP + c1.iP * c1.iP))*(iP * c1.rP - rP * c1.iP);
    //return a new complex number to prevent mutation of other two complex numbers
    return new Complex(realPart, imaginaryPart);
  }

  public static Complex divTwo(Complex c1, Complex c2)
  {
    //check if this complex number or the other complex number is undefined
    //if either are undefined, then return an undefined complex number
    if (c1.isUndefined || c2.isUndefined || isZero(c2))
      return new Complex(null);
    // use the formula (a+bj) / (c+dj) = (1/(c^2 + d^2)) * (ac+bd) + (1/(c^2 + d^2)) * (bc - ad)j
    var realPart = (1 / (c2.rP * c2.rP + c2.iP * c2.iP))*(c1.rP * c2.rP + c1.iP * c2.iP);
    var imaginaryPart = (1 / (c2.rP * c2.rP + c2.iP * c2.iP))*(c1.iP * c2.rP - c1.rP * c2.iP);
    //return a new complex number to prevent mutation of other two complex numbers
    return new Complex(realPart, imaginaryPart);
  }

  private static bool isZero(Complex c)
  {
    return c.rP == 0 && c.iP == 0;
  }

  public void print()
  {
    if (isUndefined)
      Console.WriteLine("Undefined");
    else
      Console.WriteLine("{0} + {1}j", rP, iP);
  }

}


