using System;
using System.Collections.Generic;
using Shape.Models;

namespace Shape
{
  public class Program
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
    string result = triangle.GetIsTriangle(sideA, sideB, sideC);
    Console.WriteLine(result);
    }
  }
}