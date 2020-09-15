using System;
using System.Collections.Generic;
using System.Text;
using Data;

namespace BleakwindBuffet.Data.Entrees
{
    public class BriarheartBurger : Entree
    {
        /// <summary>
        /// Gets burger price
        /// </summary>
        
        public double Price => 6.32;

        /// <summary>
        /// Gets calories
        /// </summary>
        public uint Calories => 732;

        public bool Ketchup { get; set; } = true;

        public bool Bun { get; set; } = true;

        public bool Mustard { get; set; } = true;

        public bool Pickle { get; set; } = true;

        public bool Cheese { get; set; } = true;
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> specialInstructions =  new List<string>();
                if (!Bun) { specialInstructions.Add("Hold bun"); };
                if (!Ketchup) { specialInstructions.Add("Hold ketchup"); };
                if (!Mustard) { specialInstructions.Add("Hold mustard"); };
                if (!Pickle) { specialInstructions.Add("Hold pickle"); };
                if (!Cheese) { specialInstructions.Add("Hold cheese"); };
                return specialInstructions;
            }
        }

        public override string ToString()
        {
            return "Briarheart Burger";
        }

    }
}
