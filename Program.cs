using System;
namespace CatWorx.BadgeMaker
{
  class Program
  {
    static void Main()
    {
      // How do you find the area of a square? Area = side * side
      // double side = 3.14;
      // double area = side * side;
      // string greeting = "Hello ";
      // greeting = greeting + "World";
      // Console.WriteLine($"area: {area}");
      // Console.WriteLine(area.GetType());
      bool isCold = true;
      Console.WriteLine(isCold ? "drink" : "add ice");  // output: drink
      Console.WriteLine(!isCold ? "drink" : "add ice");  // output: add ice
    }
  }
}