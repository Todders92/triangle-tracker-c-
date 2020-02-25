using System;
using System.Collections.Generic;

public class Triangle
{
  public int SideA;
  public int SideB;
  public int SideC;

  public Triangle(int sideA, int sideB, int sideC)
  {
   SideA = sideA;
   SideB = sideB;
   SideC = sideC;
  }
  public void IsTriangle(int sideA, int sideB, int sideC)
  {
    if(sideA + sideB < sideC || sideA + sideC < sideB || sideB + sideC < sideA)
    {
      Console.WriteLine("not a triangle");
    }
    else if (sideA == sideB && sideB == sideC)
    {
      Console.WriteLine("Equilateral!");
    }
    else if (sideA == sideB || sideB == sideC || sideC == sideA)
    {
      Console.WriteLine("Isosceles");
    }
    else
    {
      Console.WriteLine("Bro that's a scalene");
    }
  }

public class TriangleChecker
{
    public static void Main()
    {
      Console.WriteLine("The following prompts will ask for three different sides to triangle. PLease enter the lengths respectively. Enter the first length: ");
      string sideAString = Console.ReadLine();
      int sideA = int.Parse(sideAString);
      Console.WriteLine("Enter the second length: ");
      string sideBString = Console.ReadLine();
      int sideB = int.Parse(sideBString);
      Console.WriteLine("Enter the third length: ");
      string sideCString = Console.ReadLine();
      int sideC = int.Parse(sideCString);
      Triangle triangle = new Triangle(sideA, sideB, sideC);
      triangle.IsTriangle(sideA, sideB, sideC);
    }
  }
}