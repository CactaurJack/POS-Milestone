using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public List<IOrderItem> orderList;
        public double tax;
        public OptionWindow optionWindow;
        public MainWindow()
        {
            InitializeComponent();
            TextBox textBox1 = new TextBox();
            orderList = new List<IOrderItem>();
            tax = .065;
            UserControl UControl;
            optionWindow = new OptionWindow();
            
            
        
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Orders_Populate(List<IOrderItem> _input)
        {
            double subtotal = 0.0;
            double total = 0.0;

            Orders.Items.Clear();
            for(int i = 0; i < _input.Count; i++)
            {
                subtotal += _input[i].Price;
                Orders.Items.Add(_input[i].ToString());
            }
            Orders.Items.Add("");
            Orders.Items.Add("");
            Orders.Items.Add("Sub Total = " + Math.Round(subtotal, 2));
            total = subtotal * tax;
            Orders.Items.Add("Tax = " + Math.Round(total, 2));
            Orders.Items.Add("Total = " + Math.Round(subtotal + total, 2));
        }

        private void Orders_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            optionWindow.Show();
        }

        private void BriarheartBurger_Button(object sender, RoutedEventArgs e)
        {
            
            orderList.Add(new BriarheartBurger());
            Orders_Populate(orderList);
        }

        private void DoubleDraugr_Button(object sender, RoutedEventArgs e)
        {
            orderList.Add(new DoubleDraugr());
            Orders_Populate(orderList);
        }

        private void ThalmorTriple_Button(object sender, RoutedEventArgs e)
        {
            orderList.Add(new ThalmorTriple());
            Orders_Populate(orderList);
        }

        private void GardenOrcOmelette_Button(object sender, RoutedEventArgs e)
        {
            orderList.Add(new GardenOrcOmelette());
            Orders_Populate(orderList);
        }

        private void PhillyPoacher_Button(object sender, RoutedEventArgs e)
        {
            orderList.Add(new PhillyPoacher());
            Orders_Populate(orderList);
        }

        private void SmokehouseSkeleton_Button(object sender, RoutedEventArgs e)
        {
            orderList.Add(new SmokehouseSkeleton());
            Orders_Populate(orderList);
        }

        private void ThugsTBone_Button(object sender, RoutedEventArgs e)
        {
            orderList.Add(new ThugsTBone());
            Orders_Populate(orderList);
        }

        private void DragonbornWaffleFries_Button(object sender, RoutedEventArgs e)
        {
            orderList.Add(new DragonbornWaffleFries());
            Orders_Populate(orderList);
        }

        private void FriedMiraak_Button(object sender, RoutedEventArgs e)
        {
            orderList.Add(new FriedMiraak());
            Orders_Populate(orderList);
        }


        private void VokunSalad_Button(object sender, RoutedEventArgs e)
        {
            orderList.Add(new VokunSalad());
            Orders_Populate(orderList);
        }

        private void MadOtarGrits_Button(object sender, RoutedEventArgs e)
        {
            orderList.Add(new MadOtarGrits());
            Orders_Populate(orderList);
        }

        private void WarriorWater_Button(object sender, RoutedEventArgs e)
        {
            orderList.Add(new WarriorWater());
            Orders_Populate(orderList);
        }

        private void SailorSoda_Button(object sender, RoutedEventArgs e)
        {
            orderList.Add(new SailorSoda());
            Orders_Populate(orderList);
        }

        private void MarkarthMilk_Button(object sender, RoutedEventArgs e)
        {
            orderList.Add(new MarkarthMilk());
            Orders_Populate(orderList);
        }

        private void CandlehearthCoffee_Button(object sender, RoutedEventArgs e)
        {
            orderList.Add(new CandlehearthCoffee());
            Orders_Populate(orderList);
        }

        private void AretinoAppleJuice_Button(object sender, RoutedEventArgs e)
        {
            orderList.Add(new AretinoAppleJuice());
            Orders_Populate(orderList);
        }
    }

    public class UserControl : System.Windows.Controls.ContentControl
    {
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Orders_PopulateList(List<string> _input, object sender)
        {
            for(int i = 0; i < _input.Count; i++)
            {
                
            }
        }

        private void Orders_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
