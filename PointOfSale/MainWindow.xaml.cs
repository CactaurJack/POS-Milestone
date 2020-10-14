using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        /// <summary>
        /// Handles declarations of global variables and custimization screens
        /// </summary>
        public List<IOrderItem> orderList;
        public List<Order> ListOfOrders;
        private List<int> OrderIndex;
        public Order currentOrder;
        public int orderNumber = 1;
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
            ListOfOrders = new List<Order>();
            currentOrder = new Order(orderNumber);
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
            OrderIndex = new List<int>();
            OrderIndex.Add(0);

            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }


        /// <summary>
        /// Previous implimentation of display handling of the orders list
        /// replaced due to lack of needed functionality
        /// </summary>
        /// <param name="_input"></param>
        private void Orders_Populate(List<IOrderItem> _input)
        {
            /*double subtotal = 0.0;
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

            Orders.Items.Add("Order Number Test # " + currentOrder.orderNumber);
            Orders.Items.Add("Subtotal Test = " + currentOrder.Subtotal);
            Orders.Items.Add("Tax Test = " + currentOrder.Tax);
            Orders.Items.Add("Total Test = " + currentOrder.Total);*/

            /*foreach (Order x in ListOfOrders )
            {
                Orders.Items.Add("Order Number Test # " + x.orderNumber);
                Orders.Items.Add("Subtotal Test = " + x.Subtotal);
                Orders.Items.Add("Tax Test = " + x.Tax);
                Orders.Items.Add("Total Test = " + x.Total);
            }*/
        }

        /// <summary>
        /// Method for formatting output from completed order
        /// Called only by Order_Button method
        /// Updates list of the number of Items in Orders for formatting purposes
        /// </summary>
        private void Orders_Populate()
        {
                Orders.Items.Add("");
                Orders.Items.Add("Order Number # " + currentOrder.orderNumber);
                Orders.Items.Add("Total Calories = " + currentOrder.Calories);
                Orders.Items.Add("Subtotal = " + currentOrder.Subtotal);
                Orders.Items.Add("Tax = " + currentOrder.Tax);
                Orders.Items.Add("Total = " + currentOrder.Total);
                Orders.Items.Add("");
                OrderIndex.Add(Orders.Items.Count - 1);
                
                //Adds the Data.Order data directly into the binding on the ListBox
                //causes oddities in formating and abberant behavior disabled for now
                //Orders.Items.Add(currentOrder);
        }


        /// <summary>
        /// Allows notification that the selected item in ListBox has changed
        /// not currently used, left in for possible future functionality
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Orders_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int test = Orders.SelectedIndex;
            object testing = Orders.SelectedItem;
            //optionWindow.AssignItem(orderList[Orders.SelectedIndex]);
            //testWindow.orderItem(orderList[Orders.SelectedIndex]));
            //optionWindow.Show();
        }


        /// <summary>
        /// Begins button handling section
        /// Each method handles the custimization window handling and object generation
        /// as well as sending the ordered item, along with it's custimization to the currentOrder
        /// variable to be added to the master order list on Order_Button press
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BriarheartBurger_Button(object sender, RoutedEventArgs e)
        {
            BriarheartBurger entree = new BriarheartBurger();
            testWindow.orderItem(entree);
            testWindow.ShowDialog();
            entree = testWindow.returnOrder();
            orderList.Add(entree);

            Orders.Items.Add(entree.ToString());
            for(int i = 0; i < entree.SpecialInstructions.Count; i++)
            {
                Orders.Items.Add(" - " + entree.SpecialInstructions[i]);
            }

            //Orders.Items.Add(currentOrder);

            currentOrder.Add(entree);

            //Orders_Populate(orderList);
        }

        private void DoubleDraugr_Button(object sender, RoutedEventArgs e)
        {
            DoubleDraugr entree = new DoubleDraugr();
            doubleDraugrCustom.orderItem(entree);
            doubleDraugrCustom.ShowDialog();
            entree = doubleDraugrCustom.returnOrder();
            orderList.Add(entree);

            Orders.Items.Add(entree.ToString());
            for (int i = 0; i < entree.SpecialInstructions.Count; i++)
            {
                Orders.Items.Add(" - " + entree.SpecialInstructions[i]);
            }

            currentOrder.Add(entree);
        }

        private void ThalmorTriple_Button(object sender, RoutedEventArgs e)
        {
            ThalmorTriple entree = new ThalmorTriple();
            thalmorTripleCustom.orderItem(entree);
            thalmorTripleCustom.ShowDialog();
            entree = thalmorTripleCustom.returnOrder();
            orderList.Add(entree);

            Orders.Items.Add(entree.ToString());
            for (int i = 0; i < entree.SpecialInstructions.Count; i++)
            {
                Orders.Items.Add(" - " + entree.SpecialInstructions[i]);
            }

            currentOrder.Add(entree);
        }

        private void GardenOrcOmelette_Button(object sender, RoutedEventArgs e)
        {
            GardenOrcOmelette entree = new GardenOrcOmelette();
            gardenOrcOmelette.orderItem(entree);
            gardenOrcOmelette.ShowDialog();
            entree = gardenOrcOmelette.returnOrder();
            orderList.Add(entree);

            Orders.Items.Add(entree.ToString());
            for (int i = 0; i < entree.SpecialInstructions.Count; i++)
            {
                Orders.Items.Add(" - " + entree.SpecialInstructions[i]);
            }

            currentOrder.Add(entree);
        }

        private void PhillyPoacher_Button(object sender, RoutedEventArgs e)
        {
            PhillyPoacher entree = new PhillyPoacher();
            phillyPoacherCustom.orderItem(entree);
            phillyPoacherCustom.ShowDialog();
            entree = phillyPoacherCustom.returnOrder();
            orderList.Add(entree);

            Orders.Items.Add(entree.ToString());
            for (int i = 0; i < entree.SpecialInstructions.Count; i++)
            {
                Orders.Items.Add(" - " + entree.SpecialInstructions[i]);
            }

            currentOrder.Add(entree);
        }

        private void SmokehouseSkeleton_Button(object sender, RoutedEventArgs e)
        {
            SmokehouseSkeleton entree = new SmokehouseSkeleton();
            smokehouseSkeletonCustom.orderItem(entree);
            smokehouseSkeletonCustom.ShowDialog();
            entree = smokehouseSkeletonCustom.returnOrder();
            orderList.Add(entree);

            Orders.Items.Add(entree.ToString());
            for (int i = 0; i < entree.SpecialInstructions.Count; i++)
            {
                Orders.Items.Add(" - " + entree.SpecialInstructions[i]);
            }

            currentOrder.Add(entree);
        }

        private void ThugsTBone_Button(object sender, RoutedEventArgs e)
        {
            orderList.Add(new ThugsTBone());

            ThugsTBone entree = new ThugsTBone();
            Orders.Items.Add(entree.ToString());
            for (int i = 0; i < entree.SpecialInstructions.Count; i++)
            {
                Orders.Items.Add(" - " + entree.SpecialInstructions[i]);
            }

            currentOrder.Add(entree);
        }

        private void DragonbornWaffleFries_Button(object sender, RoutedEventArgs e)
        {
            sideCustom.orderIn(new DragonbornWaffleFries());
            sideCustom.ShowDialog();
            orderList.Add(sideCustom.returnItem());

            Orders.Items.Add(sideCustom.returnItem().ToString());
            for (int i = 0; i < sideCustom.returnItem().SpecialInstructions.Count; i++)
            {
                Orders.Items.Add(" - " + sideCustom.returnItem().SpecialInstructions[i]);
            }

            //Orders.Items.Add(currentOrder);

            currentOrder.Add(sideCustom.returnItem());
        }

        private void FriedMiraak_Button(object sender, RoutedEventArgs e)
        {
            sideCustom.orderIn(new FriedMiraak());
            sideCustom.ShowDialog();
            orderList.Add(sideCustom.returnItem());

            Orders.Items.Add(sideCustom.returnItem().ToString());
            for (int i = 0; i < sideCustom.returnItem().SpecialInstructions.Count; i++)
            {
                Orders.Items.Add(" - " + sideCustom.returnItem().SpecialInstructions[i]);
            }

            //Orders.Items.Add(currentOrder);

            currentOrder.Add(sideCustom.returnItem());
        }

        private void VokunSalad_Button(object sender, RoutedEventArgs e)
        {
            sideCustom.orderIn(new VokunSalad());
            sideCustom.ShowDialog();
            orderList.Add(sideCustom.returnItem());

            Orders.Items.Add(sideCustom.returnItem().ToString());
            for (int i = 0; i < sideCustom.returnItem().SpecialInstructions.Count; i++)
            {
                Orders.Items.Add(" - " + sideCustom.returnItem().SpecialInstructions[i]);
            }

            //Orders.Items.Add(currentOrder);

            currentOrder.Add(sideCustom.returnItem());
        }

        private void MadOtarGrits_Button(object sender, RoutedEventArgs e)
        {
            sideCustom.orderIn(new MadOtarGrits());
            sideCustom.ShowDialog();
            orderList.Add(sideCustom.returnItem());

            Orders.Items.Add(sideCustom.returnItem().ToString());
            for (int i = 0; i < sideCustom.returnItem().SpecialInstructions.Count; i++)
            {
                Orders.Items.Add(" - " + sideCustom.returnItem().SpecialInstructions[i]);
            }

            //Orders.Items.Add(currentOrder);

            currentOrder.Add(sideCustom.returnItem());
        }

        private void WarriorWater_Button(object sender, RoutedEventArgs e)
        {
            warriorWaterCustom.orderIn(new WarriorWater());
            warriorWaterCustom.ShowDialog();
            orderList.Add(warriorWaterCustom.returnItem());

            Orders.Items.Add(warriorWaterCustom.returnItem().ToString());
            for (int i = 0; i < warriorWaterCustom.returnItem().SpecialInstructions.Count; i++)
            {
                Orders.Items.Add(" - " + warriorWaterCustom.returnItem().SpecialInstructions[i]);
            }

            //Orders.Items.Add(currentOrder);

            currentOrder.Add(warriorWaterCustom.returnItem());
        }

        private void SailorSoda_Button(object sender, RoutedEventArgs e)
        {
            sailorSodaCustom.orderIn(new SailorSoda());
            sailorSodaCustom.ShowDialog();
            orderList.Add(sailorSodaCustom.returnItem());

            Orders.Items.Add(sailorSodaCustom.returnItem().ToString());
            for (int i = 0; i < sailorSodaCustom.returnItem().SpecialInstructions.Count; i++)
            {
                Orders.Items.Add(" - " + sailorSodaCustom.returnItem().SpecialInstructions[i]);
            }

            //Orders.Items.Add(currentOrder);

            currentOrder.Add(sailorSodaCustom.returnItem());
        }

        private void MarkarthMilk_Button(object sender, RoutedEventArgs e)
        {
            markarthMilkCustom.orderIn(new MarkarthMilk());
            markarthMilkCustom.ShowDialog();
            orderList.Add(markarthMilkCustom.returnItem());

            Orders.Items.Add(markarthMilkCustom.returnItem().ToString());
            for (int i = 0; i < markarthMilkCustom.returnItem().SpecialInstructions.Count; i++)
            {
                Orders.Items.Add(" - " + markarthMilkCustom.returnItem().SpecialInstructions[i]);
            }

            //Orders.Items.Add(currentOrder);

            currentOrder.Add(markarthMilkCustom.returnItem());
        }

        private void CandlehearthCoffee_Button(object sender, RoutedEventArgs e)
        {
            candleHearthCoffeeCustom.orderIn(new CandlehearthCoffee());
            candleHearthCoffeeCustom.ShowDialog();
            orderList.Add(candleHearthCoffeeCustom.returnItem());

            Orders.Items.Add(candleHearthCoffeeCustom.returnItem().ToString());
            for (int i = 0; i < candleHearthCoffeeCustom.returnItem().SpecialInstructions.Count; i++)
            {
                Orders.Items.Add(" - " + candleHearthCoffeeCustom.returnItem().SpecialInstructions[i]);
            }

            //Orders.Items.Add(currentOrder);

            currentOrder.Add(candleHearthCoffeeCustom.returnItem());
        }

        private void AretinoAppleJuice_Button(object sender, RoutedEventArgs e)
        {
            aretinoAppleJuiceCustom.orderIn(new AretinoAppleJuice());
            aretinoAppleJuiceCustom.ShowDialog();
            orderList.Add(aretinoAppleJuiceCustom.returnItem());

            Orders.Items.Add(aretinoAppleJuiceCustom.returnItem().ToString());
            for (int i = 0; i < aretinoAppleJuiceCustom.returnItem().SpecialInstructions.Count; i++)
            {
                Orders.Items.Add(" - " + aretinoAppleJuiceCustom.returnItem().SpecialInstructions[i]);
            }

            //Orders.Items.Add(currentOrder);

            currentOrder.Add(aretinoAppleJuiceCustom.returnItem());
        }
        ///Ends ordering button handling


        /// <summary>
        /// Old clear item handling, functionality replaced by Clear_Order_Button
        /// remains for future functionality
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Clear_Button(object sender, RoutedEventArgs e)
        {
            orderList.RemoveAt(orderList.Count - 1);

            Orders_Populate(orderList);
        }

        /// <summary>
        /// Sends the currentOrder variable to the master list of orders
        /// Sends command to update the Orders ListBox to display the order
        /// Updates the running orderNumber
        /// Creates a new instance of currentOrder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Order_Button(object sender, RoutedEventArgs e)
        {
            ListOfOrders.Add(currentOrder);
            Orders_Populate();
            orderNumber++;
            currentOrder = new Order(orderNumber);
        }


        /// <summary>
        /// Identifies if the order is partial or finalized
        /// Removes entire previous order if it was completed
        /// Removes all of the current order if it is not finalized
        /// Provides logic to properly update the displayed order list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Clear_Order_Button(object sender, RoutedEventArgs e)
        {
            if(ListOfOrders.Count > 0 && OrderIndex[OrderIndex.Count - 1] == Orders.Items.Count - 1)
            {
                ListOfOrders.RemoveAt(ListOfOrders.Count - 1);
                for (int i = OrderIndex[OrderIndex.Count - 1]; i > OrderIndex[OrderIndex.Count - 2]; i--)
                {
                    Orders.Items.RemoveAt(i);
                }
                orderNumber--;
                OrderIndex.RemoveAt(OrderIndex.Count - 1);
            }
            else
            {
                for (int i = Orders.Items.Count - 1; i > OrderIndex[OrderIndex.Count - 1]; i--)
                {
                    Orders.Items.RemoveAt(i);
                }
                orderNumber = 1;
                currentOrder = new Order(orderNumber);
            }
        }
    }

    /// <summary>
    /// Unused Idea
    /// </summary>
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
