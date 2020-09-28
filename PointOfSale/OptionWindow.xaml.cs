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
    /// Interaction logic for OptionWindow.xaml
    /// </summary>
    public partial class OptionWindow : Window
    {
        public OptionWindow()
        {
            InitializeComponent();
            SpecialInstructionsMenu.Items.Add(true);
            SpecialInstructionsMenu.Items.Add(true);
            SpecialInstructionsMenu.Items.Add(true);
            SpecialInstructionsMenu.Items.Add(true);
            SpecialInstructionsMenu.Items.Add(true);
            SpecialInstructionsMenu.Items.Add(true);
            SpecialInstructionsMenu.Items.Add(true);

        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void SpecialInstructionsMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
