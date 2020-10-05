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
    /// Interaction logic for MarkarthMilkCustom.xaml
    /// </summary>
    public partial class MarkarthMilkCustom : Window
    {
        private MarkarthMilk Current;
        private int selection;
        public MarkarthMilkCustom()
        {
            InitializeComponent();
        }

        public void orderIn(MarkarthMilk _input)
        {
            Current = _input;
            Size.SelectedIndex = 0;
            Ice.IsChecked = _input.Ice;
        }

        public MarkarthMilk returnItem()
        {
            SelectedSize();
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

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;

            this.Hide();
        }
    }
}
