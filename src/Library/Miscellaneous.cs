namespace Roleplay;

public class Miscellaneous
{
    public string Name { get; }
    public int Damage { get; }
    public int Defense { get; }
    public int HealthPoints { get; }

    public Miscellaneous(string name, int damage, int defense, int healthPoints)
    {
        this.Name = name;
        this.Damage = damage;
        this.Defense = defense;
        this.HealthPoints = healthPoints;
    }

}