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
    interface IStrike
    {

    }
    public class Character
    {
        public string Name;
        public int HealthPoints { get; set; }
        public int Defense { get; set; }
        public int Damage { get; set; }
        public int MagicPower { get; set; }
        public void setDefense(Inventory Object)
        {
            this.Defense += Object.UpgrateDefense();
        }

        public Character()
        {
            this.HealthPoints = 100;
        }


        public virtual void Atack(Character Personaje)
        {
            Personaje.HealthPoints -= (this.Damage - Personaje.Defense);
        }

        public void deffend()
        /*
           No se si este metodo es necesario ya que existe la posibildad de 
           que en el metodo "Atack" se tome en cuanta la defensa y se haga 
           el ataque resultante de la resta del ataque con la defensa, 
           restando así el resultado con la vida del personaje atacado.
           O no se si podemos crear un metodo que sepa cuando lo atacan 
           para restarele el daño que le hacen.
           Pero considero mejor la primera opción.
        */
        {

        }
        public void Increase(Inventory Object)
        {
            this.Damage += Object.UpgrateDamage();
            this.Defense += Object.UpgrateDefense();
            this.MagicPower += Object.UpgrateMagicPower();
        }

        public void InventoryCatalog()
        {
            /*
                Aca definimos el maximo de cosas que puede tener en el inventario 
            */
            Inventory[] backpack = new Inventory[3];
        }
    }
    public class Elf : Character , IStrike 
    {
        public int extraHeal;

        public void Healing(Character Personaje)
        {
            Personaje.HealthPoints += extraHeal;
        }
    }

    public class Wizzard : Character , IStrike 
    {

    }

    public class Dwarf : Character , IStrike 
    {

    }
}

/*
    Acá estoy usando herencía.
*/

/*
    Podria ser q por ejemplo el mago tenga varios ataques y 
    haya un selector de número al azar que segun ese número 
    el ataque q realiza y el daño q aplica
*/

/*
    Tambien podemos hacer que tengan un número limitado de elementos
    de cierto tipo como armadura o armas y tambien poner un limitador 
    que por ejemplo un enano no pueda tener un libro 
*/

/*
    Puede ser que cuando alguien ataque a otro personaje le saque la "vida"
    a la armadura por ejemplo por ejemplo si aguien ataca y tiene dos puntos
    ese ataque
*/

/*
    Si el personaje no tiene arma, ¿puede atacar?
*/

/*
    Se utiliza estas clases para realizar ya que consideramos que son las expertas 
    debido a que saben el ataque que tiene por defecto el personaje y ademas se le
    suma el ataque extra que le agregan los objetos como armas entre otras cosas.
*/

/*
    Estaria bueno que los objetos de los personajes fueran como al azar, pero que 
    el jugador tuviera la opcion de cambiarlo por otro objeto aleatorio también 
    sacrificando así uno de los que ya tenía.
*/