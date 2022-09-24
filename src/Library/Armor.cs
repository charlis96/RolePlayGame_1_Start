namespace Roleplay;

public class Armor
{
    public string Name { get; }
    public int Defense { get; }

    public Armor(string name, int defense)
    {
        this.Name = name;
        this.Defense = defense;
    }

}