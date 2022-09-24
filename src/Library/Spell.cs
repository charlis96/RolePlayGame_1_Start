using System;
namespace Roleplay
{
    public class Spell : Inventory
    {
        public Spell(int extraDamage, int extraDefense, int extraMagicPower, int extraHealing) : base ( extraDamage,  extraDefense, extraMagicPower, extraHealing) 
        {
            this.extraDefense = extraDefense;
            this.extraDamage = extraDamage;
            this.extraMagicPower = extraDefense;
        } 
        new public int UpgradeMagicPower() //No se si dejarlo aca o en la clase inventory
        {
            return this.extraDefense;
        }
    }
}