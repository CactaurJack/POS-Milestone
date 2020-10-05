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
    /// Interaction logic for ThalmorTripleCustom.xaml
    /// </summary>
    public partial class ThalmorTripleCustom : Window
    {
        private ThalmorTriple Current;
        public ThalmorTripleCustom()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        public void orderItem(ThalmorTriple _input)
        {
            Current = _input;
            Ketchup.IsChecked = Current.Ketchup;
            Bun.IsChecked = Current.Bun;
            Mustard.IsChecked = Current.Mustard;
            Pickle.IsChecked = Current.Pickle;
            Cheese.IsChecked = Current.Cheese;
            Tomato.IsChecked = Current.Tomato;
            Lettuce.IsChecked = Current.Lettuce;
            Mayo.IsChecked = Current.Mayo;
            Bacon.IsChecked = Current.Bacon;
            Egg.IsChecked = Current.Egg;
        }

        public ThalmorTriple returnOrder()
        {
            return Current;
        }


        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;

            this.Hide();
        }

        private void Ketchup_Click(object sender, RoutedEventArgs e)
        {
            Current.Ketchup = (bool)Ketchup.IsChecked;
        }

        private void Bun_Click(object sender, RoutedEventArgs e)
        {
            Current.Bun = (bool)Bun.IsChecked;
        }

        private void Mustard_Click(object sender, RoutedEventArgs e)
        {
            Current.Mustard = (bool)Mustard.IsChecked;
        }

        private void Pickle_Click(object sender, RoutedEventArgs e)
        {
            Current.Pickle = (bool)Pickle.IsChecked;
        }

        private void Cheese_Click(object sender, RoutedEventArgs e)
        {
            Current.Cheese = (bool)Cheese.IsChecked;
        }

        private void Tomato_Click(object sender, RoutedEventArgs e)
        {
            Current.Tomato = (bool)Tomato.IsChecked;
        }

        private void Lettuce_Click(object sender, RoutedEventArgs e)
        {
            Current.Lettuce = (bool)Lettuce.IsChecked;
        }

        private void Mayo_Click(object sender, RoutedEventArgs e)
        {
            Current.Mayo = (bool)Mayo.IsChecked;
        }

        private void Bacon_Click(object sender, RoutedEventArgs e)
        {
            Current.Bacon = (bool)Bacon.IsChecked;
        }

        private void Egg_Click(object sender, RoutedEventArgs e)
        {
            Current.Egg = (bool)Egg.IsChecked;
        }
    }
}
