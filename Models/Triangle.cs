namespace Shape.Models
{
  public class Triangle
  {
    private int _sideA;
    private int _sideB;
    private int _sideC;

    public Triangle(int sideA, int sideB, int sideC)
    {
    _sideA = sideA;
    _sideB = sideB;
    _sideC = sideC;
    }
    public string GetIsTriangle(int sideA, int sideB, int sideC)
    {
      if(sideA + sideB < sideC || sideA + sideC < sideB || sideB + sideC < sideA)
      {
        return "not a triangle";
        // Console.WriteLine("not a triangle");
      }
      else if (sideA == sideB && sideB == sideC)
      {
        return "Eauilateral! All sides are equal to: " + _sideA;
        // Console.WriteLine("Equilateral!");
      }
      else if (sideA == sideB || sideB == sideC || sideC == sideA)
      {
        return "Isosceles";
        // Console.WriteLine("Isosceles");
      }
      else
      {
        return "Scalene";
        // Console.WriteLine("Bro that's a scalene");
      }
    }
  }
}