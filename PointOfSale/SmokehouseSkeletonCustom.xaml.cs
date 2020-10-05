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
    /// Interaction logic for SmokehouseSkeletonCustom.xaml
    /// </summary>
    public partial class SmokehouseSkeletonCustom : Window
    {
        private SmokehouseSkeleton Current;
        public SmokehouseSkeletonCustom()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        public void orderItem(SmokehouseSkeleton _input)
        {
            Current = _input;
            SausageLink.IsChecked = Current.SausageLink;
            HashBrowns.IsChecked = Current.HashBrowns;
            Pancake.IsChecked = Current.Pancake;
        }

        public SmokehouseSkeleton returnOrder()
        {
            return Current;
        }


        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;

            this.Hide();
        }

        private void SausageLink_Click(object sender, RoutedEventArgs e)
        {
            Current.SausageLink = (bool)SausageLink.IsChecked;
        }

        private void HashBrowns_Click(object sender, RoutedEventArgs e)
        {
            Current.HashBrowns = (bool)HashBrowns.IsChecked;
        }

        private void Pancake_Click(object sender, RoutedEventArgs e)
        {
            Current.Pancake = (bool)Pancake.IsChecked;
        }

    }
}
