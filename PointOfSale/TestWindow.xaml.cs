using BleakwindBuffet.Data.Entrees;
using Data;
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
using System.Runtime;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for TestWindow.xaml
    /// </summary>
    public partial class TestWindow : Window
    {
        private BriarheartBurger Current;
        public TestWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        public void orderItem(BriarheartBurger _input)
        {        
                Current = _input;
                Ketchup.IsChecked = _input.Ketchup;
                Bun.IsChecked = _input.Bun;
                Mustard.IsChecked = _input.Mustard;
                Pickle.IsChecked = _input.Pickle;
                Cheese.IsChecked = _input.Cheese;
                Test.IsEnabled = false;       
        }

        public BriarheartBurger returnOrder()
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
    }
}
