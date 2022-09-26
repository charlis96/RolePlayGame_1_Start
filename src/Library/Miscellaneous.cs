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

/*
    Utilizamos esta clase para el caso que existan items 
    que no se consideren armas ni armadura pero que de 
    igual forma aporten características al personaje 
*/