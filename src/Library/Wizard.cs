using System;

namespace Roleplay
{
    public class Wizard : Character, IStrike

    {
        public Wizard(string name)
        {
            this.Name = name;
            this.HealthPoints = 10;
            this.Defense = 2;
            this.Damage = 1;
            this.MagicPower = 1;
        }
        new public static bool PortarLibro = true;
        public void Power(SpellBook book)
        // La idea de Magicpower es que aumente el impacto de las habilidades especiales
        {
            this.Damage += book.UpgradeDamage();
            this.Defense += book.UpgradeDefense();
            this.MagicPower = +book.UpgradeMagicPower(); // La idea de Magicpower es que aumente el impacto de las habilidades especiales
        }
        public void SpecialHability(Character Personaje)
        /*
            La idea de la habilidad especial del mago es que le reduzca la defensa al que recibe su ataque 
        */
        {
            Personaje.Defense -= 2 * (this.MagicPower);
        }

        public override void Portar(Character character)
        {
            if (character.PortarLibro == true)
            {

            }
        }
    }
}

/*
    Falta hacer que los personajes no se puedan poner libros 
*/
