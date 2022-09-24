using System;
using System.Collections.Generic;

namespace Roleplay
{
    public class SpellBook
    {
        public List<Spell> spells { get; set; }
        public int Damage { get; set; } = 0;
        public int Defense { get; set; } = 0;
        public int TotalHealthPoints { get; set; } = 0;
        public int MagicPower { get; set; } = 0;
        public void AddSpell(Spell spell)
        {
            this.spells.Add(spell);
            this.Damage += spell.Damage;
            this.Defense += spell.Defense;
            this.TotalHealthPoints += spell.TotalHealthPoints;
            this.MagicPower += spell.MagicPower;
            Console.WriteLine($"Se ha añadido el hechizo {spell.Name} al libro.");
        }
    }
}