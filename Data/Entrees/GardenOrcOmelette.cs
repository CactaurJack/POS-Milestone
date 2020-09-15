using System;
using System.Collections.Generic;
using System.Text;
using Data;

namespace BleakwindBuffet.Data.Entrees
{
    public class GardenOrcOmelette : Entree
    {
        /// <summary>
        /// Gets burger price
        /// </summary>
        public double Price => 4.57;

        /// <summary>
        /// Gets calories
        /// </summary>
        public uint Calories => 404;

        public bool Broccoli { get; set; } = true;

        public bool Mushrooms { get; set; } = true;

        public bool Tomato { get; set; } = true;

        public bool Cheddar { get; set; } = true;

        public List<string> SpecialInstructions
        {
            get
            {
                List<string> specialInstructions = new List<string>();
                if (!Broccoli) { specialInstructions.Add("Hold broccoli"); };
                if (!Mushrooms) { specialInstructions.Add("Hold mushrooms"); };
                if (!Tomato) { specialInstructions.Add("Hold tomato"); };
                if (!Cheddar) { specialInstructions.Add("Hold cheddar"); };
                return specialInstructions;
            }
        }

        public override string ToString()
        {
            return "Garden Orc Omelette";
        }
    }
}
