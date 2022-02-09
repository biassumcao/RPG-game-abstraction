namespace Entities{
   public abstract class Hero{
      public string? name { get; set; }
      public int level { get; set; }
      public int power { get; set; }
      
      

      public override string ToString(){
         return "Nome: " + this.name + "\nNivel: " + this.level + "\nTipo: " + this.GetType() + "\nPoder: " + this.power;
      }

      public abstract string attack();
      
   }
}