using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Data;

namespace BleakwindBuffet.Data.Entrees
{
    public class SmokehouseSkeleton : Entree, INotifyPropertyChanged
    {

        /// <summary>
        /// Establishes event handler to identify changes in boolean values
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        /// <summary>
        /// Gets burger price
        /// </summary>
        public override double Price => 5.62;

        /// <summary>
        /// Gets calories
        /// </summary>
        public override uint Calories => 602;



        /// <summary>
        /// Establishes special instructions
        /// Each setter calls OnPropertyChanged method to produce changed event on set command
        /// </summary>
        private bool sausageLink = true;
        public bool SausageLink
        {
            get
            {
                return sausageLink;
            }

            set
            {
                sausageLink = value;
                OnPropertyChanged();
            }
        }

        private bool egg = true;
        public bool Egg
        {
            get
            {
                return egg;
            }

            set
            {
                egg = value;
                OnPropertyChanged();
            }
        }

        private bool hashBrowns = true;
        public bool HashBrowns
        {
            get
            {
                return hashBrowns;
            }

            set
            {
                hashBrowns = value;
                OnPropertyChanged();
            }
        }

        private bool pancake = true;
        public bool Pancake
        {
            get
            {
                return pancake;
            }

            set
            {
                pancake = value;
                OnPropertyChanged();
            }
        }

        public override List<string> SpecialInstructions
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
