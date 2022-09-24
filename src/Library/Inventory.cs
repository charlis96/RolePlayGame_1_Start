using System;
using System.Collections;

namespace Roleplay
{
    public class Inventory
    {
        public ArrayList Items { get; set; }
        public int Damage { get; set; } = 0;
        public int Defense { get; set; } = 0;
        public int TotalHealthPoints { get; set; } = 0;
        public int MagicPower { get; set; } = 0;
        public int ItemQuantity { get; set; } = 0;
        public static int MaxItems = 3;
    }
}