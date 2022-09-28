namespace Roleplay
{
    /*
<<<<<<< HEAD
        
=======
        Esta clase se creó con el fin de crear los hechizos.
>>>>>>> 1a5e6ba2830ddeb9d3ee97dc0a1b7fc433d57b4f
    */
    public class Spell
    {
        public string Name { get; set; }
        public int Damage { get; set; }
        public int Defense { get; set; }
        public int TotalHealthPoints { get; set; }
        public int MagicPower { get; set; }
        public Spell(string name, int damage, int defense, int totalHealthPoints, int magicPower)
        {
            this.Name = name;
            this.Damage = damage;
            this.Defense = defense;
            this.TotalHealthPoints = totalHealthPoints;
            this.MagicPower = magicPower;
        }
    }
}