using System;
using Roleplay;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Bienvenidos al juego---");
            Console.WriteLine("Ahora cada a uno de los dos jugadores se le sera asignado un personaje de cada tipo constando asi con tres personajes con los cuales va a poder jugar asignandole tambien armas, proteccion y/o Libros de hechizos ");
            Console.WriteLine("Al tener tres posiciones cada uno tendra un personaje por cada una \n Por lo que las posiciones se distribuyen de la siguiente manera :");
            Console.WriteLine("");

            Character[] Jugador1 = new Character[3];
            Character[] Jugador2 = new Character[3];

            Wizard Harry = new Wizard("Harry");
            Elf Juan = new Elf ("Juan");
            Console.WriteLine(Harry.HealthPoints);
            Juan.Attack(Harry); // se
            Console.WriteLine(Harry.HealthPoints);
            
            Weapon Sword = new Weapon("Sword", 4);
            Harry.AddItem(Sword);
            Console.WriteLine(Harry.Damage);
        }

    }
}

/*
    Podemos hacer que cada persona q juega, osea 2 personas, 
    eleigan un maximo de de personajes, y que sea por tunos 
    el juego elegiendo en cada turno que personaje va a hacer 
    algo y que va a hacer 
*/

/*
    Gana un jugador cuando al otro se le derrotan todos sus personajes
*/

/*  
    Al momento de crear los personajes y ponerlos en la lista hay que 
    hacer esto para indicar bien el tipo que son 
*/

/*
    Capaz que podemos darles personajes al azar con objetos al azar y a
    traves de una interfaz hacer que se presenten junto a sus objetos
*/