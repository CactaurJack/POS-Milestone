using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Data;

namespace BleakwindBuffet.Data.Entrees
{
    public class ThalmorTriple : Entree, INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        /// <summary>
        /// Gets burger price
        /// </summary>
        public override double Price => 8.32;

        /// <summary>
        /// Gets calories
        /// </summary>
        public override uint Calories => 943;

        /// <summary>
        /// Establishes special instructions
        /// Each setter calls OnPropertyChanged method to produce changed event on set command
        /// </summary>
        private bool ketchup = true;
        public bool Ketchup
        {
            get
            {
                return ketchup; ;
            }

            set
            {
                ketchup = value;
                OnPropertyChanged();
            }
        }

        private bool bun = true;
        public bool Bun
        {
            get
            {
                return bun;
            }

            set
            {
                bun = value;
                OnPropertyChanged();
            }
        }

        private bool mustard = true;
        public bool Mustard
        {
            get
            {
                return mustard;
            }

            set
            {
                mustard = value;
                OnPropertyChanged();
            }
        }

        private bool pickle = true;
        public bool Pickle
        {
            get
            {
                return pickle;
            }

            set
            {
                pickle = value;
                OnPropertyChanged();
            }
        }

        private bool cheese = true;
        public bool Cheese
        {
            get
            {
                return cheese;
            }

            set
            {
                cheese = value;
                OnPropertyChanged();
            }
        }

        private bool tomato = true;
        public bool Tomato
        {
            get
            {
                return tomato;
            }

            set
            {
                tomato = value;
                OnPropertyChanged();
            }
        }

        private bool lettuce = true;
        public bool Lettuce
        {
            get
            {
                return lettuce;
            }

            set
            {
                lettuce = value;
                OnPropertyChanged();
            }
        }

        private bool mayo = true;
        public bool Mayo
        {
            get
            {
                return mayo;
            }

            set
            {
                mayo = value;
                OnPropertyChanged();
            }
        }

        private bool bacon = true;
        public bool Bacon
        {
            get
            {
                return bacon;
            }

            set
            {
                bacon = value;
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

        public override List<string> SpecialInstructions
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
