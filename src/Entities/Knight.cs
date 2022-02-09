namespace Entities{
   public class Knight : Hero{
      public Knight(string name, int level, int power)
      {
         this.name = name;
         this.level = level;
         this.power = power;
      }

      public override string attack(){
         return this.name + " attacked with a sword";
      }                                             //polimorfismo, mesmo metodo, assinatura diferente
      public string attack(int bonus){                          
         return this.name + " attacked with a sword with a bonus of " + bonus;
      }
   }
}