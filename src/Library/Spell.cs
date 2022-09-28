namespace Roleplay
{
    /*
        Esta clase se creó con el fin de crear los hechizos.
        luego estos hechizos se agregaran a una lista en la clase spellbook

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