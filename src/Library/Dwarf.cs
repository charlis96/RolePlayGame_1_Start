namespace Roleplay
{
    public class Dwarf : Character, ISpecialAbility
    {
        public Dwarf(string name)
        {
            this.Name = name;
            this.Damage = 2;
            this.Defense = 3;
            this.TotalHealthPoints = 20;
            this.HealthPoints = 20;
            this.MagicPower = 0;
            this.HealingPotions = 3;
            this.CharacterInventory = new Inventory();
        }

        public void SpecialAbility(Character character)
        {
            character.HealthPoints -= (this.Damage) * 2 - character.Defense; //Debido a su furia en el combate
        }
    }
}