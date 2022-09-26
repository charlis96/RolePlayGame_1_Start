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
        /*
            Este metodo se realiza de esta forma ya que tiene el proposito de poder 
            compartir las posciones que tiene un personaje con otros.
        */
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