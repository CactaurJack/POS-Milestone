using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    public class CandlehearthCoffee
    {
        public Size Size { get; set; } = Size.Small;
        public uint Calories
        {
            get
            {
                if (Size == Size.Small) return 7;
                if (Size == Size.Medium) return 10;
                if (Size == Size.Large) return 20;
                throw new NotImplementedException($"Unknown size of {Size}");
            }
        }

        public double Price
        {
            get
            {
                if (Size == Size.Small) return 0.75;
                if (Size == Size.Medium) return 1.25;
                if (Size == Size.Large) return 1.75;
                throw new NotImplementedException($"Unknown size of {Size}");
            }
        }

        public bool Ice { get; set; } = false;
        public bool RoomForCream { get; set; } = false;
        public bool Decaf { get; set; } = false;

        public List<string> SpecialInstructions
        {
            get
            {
                List<string> specialInstructions = new List<string>();
                if (Ice) { specialInstructions.Add("Add ice"); }
                if (RoomForCream) { specialInstructions.Add("Add cream"); }
                if (Decaf) { specialInstructions.Add("Decaf"); }
                return specialInstructions;
            }
        }

        public override string ToString()
        {
            if (Decaf)
            {
                return Size + " Decaf Candlehearth Coffee";
            }
            else
            {
                return Size + " Candlehearth Coffee";
            }
        }
    }
}
