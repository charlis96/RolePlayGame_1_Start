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

        public Inventory(int extraDamage, int extraDefense, int extraMagicPower)
        {
            this.extraDefense = extraDefense;
            this.extraDamage = extraDamage;
            this.extraMagicPower = extraDefense;
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
            return this.extraDefense;
        }

        public int UpgrateHealing()
        {
            return this.extraDefense;
        }
    }
    public class SpellBook : Inventory
    {
        /*
            No se si esta clase es necesario, solo que la letra habla especificamente de esto, 
            pero podriamos hacer que sea un objeto más en lugar de crear una clase solamente 
            para los libros.
        */
          public SpellBook(int extraDamage, int extraDefense, int extraMagicPower) : base ( extraDamage,  extraDefense, extraMagicPower) 
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
    }
}

