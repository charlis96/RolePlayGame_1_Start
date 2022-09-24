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
using System.Collections.Generic;
namespace Roleplay
{
    public class Character
    {
        public string Name { get; set; }
        public int HealthPoints { get; set; }
        public int Defense { get; set; }
        public int Damage { get; set; }
        public int MagicPower { get; set; }
        public bool PortarLibro = false;
        
        public List<Inventory> backpack = new List<Inventory> (); // Aca definimos el maximo de cosas que puede tener en el inventario

        public virtual void setDefense(Inventory Object)
        {
            this.Defense += Object.UpgradeDefense();
        }
        public virtual void setDamage(Inventory Object)
        {
            this.Damage += Object.UpgradeDamage();
        }

        public virtual void Attack(Character Personaje)
        {
            Personaje.HealthPoints -= (this.Damage - Personaje.Defense);
        }

        public virtual void  Increase(Inventory item)
        {
            this.Damage += item.UpgradeDamage();
            this.Defense += item.UpgradeDefense();
            this.MagicPower += item.UpgradeMagicPower();
            
        }

        public void RemoveItem(Inventory item)
        {
            /*
                Para sacar items de la lista de objetos que tiene en el inventario (en la lista)
            */

        }

        public string AddItem (Inventory item)
        {
            if (backpack.Count<3)
            {
                backpack.Add(item);
                return "Se ha agregado el item a su inventario.";
            }
            else
            {
                return "No se ha podido agregar el item, ya no contiene más espacio.";
            }
        }

        public virtual void Portar(Character character)   
        {
            if (character.PortarLibro == true)
            {
                
            }
        }
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