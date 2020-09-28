using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using Data;

namespace BleakwindBuffet.Data.Drinks
{
    public class WarriorWater : Drink
    {
        public override Size Size { get; set; } = Size.Small;
        public override uint Calories
        {
            get
            {
                return 0;
            }
        }

        public override double Price
        {
            get
            {
                return 0.0;
            }
        }

        public bool Ice { get; set; } = true;
        public bool Lemon { get; set; } = false;

        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> specialInstructions = new List<string>();
                if (!Ice) { specialInstructions.Add("Hold ice"); }
                if (Lemon) { specialInstructions.Add("Add lemon"); }
                return specialInstructions;
            }
        }

        public override string ToString()
        {
            return Size + " Warrior Water";
        }
    }
}
