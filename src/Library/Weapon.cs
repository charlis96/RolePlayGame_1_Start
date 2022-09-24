namespace Roleplay;

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