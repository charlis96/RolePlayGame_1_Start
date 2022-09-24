/*
    Clase inventario, y cada espada, hacha o lo q sea son objetos de esta clase 
*/
using System;
using System.Collections;

namespace Roleplay
{
    public class Inventory
    {
        public ArrayList Items { get; set; }
        public int Damage { get; set; }
        public int Defense { get; set; }
        public int HealthPoints { get; set; }
        public int MagicPower { get; set; }
        public bool ContainsSpellBook { get; set; } = false;

        public void AddItem(T item)
        {
            this.Items.Add(item);
            this.Damage = item.Damage;

        }

        // public Inventory()
        // {
        //     this.Defense = defense;
        //     this.Damage = damage;
        //     this.HealthPoints = healthPoints;
        //     this.MagicPower = magicPower;
        // }

        // public string Name;

        // public int UpgradeDefense()
        // {
        //     return this.ExtraDefense;
        // }

        // public int UpgradeDamage()
        // {
        //     return this.ExtraDamage;
        // }

        // public int UpgradeMagicPower()
        // {
        //     return this.ExtraMagicPower;
        // }

        // public int UpgradeHealing()
        // {
        //     return this.ExtraHealing;
        // }
    }
}

