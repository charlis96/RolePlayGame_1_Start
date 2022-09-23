using System;

namespace Program
{
    public interface IStrike
    {       
        public string Name { get; set; }
        public int HealthPoints { get; set; }
        public int Defense { get; set; }
        public int Damage { get; set; }
        public int MagicPower { get; set; }
        public void Atack(Character Personaje);// Si hago que sea virtual en la clase character 
        public void InventoryCatalog();
        public void SpecialHability(Character Personaje);
        
    }
}