using System;
using System.Collections.Generic;

namespace Roleplay
/*
    En esta clase se crea una lista, como libro,  para luego agregar los hechizos.
*/
{
    public class SpellBook
    {
        public List<Spell> Spells { get; set; } = new List<Spell> { };
    }
}