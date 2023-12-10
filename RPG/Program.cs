using RPG.Entities;

namespace RPG
{
   internal class Program
   {
      static void Main(string[] args)
      {
         Hero hero = new("Arus", 2, "Knight");
         Wizard oponent = new("Maleficus", 99, "Devil");


         Console.WriteLine(hero.Attack());
         Console.WriteLine(oponent.Attack());
      }
   }
}