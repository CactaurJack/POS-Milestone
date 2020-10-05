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
    /// Interaction logic for GardenOrcCustom.xaml
    /// </summary>
    public partial class GardenOrcCustom : Window
    {
        private GardenOrcOmelette Current;
        public GardenOrcCustom()
        {
            InitializeComponent();
        }

        public void orderItem(GardenOrcOmelette _input)
        {
            Current = _input;
            Broccoli.IsChecked = Current.Broccoli;
            Mushrooms.IsChecked = Current.Mushrooms;
            Tomato.IsChecked = Current.Tomato;
            Cheddar.IsChecked = Current.Cheddar;

        }

        public GardenOrcOmelette returnOrder()
        {
            return Current;
        }


        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;

            this.Hide();
        }

        private void Broccoli_Click(object sender, RoutedEventArgs e)
        {
            Current.Broccoli = (bool)Broccoli.IsChecked;
        }

        private void Mushrooms_Click(object sender, RoutedEventArgs e)
        {
            Current.Mushrooms = (bool)Mushrooms.IsChecked;
        }

        private void Tomato_Click(object sender, RoutedEventArgs e)
        {
            Current.Tomato = (bool)Tomato.IsChecked;
        }

        private void Cheddar_Click(object sender, RoutedEventArgs e)
        {
            Current.Cheddar = (bool)Cheddar.IsChecked;
        }

    }
}
