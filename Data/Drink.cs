using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Data
{

        public abstract class Drink : IOrderItem
        {
            public virtual double Price { get; }
            public virtual uint Calories { get; }
            public virtual List<string> SpecialInstructions { get; }
            public virtual Size Size { get; set; }
        }

}

