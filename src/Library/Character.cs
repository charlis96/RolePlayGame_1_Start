using System;

namespace Roleplay
{
    public class Character
    {
        public string Name { get; set; }
        public int Damage { get; set; }
        public int Defense { get; set; }
        public int TotalHealthPoints { get; set; }
        public int HealthPoints { get; set; }
        public int MagicPower { get; set; }
        public int HealingPotions { get; set; }
        public Inventory CharacterInventory { get; set; }


        public void Attack(Character character)
        {
            int DamageDone = this.Damage * 2 / character.Defense;
            if (DamageDone >= 1)
            {
                character.HealthPoints -= DamageDone;
                Console.WriteLine($"{this.Name} atacó a {character.Name} por {DamageDone} de daño.");
            }
            else
            {
                Console.WriteLine($"{this.Name} atacó a {character.Name} pero no logro hacerle daño debido a su nivel de armadura.");
            }
        }

        public void Heal(Character character)
        {
            if (this.HealingPotions > 0)
            {
                character.HealthPoints = character.TotalHealthPoints;
                this.HealingPotions--;
                Console.WriteLine($"Poción curativa usada. A {this.Name} le quedan {this.HealingPotions} pociones curativas.");
            }

            else
            {
                Console.WriteLine($"A {this.Name} no le quedan más pociones curativas.");
            }
        }

        public void AddItem(Item item)
        {
            if (this.CharacterInventory.ItemQuantity < Inventory.MaxItems)
            {
                this.CharacterInventory.Items.Add(item);
                this.Damage += item.Damage;
                this.Defense += item.Defense;
                this.TotalHealthPoints += item.TotalHealthPoints;
                this.CharacterInventory.ItemQuantity++;
                Console.WriteLine($"Se ha añadido el item {item.Name} al inventario.");
            }

            else
            {
                Console.WriteLine("No se puede agregar item, el inventario está lleno.");
            }
        }

        public void RemoveItem(Item item)
        {
            this.CharacterInventory.Items.Remove(item);
            this.Damage -= item.Damage;
            this.Defense -= item.Defense;
            this.TotalHealthPoints -= item.TotalHealthPoints;
            this.CharacterInventory.ItemQuantity--;
            Console.WriteLine($"Se ha removido el item {item.Name} del inventario.");
        }
    }
}


/*
    Acá estoy usando herencia.
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