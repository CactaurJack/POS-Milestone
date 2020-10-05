using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
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
    /// Interaction logic for SailorSodaCustom.xaml
    /// </summary>
    public partial class SailorSodaCustom : Window
    {
        private SailorSoda Current;
        private int selection;
        public SailorSodaCustom()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        public void orderIn(SailorSoda _input)
        {
            Current = _input;
            Size.SelectedIndex = 0;
            Flavor.SelectedIndex = 0;
            Ice.IsChecked = _input.Ice;
        }

        public SailorSoda returnItem()
        {
            SelectedSize();
            SelectedFlavor();
            return Current;
        }

        private void Ice_Click(object sender, RoutedEventArgs e)
        {
            Current.Ice = (bool)Ice.IsChecked;
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

        private void SelectedFlavor()
        {
            selection = Flavor.SelectedIndex;
            switch (selection)
            {
                case 0:
                    Current.Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Cherry;
                    break;
                case 1:
                    Current.Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Blackberry;
                    break;
                case 2:
                    Current.Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Grapefruit;
                    break;
                case 3:
                    Current.Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Lemon;
                    break;
                case 4:
                    Current.Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Peach;
                    break;
                case 5:
                    Current.Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Watermelon;
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
