using System;

namespace Program
{
    public class Wizzard : Character , IStrike 

        {   
            public Wizzard (string name)
            {
                this.Name = name;
                this.HealthPoints= 10;
                this.Defense = 2;
                this.Damage = 1;
                this.MagicPower = 1;
            }
            new public bool PortarLibro = true;
            public void Power(SpellBook book)
            // La idea de Magicpower es que aumente el impacto de las habilidades especiales
            {
                this.Damage += book.UpgrateDamage();
                this.Defense += book.UpgrateDefense();
                this.MagicPower =+ book.UpgrateMagicPower(); // La idea de Magicpower es que aumente el impacto de las habilidades especiales
            }
            public void SpecialHability(Character Personaje)
            /*
                La idea de la habilidad especial del mago es que le reduzca la defensa al que recibe su ataque 
            */
            {
                Personaje.Defense -= 2*(this.MagicPower);
            }
            
        }
}

/*
    Falta hacer que los personajes no se puedan poner libros y que los magos no se puedan poner items
*/
