using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public abstract class Side : IOrderItem
    {
        public double Price { get; }
        public uint Calories { get; }
        public List<string> SpecialInstructions { get; }
        public Size Size { get; }
    }
}
