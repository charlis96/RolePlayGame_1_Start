namespace Roleplay;
/*
 Se creó esta clase para crear los items.
*/
public class Item
{
    public string Name { get; protected set; }
    public int Damage { get; protected set; }
    public int Defense { get; protected set; }
    public int TotalHealthPoints { get; protected set; }
}