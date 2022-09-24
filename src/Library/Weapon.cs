namespace Roleplay;

public class Weapon
{
    public string Name { get; }
    public int Damage { get; }

    public Weapon(string name, int damage)
    {
        this.Name = name;
        this.Damage = damage;
    }

}