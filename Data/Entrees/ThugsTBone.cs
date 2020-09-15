using System;
using System.Collections.Generic;
using System.Text;
using Data;

namespace BleakwindBuffet.Data.Entrees
{
    public class ThugsTBone : Entree
    {
        /// <summary>
        /// Gets burger price
        /// </summary>
        public double Price => 6.44;

        /// <summary>
        /// Gets calories
        /// </summary>
        public uint Calories => 982;


        public List<string> SpecialInstructions
        {
            get
            {
                List<string> specialInstructions = new List<string>();
                return specialInstructions;
            }
        }

        public override string ToString()
        {
            return "Thugs T-Bone";
        }
    }
}
