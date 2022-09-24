using System;

namespace Roleplay
{
    public class Wizard : Character, IAttack
    {
        public bool HasSpellBook { get; set; } = false;

        public Wizard(string name)
        {
            this.Name = name;
            this.Damage = 1;
            this.Defense = 2;
            this.TotalHealthPoints = 12;
            this.HealthPoints = 12;
            this.MagicPower = 0;
            this.HealingPotions = 3;
        }

        public void AddSpellBook(SpellBook spellBook)
        {
            if (!HasSpellBook)
            {
                HasSpellBook = true;
                this.Damage += spellBook.Damage;
                this.Defense += spellBook.Defense;
                this.HealthPoints += spellBook.TotalHealthPoints;
                this.MagicPower += spellBook.MagicPower;
                Console.WriteLine($"Se ha añadido un libro de hechizos al mago {this.Name}.");
            }

            else
            {
                Console.WriteLine("Este mago ya tiene un libro de hechizos.");
            }
        }

        public void SpecialAbility(Character character)
        //La idea de la habilidad especial del mago es que le reduzca la defensa al que recibe su ataque
        {
            character.Defense -= this.MagicPower;
        }
    }
}