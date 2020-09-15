using System;
using System.Collections.Generic;
using System.Text;
using Data;

namespace BleakwindBuffet.Data.Entrees
{
    public class SmokehouseSkeleton : Entree
    {
        /// <summary>
        /// Gets burger price
        /// </summary>
        public double Price => 5.62;

        /// <summary>
        /// Gets calories
        /// </summary>
        public uint Calories => 602;

        public bool SausageLink { get; set; } = true;

        public bool Egg { get; set; } = true;

        public bool HashBrowns { get; set; } = true;

        public bool Pancake { get; set; } = true;

        public List<string> SpecialInstructions
        {
            get
            {
                List<string> specialInstructions = new List<string>();
                if (!SausageLink) { specialInstructions.Add("Hold sausage"); };
                if (!Egg) { specialInstructions.Add("Hold eggs"); };
                if (!HashBrowns) { specialInstructions.Add("Hold hashbrowns"); };
                if (!Pancake) { specialInstructions.Add("Hold pancakes"); };
                return specialInstructions;
            }
        }

        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}
