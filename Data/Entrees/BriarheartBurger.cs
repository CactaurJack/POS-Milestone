using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Data;

namespace BleakwindBuffet.Data.Entrees
{

    public class BriarheartBurger : Entree, INotifyPropertyChanged
    {
        /// <summary>
        /// Establishes event handler to identify changes in boolean values
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        public override double Price => 6.32;

        /// <summary>
        /// Gets calories
        /// </summary>
        public override uint Calories => 732;

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


        public override List<string> SpecialInstructions
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
