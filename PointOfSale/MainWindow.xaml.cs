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
        public TestWindow testWindow;
        public DoubleDraugrCustom doubleDraugrCustom;
        public ThalmorTripleCustom thalmorTripleCustom;
        public GardenOrcCustom gardenOrcOmelette;
        public PhillyCustom phillyPoacherCustom;
        public SmokehouseSkeletonCustom smokehouseSkeletonCustom;
        public SidesCustom sideCustom;
        public SailorSodaCustom sailorSodaCustom;
        public AretinoAppleJuiceCustom aretinoAppleJuiceCustom;
        public MarkarthMilkCustom markarthMilkCustom;
        public WarriorWaterCustom warriorWaterCustom;
        public CandleHearthCoffeeCustom candleHearthCoffeeCustom;
        public MainWindow()
        {
            InitializeComponent();
            TextBox textBox1 = new TextBox();
            orderList = new List<IOrderItem>();
            tax = .065;
            UserControl UControl;
            optionWindow = new OptionWindow();
            testWindow = new TestWindow();
            doubleDraugrCustom = new DoubleDraugrCustom();
            thalmorTripleCustom = new ThalmorTripleCustom();
            gardenOrcOmelette = new GardenOrcCustom();
            phillyPoacherCustom = new PhillyCustom();
            smokehouseSkeletonCustom = new SmokehouseSkeletonCustom();
            sideCustom = new SidesCustom();
            sailorSodaCustom = new SailorSodaCustom();
            aretinoAppleJuiceCustom = new AretinoAppleJuiceCustom();
            markarthMilkCustom = new MarkarthMilkCustom();
            warriorWaterCustom = new WarriorWaterCustom();
            candleHearthCoffeeCustom = new CandleHearthCoffeeCustom();

            
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
            optionWindow.AssignItem(orderList[Orders.SelectedIndex]);
            //testWindow.orderItem(orderList[Orders.SelectedIndex]));
            //optionWindow.Show();
        }

        public void tempIOrder(IOrderItem _input)
        {
            orderList.Add(_input);
        }

        private void BriarheartBurger_Button(object sender, RoutedEventArgs e)
        {
            BriarheartBurger entree = new BriarheartBurger();
            testWindow.orderItem(entree);
            testWindow.ShowDialog();
            entree = testWindow.returnOrder();
            orderList.Add(entree);
            Orders_Populate(orderList);
        }

        private void DoubleDraugr_Button(object sender, RoutedEventArgs e)
        {
            DoubleDraugr entree = new DoubleDraugr();
            doubleDraugrCustom.orderItem(entree);
            doubleDraugrCustom.ShowDialog();
            entree = doubleDraugrCustom.returnOrder();
            orderList.Add(entree);
            Orders_Populate(orderList);
        }

        private void ThalmorTriple_Button(object sender, RoutedEventArgs e)
        {
            ThalmorTriple entree = new ThalmorTriple();
            thalmorTripleCustom.orderItem(entree);
            thalmorTripleCustom.ShowDialog();
            entree = thalmorTripleCustom.returnOrder();
            orderList.Add(entree);
            Orders_Populate(orderList);
        }

        private void GardenOrcOmelette_Button(object sender, RoutedEventArgs e)
        {
            GardenOrcOmelette entree = new GardenOrcOmelette();
            gardenOrcOmelette.orderItem(entree);
            gardenOrcOmelette.ShowDialog();
            entree = gardenOrcOmelette.returnOrder();
            orderList.Add(entree);
            Orders_Populate(orderList);
        }

        private void PhillyPoacher_Button(object sender, RoutedEventArgs e)
        {
            PhillyPoacher entree = new PhillyPoacher();
            phillyPoacherCustom.orderItem(entree);
            phillyPoacherCustom.ShowDialog();
            entree = phillyPoacherCustom.returnOrder();
            orderList.Add(entree);
            Orders_Populate(orderList);
        }

        private void SmokehouseSkeleton_Button(object sender, RoutedEventArgs e)
        {
            SmokehouseSkeleton entree = new SmokehouseSkeleton();
            smokehouseSkeletonCustom.orderItem(entree);
            smokehouseSkeletonCustom.ShowDialog();
            entree = smokehouseSkeletonCustom.returnOrder();
            orderList.Add(entree);
            Orders_Populate(orderList);
        }

        private void ThugsTBone_Button(object sender, RoutedEventArgs e)
        {
            orderList.Add(new ThugsTBone());
            Orders_Populate(orderList);
        }

        private void DragonbornWaffleFries_Button(object sender, RoutedEventArgs e)
        {
            sideCustom.orderIn(new DragonbornWaffleFries());
            sideCustom.ShowDialog();
            orderList.Add(sideCustom.returnItem());
            Orders_Populate(orderList);
        }

        private void FriedMiraak_Button(object sender, RoutedEventArgs e)
        {
            sideCustom.orderIn(new FriedMiraak());
            sideCustom.ShowDialog();
            orderList.Add(sideCustom.returnItem());
            Orders_Populate(orderList);
        }

        private void VokunSalad_Button(object sender, RoutedEventArgs e)
        {
            sideCustom.orderIn(new VokunSalad());
            sideCustom.ShowDialog();
            orderList.Add(sideCustom.returnItem());
            Orders_Populate(orderList);
        }

        private void MadOtarGrits_Button(object sender, RoutedEventArgs e)
        {
            sideCustom.orderIn(new MadOtarGrits());
            sideCustom.ShowDialog();
            orderList.Add(sideCustom.returnItem());
            Orders_Populate(orderList);
        }

        private void WarriorWater_Button(object sender, RoutedEventArgs e)
        {
            warriorWaterCustom.orderIn(new WarriorWater());
            warriorWaterCustom.ShowDialog();
            orderList.Add(warriorWaterCustom.returnItem());
            Orders_Populate(orderList);
        }

        private void SailorSoda_Button(object sender, RoutedEventArgs e)
        {
            sailorSodaCustom.orderIn(new SailorSoda());
            sailorSodaCustom.ShowDialog();
            orderList.Add(sailorSodaCustom.returnItem());
            Orders_Populate(orderList);
        }

        private void MarkarthMilk_Button(object sender, RoutedEventArgs e)
        {
            markarthMilkCustom.orderIn(new MarkarthMilk());
            markarthMilkCustom.ShowDialog();
            orderList.Add(markarthMilkCustom.returnItem());
            Orders_Populate(orderList);
        }

        private void CandlehearthCoffee_Button(object sender, RoutedEventArgs e)
        {
            candleHearthCoffeeCustom.orderIn(new CandlehearthCoffee());
            candleHearthCoffeeCustom.ShowDialog();
            orderList.Add(candleHearthCoffeeCustom.returnItem());
            Orders_Populate(orderList);
        }

        private void AretinoAppleJuice_Button(object sender, RoutedEventArgs e)
        {
            aretinoAppleJuiceCustom.orderIn(new AretinoAppleJuice());
            aretinoAppleJuiceCustom.ShowDialog();
            orderList.Add(aretinoAppleJuiceCustom.returnItem());
            Orders_Populate(orderList);
        }

        private void Clear_Button(object sender, RoutedEventArgs e)
        {
            orderList.RemoveAt(orderList.Count - 1);
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
