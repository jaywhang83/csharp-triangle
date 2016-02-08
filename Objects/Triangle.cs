using System;

namespace Triangles
{
  class Triangle
  {
    public int Side1 = 0;
    public int Side2 = 0;
    public int Side3 = 0;
    public string Type;

    public Triangle(int side1, int side2, int side3)
    {
      Side1 = side1;
      Side2 = side2;
      Side3 = side3;
      typeOfTriangle();
    }

    public bool IsTriangle()
    {
      if ((Side1 + Side2) < Side3 || (Side2 + Side3) < Side1 || (Side3 + Side1) < Side2)
      {
        return false;
      }
      else
      {
        return true;
      }
    }

    public void typeOfTriangle()
    {
      if (Side1 == Side2 && Side1 == Side3)
      {
        Type = "equilateral";
      }
      else if (Side1 == Side2 || Side2 == Side3 || Side1 == Side3)
      {
        Type = "isosceles";
      }
      else
      {
        Type = "scalene";
      }
    }
  }

}
