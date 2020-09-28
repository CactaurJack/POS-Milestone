using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public abstract class Entree : IOrderItem
    {
        public virtual double Price { get; }
        public virtual uint Calories { get; }
        public virtual List<string> SpecialInstructions {get; } 
    }

    
}
