/*
 Caracteristicas en comun:
 Nombre
 Descripción
 Vida
 Ataque
 Defensa
 Poder Magico ---> Es posible q lo saquemos ya que podemos asumir que es más o menos lo mismo q Daño, pero para los magos
*/
using System;

namespace Program
{
    public class Elf : Character , IStrike 
        {
            public int HealPower;
            public Elf (string name)
            {
                this.Name = name;
                this.HealthPoints= 10;
                this.Defense = 3;
                this.Damage = 1;
                this.MagicPower = 0;
                this.HealPower = 1;
            }

            public override void  Increase(Inventory item)
            {
            this.Damage += item.UpgrateDamage();
            this.Defense += item.UpgrateDefense();
            this.MagicPower += item.UpgrateMagicPower();
            this.HealPower += item.UpgrateHealing();
            }

            public void SpecialHability(Character Personaje)
            {
                Personaje.HealthPoints += 1*(HealPower);
            }
        }
}