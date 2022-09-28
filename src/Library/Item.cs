namespace Roleplay;
/*
 Se creó esta clase con el fin de crear
  los items que luego se van a atribuir 
  a los personajes del juego en su inventario . 
*/
public class Item
{
    public string Name { get; protected set; }
    public int Damage { get; protected set; }
    public int Defense { get; protected set; }
    public int TotalHealthPoints { get; protected set; }
}