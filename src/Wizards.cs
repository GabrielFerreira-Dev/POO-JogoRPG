namespace Projeto1.src
{
    public class Wizard : Hero 
    {
        public Wizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack()
        {
            return this.Name + " atacou magia";
        }

        public string Attack(int Bonus){

            if (Bonus > 6){
                return this.Name + " Lançou Magia superefetiva";
            }
            else{          
                return this.Name + " Lançou Magia com bônus de ataque de " + Bonus;
            }        
        }
    }
}