using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Data;

namespace BleakwindBuffet.Data.Entrees
{
    public class PhillyPoacher : Entree, INotifyPropertyChanged
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
        public override double Price => 7.23;

        /// <summary>
        /// Gets calories
        /// </summary>
        public override uint Calories => 784;


        /// <summary>
        /// Establishes special instructions
        /// Each setter calls OnPropertyChanged method to produce changed event on set command
        /// </summary>
        private bool sirloin = true;
        public bool Sirloin
        {
            get
            {
                return sirloin;
            }

            set
            {
                sirloin = value;
                OnPropertyChanged();
            }
        }

        private bool onion = true;
        public bool Onion
        {
            get
            {
                return onion;
            }

            set
            {
                onion = value;
                OnPropertyChanged();
            }
        }

        private bool roll = true;
        public bool Roll
        {
            get
            {
                return roll;
            }

            set
            {
                roll = value;
                OnPropertyChanged();
            }
        }

        public override List<string> SpecialInstructions
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
