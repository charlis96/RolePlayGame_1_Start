using System;

namespace Program
{
    public class Dwarf : Character , IStrike 
        {
            public Dwarf (string name)
            {
                this.Name = name;
                this.HealthPoints= 10;
                this.Defense = 3;
                this.Damage = 1;
                this.MagicPower = 0;
            }
        
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
                Personaje.HealthPoints -= (this.Damage)*2 - Personaje.Defense; //Debido a su furia en el combate
            }
        }
}