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
      
      // Console.WriteLine($"area: {area}");
      // Console.WriteLine(area.GetType());

      // bool isCold = true;
      // Console.WriteLine(isCold ? "drink" : "add ice"); 
      // Console.WriteLine(!isCold ? "drink" : "add ice"); 

      string stringNum = "2";
      int intNum = Convert.ToInt32(stringNum);
      Console.WriteLine(stringNum);
      Console.WriteLine(intNum);
    }
  }
}