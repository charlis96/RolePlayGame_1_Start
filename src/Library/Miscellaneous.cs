namespace Roleplay;

public class Miscellaneous : Item
{
    public Miscellaneous(string name, int damage, int defense, int totalHealthPoints)
    {
        this.Name = name;
        this.Damage = damage;
        this.Defense = defense;
        this.TotalHealthPoints = totalHealthPoints;
    }
}