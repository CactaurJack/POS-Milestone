using BleakwindBuffet.Data.Entrees;
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
    /// Interaction logic for PhillyCustom.xaml
    /// </summary>
    public partial class PhillyCustom : Window
    {
        private PhillyPoacher Current;
        public PhillyCustom()
        {
            InitializeComponent();
            this.DataContext = this;
        }


        public void orderItem(PhillyPoacher _input)
        {
            Current = _input;
            Sirloin.IsChecked = Current.Sirloin;
            Onion.IsChecked = Current.Onion;
            Roll.IsChecked = Current.Roll;
        }

        public PhillyPoacher returnOrder()
        {
            return Current;
        }


        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;

            this.Hide();
        }

        private void Sirloin_Click(object sender, RoutedEventArgs e)
        {
            Current.Sirloin = (bool)Sirloin.IsChecked;
        }

        private void Onion_Click(object sender, RoutedEventArgs e)
        {
            Current.Onion = (bool)Onion.IsChecked;
        }

        private void Roll_Click(object sender, RoutedEventArgs e)
        {
            Current.Roll = (bool)Roll.IsChecked;
        }
    }
}
