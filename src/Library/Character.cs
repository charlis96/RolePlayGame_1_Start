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

/*
    Para este método pensamos en los factores bases que podían afectar a este y su efecto a otros objetos que,
    en este caso, serían personajes afectando así su vida, al momento de pensar en este método pensamos en realizarlo
    con una una división ya que de esta manera se tardaría más en acabar con otro personaje haciendo así que el juego
    dure más tiempo.
    Además consideramos el caso en que el atacante no tuviera e suficiente daño como para dañar a su victima 
    por lo cual agregamos un condicional if.

*/
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
        /*
            Este método se realiza de esta forma ya que tiene el proposito de poder compartir las posiciones que tiene
            un personaje con otros.
        */
        
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
        
        /*
            Este método agrega los items a una lista 
        */
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
        /*
            Para este método se utiliza la misma lista del método anterior, con el fin de quitar items. 
        */
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