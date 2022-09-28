using System;

namespace Roleplay
/*
        La clase Wizard se hereda de la clase Character y ISpecialAbility. 
*/
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
            this.MagicPower = 1;
            this.HealingPotions = 3;
            this.CharacterInventory = new Inventory();
        }

        public void AddSpellBook()
        /*
            Con este metodo nos aseguramos de que solo este tipo de personaje 
            sea capaz de portar un libro de hechizos y por lo tanto utilizar 
            hechizos, esto se debe a que es un metodo especifico de esta clase.
        */
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
        /*
        Si este personaje tiene un libro de hechizo, con este método puede agregar hechizos.
        Si no se le informará que no puede añadir.
        */
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
        //La idea de la habilidad especial del mago consiste en reducir la defensa al que recibe su ataque especial.
        {
            character.Defense -= this.MagicPower;
        }
    }
}