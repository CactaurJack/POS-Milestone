using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Data;

namespace BleakwindBuffet.Data.Entrees
{
    public class GardenOrcOmelette : Entree, INotifyPropertyChanged
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
        public override double Price => 4.57;

        /// <summary>
        /// Gets calories
        /// </summary>
        public override uint Calories => 404;


        /// <summary>
        /// Establishes special instructions
        /// Each setter calls OnPropertyChanged method to produce changed event on set command
        /// </summary>
        private bool broccoli = true;
        public bool Broccoli
        {
            get
            {
                return broccoli;
            }

            set
            {
                broccoli = value;
                OnPropertyChanged();
            }
        }

        private bool mushrooms = true;
        public bool Mushrooms
        {
            get
            {
                return mushrooms;
            }

            set
            {
                mushrooms = value;
                OnPropertyChanged();
            }
        }

        public bool tomato = true;
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

        private bool cheddar = true;
        public bool Cheddar
        {
            get
            {
                return cheddar;
            }

            set
            {
                cheddar = value;
                OnPropertyChanged();
            }
        }

        public override List<string> SpecialInstructions
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
