using RPG.Entities;

namespace RPG
{
   internal class Program
   {
      static void Main(string[] args)
      {
         Arus hero = new("Arus", 2, "Knight");
         Arus oponent = new("Maleficus", 99, "Devil");


         Console.WriteLine(hero);
         Console.WriteLine(oponent);
      }
   }
}