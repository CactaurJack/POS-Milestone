using BleakwindBuffet.Data.Drinks;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CandleHearthCoffeeCustom.xaml
    /// </summary>
    public partial class CandleHearthCoffeeCustom : Window
    {
        private CandlehearthCoffee Current;
        private int selection;
        public CandleHearthCoffeeCustom()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        public void orderIn(CandlehearthCoffee _input)
        {
            Current = _input;
            Ice.IsChecked = _input.Ice;
            RoomForCream.IsChecked = _input.RoomForCream;
            Decaf.IsChecked = _input.Decaf;
            Size.SelectedIndex = 0;
        }

        public CandlehearthCoffee returnItem()
        {
            SelectedSize();
            return Current;
        }


        private void Ice_Click(object sender, RoutedEventArgs e)
        {
            Current.Ice = (bool)Ice.IsChecked;
        }

        private void RoomForCream_Click(object sender, RoutedEventArgs e)
        {
            Current.RoomForCream = (bool)RoomForCream.IsChecked;
        }

        private void Decaf_Click(object sender, RoutedEventArgs e)
        {
            Current.Decaf = (bool)Decaf.IsChecked;
        }

        private void SelectedSize()
        {
            selection = Size.SelectedIndex;
            switch (selection)
            {
                case 0:
                    Current.Size = BleakwindBuffet.Data.Enums.Size.Small;
                    break;
                case 1:
                    Current.Size = BleakwindBuffet.Data.Enums.Size.Medium;
                    break;
                case 2:
                    Current.Size = BleakwindBuffet.Data.Enums.Size.Large;
                    break;
            }
        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;

            this.Hide();
        }

    }
}
