namespace Roleplay
{
    public class Elf : Character, IAttack
    {
        public Elf(string name)
        {
            this.Name = name;
            this.Damage = 2;
            this.Defense = 3;
            this.TotalHealthPoints = 15;
            this.HealthPoints = 15;
            this.MagicPower = 0;
            this.HealingPotions = 3;
            CharacterInventory = new Inventory();
        }

        public void SpecialAbility(Character character)
        {
            character.TotalHealthPoints++; //Da vida permanentemente con una flecha (?)
        }
    }
}