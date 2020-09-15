using System;
using System.Collections.Generic;
using System.Text;
using Data;

namespace BleakwindBuffet.Data.Entrees
{
    public class PhillyPoacher : Entree
    {
        /// <summary>
        /// Gets burger price
        /// </summary>
        public double Price => 7.23;

        /// <summary>
        /// Gets calories
        /// </summary>
        public uint Calories => 784;

        public bool Sirloin { get; set; } = true;

        public bool Onion { get; set; } = true;

        public bool Roll { get; set; } = true;

        public List<string> SpecialInstructions
        {
            get
            {
                List<string> specialInstructions = new List<string>();
                if (!Sirloin) { specialInstructions.Add("Hold sirloin"); };
                if (!Onion) { specialInstructions.Add("Hold onions"); };
                if (!Roll) { specialInstructions.Add("Hold roll"); };
                return specialInstructions;
            }
        }

        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}
