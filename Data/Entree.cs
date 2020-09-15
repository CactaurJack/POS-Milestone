using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public abstract class Entree : IOrderItem
    {
        public double Price { get; }
        public uint Calories { get; }
        public List<string> SpecialInstructions {get; } 
    }

    
}
