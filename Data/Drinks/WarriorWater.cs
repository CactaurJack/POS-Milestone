using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using BleakwindBuffet.Data.Enums;
using Data;

namespace BleakwindBuffet.Data.Drinks
{
    public class WarriorWater : Drink, INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }


        public WarriorWater()
        {
        }

        private Size size = Size.Small;
        public override Size Size {
            get
            {
                return size;
            }

            set
            {
                size = value;
                OnPropertyChanged();
            }
        }
        public override uint Calories
        {
            get
            {
                return 0;
            }
        }

        public override double Price
        {
            get
            {
                return 0.0;
            }
        }

        private bool ice = true;
        public bool Ice {
            get
            {
                return ice;
            }

            set
            {
                ice = value;
                OnPropertyChanged();
            }
        }

        private bool lemon = false;
        public bool Lemon
        {
            get
            {
                return lemon;
            }

            set
            {
                lemon = value;
                OnPropertyChanged();
            }
        }

        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> specialInstructions = new List<string>();
                if (!Ice) { specialInstructions.Add("Hold ice"); }
                if (Lemon) { specialInstructions.Add("Add lemon"); }
                return specialInstructions;
            }
        }

        public override string ToString()
        {
            return Size + " Warrior Water";
        }
    }
}
