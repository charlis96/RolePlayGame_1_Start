using System;
using System.Collections;

namespace Roleplay
{
    /*
        En esta clase se guardan los items.
    */

    public class Inventory
    {
        public ArrayList Items { get; set; } = new ArrayList();
        public int ItemQuantity { get; set; } = 0;
        public static int MaxItems = 3;
    }
}