using System;

namespace Roleplay
{
    public class Wizard : Character, ISpecialAbility
    {
        public bool HasSpellBook { get; set; } = false;
        public SpellBook WizardSpellBook { get; set; }

        public Wizard(string name)
        {
            this.Name = name;
            this.Damage = 1;
            this.Defense = 2;
            this.TotalHealthPoints = 12;
            this.HealthPoints = 12;
            this.MagicPower = 0;
            this.HealingPotions = 3;
            this.CharacterInventory = new Inventory();
        }

        public void AddSpellBook()
        {
            if (!HasSpellBook)
            {
                this.WizardSpellBook = new SpellBook();
                HasSpellBook = true;
                Console.WriteLine($"Se ha añadido un libro de hechizos al mago {this.Name}.");
            }

            else
            {
                Console.WriteLine("Este mago ya tiene un libro de hechizos.");
            }
        }
        public void AddSpell(Spell spell)
        {
            if (HasSpellBook)
            {
                this.WizardSpellBook.Spells.Add(spell);
                this.Damage += spell.Damage;
                this.Defense += spell.Defense;
                this.TotalHealthPoints += spell.TotalHealthPoints;
                this.MagicPower += spell.MagicPower;
                Console.WriteLine($"Se ha añadido el hechizo {spell.Name} al libro de hechizos de {this.Name}.");
            }

            else
            {
                Console.WriteLine($"No se ha podido añadir el hechizo porque {this.Name} no tiene un libro de hechizos.");
            }
        }

        public void SpecialAbility(Character character)
        //La idea de la habilidad especial del mago es que le reduzca la defensa al que recibe su ataque
        {
            character.Defense -= this.MagicPower;
        }
    }
}