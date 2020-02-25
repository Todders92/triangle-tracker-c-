using System;
using System.Collections.Generic;

public class Triangle
{
  public int SideA;
  public int SideB;
  public int SideC;

  public Triangle(int sideA, int sideB, int sideC)
  {
    int SideA = sideA;
    int SideB = sideB;
    int SideC = sideC;
  }

  public static void Main()
  {
    Console.WriteLine("The following prompts will ask for three different sides to triangle. PLease enter the lengths respectively. Enter the first length: ");
    string sideAString = Console.ReadLine();
    int sideA = int.Parse(sideAString);
    Console.WriteLine("Enter the second length: ");
    string sideBString = Console.ReadLine();
    int sideB = int.Parse(sideBString);
    Console.WriteLine(sideB);
    Console.WriteLine("Enter the third length: ");
    string sideCString = Console.ReadLine();
    int sideC = int.Parse(sideCString);
    Triangle triangle = new Triangle(sideA, sideB, sideC);
    Console.WriteLine(triangle.SideA);

  }
}