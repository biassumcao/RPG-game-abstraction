using static System.Console;
using System;
using Entities;
class Program
{
   public static void Main(string[] args)
   {
      Knight hero1 = new Knight("Warrior of Light", 2, 5000);
      Guardian hero2 = new Guardian("Auron", 6, 8000);
      Witch hero3 = new Witch("Ultimecia", 4, 7000);

      WriteLine(hero1.attack());
      WriteLine(hero2.attack());
      WriteLine(hero3.attack());

      WriteLine(hero1.ToString());
      WriteLine(hero2.ToString());
      WriteLine(hero3.ToString());
   }
}