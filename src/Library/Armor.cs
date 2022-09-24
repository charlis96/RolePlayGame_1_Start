namespace Roleplay;

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