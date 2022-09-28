namespace Roleplay;
/*
    Esta clase se hereda la clase Item, con el propósito de contemplar items con propiedades específicas.
*/
public class Weapon : Item
{
    public Weapon(string name, int damage)
    {
        this.Name = name;
        this.Damage = damage;
        this.Defense = 0;
        this.TotalHealthPoints = 0;
    }
}