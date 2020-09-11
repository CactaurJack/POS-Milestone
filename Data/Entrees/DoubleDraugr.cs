using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class DoubleDraugr
    {
        /// <summary>
        /// Gets burger price
        /// </summary>
        public double Price => 7.32;

        /// <summary>
        /// Gets calories
        /// </summary>
        public uint Calories => 843;

        public bool Ketchup { get; set; } = true;

        public bool Bun { get; set; } = true;

        public bool Mustard { get; set; } = true;

        public bool Pickle { get; set; } = true;

        public bool Cheese { get; set; } = true;

        public bool Tomato { get; set; } = true;

        public bool Lettuce { get; set; } = true;

        public bool Mayo { get; set; } = true;

        public List<string> SpecialInstructions
        {
            get
            {
                List<string> specialInstructions = new List<string>();
                if (!Bun) { specialInstructions.Add("Hold bun"); };
                if (!Ketchup) { specialInstructions.Add("Hold ketchup"); };
                if (!Mustard) { specialInstructions.Add("Hold mustard"); };
                if (!Pickle) { specialInstructions.Add("Hold pickle"); };
                if (!Cheese) { specialInstructions.Add("Hold cheese"); };
                if (!Tomato) { specialInstructions.Add("Hold tomato"); };
                if (!Lettuce) { specialInstructions.Add("Hold lettuce"); };
                if (!Mayo) { specialInstructions.Add("Hold mayo"); };
                return specialInstructions;
            }
        }

        public override string ToString()
        {
            return "Double Draugr";
        }
    }
}
