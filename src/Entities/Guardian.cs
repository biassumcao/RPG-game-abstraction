namespace Entities
{
    public class Guardian : Hero
    {
        public Guardian(string name, int level, int power)
        {
            this.name = name;
            this.level = level;
            this.power = power;
        }

        public override string attack(){
            return this.name + " attacked with an arrow";
        } 
    }
}