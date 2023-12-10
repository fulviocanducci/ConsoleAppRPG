namespace RPG.Entities
{
   public class Arus
   {
      public Arus(string? name, int level, string? heroType)
      {
         Name = name;
         Level = level;
         HeroType = heroType;
      }

      public string? Name { get; set; }
      public int Level { get; set; }
      public string? HeroType { get; set; }

      public override string ToString()
      {
         return $"{Name} {Level} {HeroType}";
      }
   }
}
