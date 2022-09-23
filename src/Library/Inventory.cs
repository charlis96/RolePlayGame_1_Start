/*
    clase inventario, y cada espada, hacha o lo q sea son objetos de esta clase
    Tambien podriamos hacer como en onventario  
*/
using System;
namespace Program
{
    public class Inventory
    {
        public int extraDamage;
        public int extraDefense;
        public int extraMagicPower;
        public int extraHealing;

        public Inventory(int extraDamage, int extraDefense, int extraMagicPower, int extraHealing)
        {
            this.extraDefense = extraDefense;
            this.extraDamage = extraDamage;
            this.extraMagicPower = extraDefense;
            this.extraHealing = extraHealing;
        }
        public string Name;

        public int UpgrateDefense()
        {
            return this.extraDefense;
        }

        public int UpgrateDamage()
        {
            return this.extraDamage;
        }

        public int UpgrateMagicPower()
        {
            return this.extraMagicPower;
        }

        public int UpgrateHealing()
        {
            return this.extraHealing;
        }

        
    }
}

