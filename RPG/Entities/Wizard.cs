namespace RPG.Entities
{
   public class Wizard: Hero
   {
      public Wizard(string? name, int level, string? heroType) 
         : base(name, level, heroType)
      {
      }

      public override string Attack()
      {
         return $"{Name} lançou magia ...";
      }

      public string Attack(string bonus)
      {
         return $"{Name} lançou magia e {bonus}";
      }
   }
}
