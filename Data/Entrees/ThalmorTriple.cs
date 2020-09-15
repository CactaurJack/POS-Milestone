using System;
using System.Collections.Generic;
using System.Text;
using Data;

namespace BleakwindBuffet.Data.Entrees
{
    public class ThalmorTriple : Entree
    {
        /// <summary>
        /// Gets burger price
        /// </summary>
        public double Price => 8.32;

        /// <summary>
        /// Gets calories
        /// </summary>
        public uint Calories => 943;

        public bool Ketchup { get; set; } = true;

        public bool Bun { get; set; } = true;

        public bool Mustard { get; set; } = true;

        public bool Pickle { get; set; } = true;

        public bool Cheese { get; set; } = true;

        public bool Tomato { get; set; } = true;

        public bool Lettuce { get; set; } = true;

        public bool Mayo { get; set; } = true;

        public bool Bacon { get; set; } = true;

        public bool Egg { get; set; } = true;

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
                if (!Bacon) { specialInstructions.Add("Hold bacon"); };
                if (!Egg) { specialInstructions.Add("Hold egg"); };
                return specialInstructions;
            }
        }

        public override string ToString()
        {
            return "Thalmor Triple";
        }
    }
}
