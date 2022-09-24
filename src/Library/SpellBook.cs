using System;
using System.Collections.Generic;

namespace Program
{
    public class SpellBook : Inventory
    {
        /*
            No se si esta clase es necesario, solo que la letra habla especificamente de esto, 
            pero podriamos hacer que sea un objeto más en lugar de crear una clase solamente 
            para los libros.
        */
        public List<Spell> book = new List<Spell> ();
        public SpellBook(int extraDamage, int extraDefense, int extraMagicPower, int extraHealing) : base ( extraDamage,  extraDefense, extraMagicPower, extraHealing) 
        /*
            Preguntar a que se debe q no tenga que poner el tipo de variable que son, ¿es debido a que lo aclare en al clase padre/superclase?
        */
        /*
            Podemos hacer que los libros le agregeen algún poder especial.
        */
        {
            this.extraDefense = extraDefense;
            this.extraDamage = extraDamage;
            this.extraMagicPower = extraDefense;
        } 
        new public int UpgrateMagicPower() //No se si dejarlo aca o en la clase inventory
        {
            return this.extraDefense;
        }
        public string AddSpell (Spell spell)
        {
                book.Add(spell);
                return "Se ha añadido el hechizo a tu libro.";
        }

        public void Effects ()
        {
            foreach (Spell spell in book)
            {
                this.extraDefense =+ spell.extraDefense;
                this.extraDamage =+ spell.extraDamage;
                this.extraMagicPower =+ spell.extraDefense;
                /*
                    Se puede hacer q aqui afecte directamente al personaje q lo tiene puesto 
                    en vez de afectar al libro y que el libro afecte al personaje, pq me genera 
                    duda con el tema de expert, pero si así cumple el patrón lo dejamos así.
                    Cada mago tendra un unico libro.

                */
            }
        }
    }
}