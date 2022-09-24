/*
    Clase inventario, y cada espada, hacha o lo q sea son objetos de esta clase 
*/
using System;
namespace Roleplay
{
    public class Inventory
    {
        public int ExtraDamage;
        public int ExtraDefense;
        public int ExtraMagicPower;
        public int ExtraHealing;
        public bool ContainsSpellBook=false;        
        public Inventory(int extraDamage, int extraDefense, int extraMagicPower, int extraHealing)
        {
            this.ExtraDefense = extraDefense;
            this.ExtraDamage = extraDamage;
            this.ExtraMagicPower = extraDefense;
            this.ExtraHealing = extraHealing;
        }

        public string Name;

        public int UpgradeDefense()
        {
            return this.ExtraDefense;
        }

        public int UpgradeDamage()
        {
            return this.ExtraDamage;
        }

        public int UpgradeMagicPower()
        {
            return this.ExtraMagicPower;
        }

        public int UpgradeHealing()
        {
            return this.ExtraHealing;
        }
    }
}

