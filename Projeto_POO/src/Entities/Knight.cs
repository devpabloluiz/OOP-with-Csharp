namespace Projeto_POO.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack()
        {
            return this.Name + " Attacked with his spear! ";
        }

        public string Attack(int Bonus)
        {
            if(Bonus > 6)
            {
            return this.Name + " Attacked with his spear and bonus damage!!! " + Bonus;
            }
            else
            {
                return this.Name + " Attacked with his spear! " + Bonus;
            }
        }
    }
}