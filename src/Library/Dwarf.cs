using System;

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
            int DamageDone = this.Damage * 2 / character.Defense;
            if (DamageDone >= 1)
            {
                character.HealthPoints -= (DamageDone)*2;//Debido a su furia en el combate
                Console.WriteLine($"{this.Name} atacó a {character.Name}  con toda su furia y realizó un daño por {DamageDone} puntos de daño.");
            } 
             else
            {
                Console.WriteLine($"{this.Name} atacó a {character.Name} pero no logro hacerle daño debido a su nivel de armadura.");
            }
        }
    }
}