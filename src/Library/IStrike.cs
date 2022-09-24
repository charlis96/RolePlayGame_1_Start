using System;

namespace Roleplay
{
    public interface IStrike
    {       
        public string Name { get; set; }
        public int HealthPoints { get; set; }
        public int Defense { get; set; }
        public int Damage { get; set; }
        public int MagicPower { get; set; }
        

        public void Attack(Character Personaje); 
        public void SpecialHability(Character Personaje);
        
    }
}