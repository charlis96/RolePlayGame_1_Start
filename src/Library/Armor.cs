namespace Roleplay;
/*
 Esta clase se hereda la clase Item, con el propósito de contemplar items con propiedades específicas.
 En este caso, estos items (definidos como armaduras) no aportan una suma de daño ni de vida máxima (TotalHealthPoints)
*/
public class Armor : Item

{
    public Armor(string name, int defense)
    {
        this.Name = name;
        this.Damage = 0;
        this.Defense = defense;
        this.TotalHealthPoints = 0;
    }
}