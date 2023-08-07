using System;
using System.Collections.Generic;

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

      // string stringNum = "2";
      // int intNum = Convert.ToInt32(stringNum);
      // Console.WriteLine(intNum.GetType());
      // Console.WriteLine(intNum);

      // Dictionary<string, int> myScoreBoard = new Dictionary<string, int>(){
      //   { "firstInning", 10 },
      //   { "secondInning", 20},
      //   { "thirdInning", 30},
      //   { "fourthInning", 40},
      //   { "fifthInning", 50}
      // };
      // Console.WriteLine("----------------");
      // Console.WriteLine("  Scoreboard");
      // Console.WriteLine("----------------");
      // Console.WriteLine("Inning |  Score");
      // Console.WriteLine("   1   |    {0}", myScoreBoard["firstInning"]);
      // Console.WriteLine("   2   |    {0}", myScoreBoard["secondInning"]);
      // Console.WriteLine("   3   |    {0}", myScoreBoard["thirdInning"]);
      // Console.WriteLine("   4   |    {0}", myScoreBoard["fourthInning"]);
      // Console.WriteLine("   5   |    {0}", myScoreBoard["fifthInning"]);

      string[] favFoods = new string[3] { "pizza", "doughnuts", "icecream" };
      string firstFood = favFoods[0];
      string secondFood = favFoods[1];
      string thirdFood = favFoods[2];
      Console.WriteLine("I like {0}, {1}, and {2}", firstFood, thirdFood, secondFood);
    }
  }
}