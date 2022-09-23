using System;

namespace Program
{
    public class Dwarf : Character , IStrike 
        {
            public override void setDamage(Inventory Object)
            /*
                La idea de este metodo es que si son armas cuerpo a cuerpo su aumento de daño incremente en 1, 
                ej: si una espada agrega 2 de daño, en este caso agregaria 3
            */
            {
                this.Damage += (Object.UpgrateDamage())+1;
            }
            
            public void SpecialHability(Character Personaje)
            {
                Personaje.HealthPoints -= (this.Damage - Personaje.Defense)*2; //Debido a su furia en el combate
            }
        }
}