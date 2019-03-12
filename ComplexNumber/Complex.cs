using System; // namespace containing ArgumentOutOfRangeException

public class Complex
{
  private double rP = 0; // real part
  private double iP = 0; // imaginary part

  public Complex()
  {

  }

  public Complex(double r, double i)
  {
    SetComplex(r, i);
  }


  public void SetComplex(double r, double i)
  {
    rP = r;
    iP = i;
  }

  public void add(Complex c1)
  {
    rP += c1.rP;
    iP += c1.iP;
  }

  public void addTwo(Complex c1, Complex c2)
  {
    rP = c1.rP + c2.rP;
    iP = c1.iP + c2.iP;
  }

  public void mul(Complex c1)
  {
    // use the formula (a+bj) * (c+dj) = (ac-bd) + (ad+bc)j
    rP = rP * c1.rP - iP * c1.iP;
    iP = rP * c1.iP + iP * c1.rP;
  }

  public void mulfix(Complex c1)
  {
    // use the formula (a+bj) * (c+dj) = (ac-bd) + (ad+bc)j
    Complex ccopy = new Complex();

    ccopy.rP = rP * c1.rP - iP * c1.iP;
    ccopy.iP = rP * c1.iP + iP * c1.rP;
    rP = ccopy.rP;
    iP = ccopy.iP;
  }

  public void print()
  {
    Console.WriteLine("{0} + {1}j", rP, iP);
  }

}


