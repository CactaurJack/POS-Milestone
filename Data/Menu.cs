using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data
{
    public class Menu
    {
        public static IEnumerable<IOrderItem> enumerable;
        public Menu()
        {
            IEnumerable<IOrderItem> enumerable;
        }

        //public IEnumerable<IenumerableItem> enumerable;
        public static IEnumerable<IOrderItem> Entrees()
        {
            enumerable.Append(new BriarheartBurger());
            enumerable.Append(new DoubleDraugr());
            enumerable.Append(new GardenOrcOmelette());
            enumerable.Append(new PhillyPoacher());
            enumerable = enumerable.Append(new SmokehouseSkeleton());
            enumerable.Append(new ThalmorTriple());
            enumerable.Append(new ThugsTBone());
            return enumerable;
        }

        public static IEnumerable<IOrderItem> Drinks()
        {
            enumerable.Append(new AretinoAppleJuice());
            enumerable.Append(new CandlehearthCoffee());
            enumerable.Append(new MarkarthMilk());
            enumerable.Append(new SailorSoda());
            enumerable = enumerable.Append(new WarriorWater());
            return enumerable;
        }

        public static IEnumerable<IOrderItem> Sides()
        {
            enumerable.Append(new DragonbornWaffleFries());
            enumerable.Append(new FriedMiraak());
            enumerable.Append(new MadOtarGrits());
            enumerable.Append(new VokunSalad());
            return enumerable;
        }

        public static IEnumerable<IOrderItem> FullMenu()
        {
            enumerable.Append(new BriarheartBurger());
            enumerable.Append(new DoubleDraugr());
            enumerable.Append(new GardenOrcOmelette());
            enumerable.Append(new PhillyPoacher());
            enumerable = enumerable.Append(new SmokehouseSkeleton());
            enumerable.Append(new ThalmorTriple());
            enumerable.Append(new ThugsTBone());
            enumerable.Append(new AretinoAppleJuice());
            enumerable.Append(new CandlehearthCoffee());
            enumerable.Append(new MarkarthMilk());
            enumerable.Append(new SailorSoda());
            enumerable = enumerable.Append(new WarriorWater());
            enumerable.Append(new AretinoAppleJuice());
            enumerable.Append(new CandlehearthCoffee());
            enumerable.Append(new MarkarthMilk());
            enumerable.Append(new SailorSoda());
            enumerable = enumerable.Append(new WarriorWater());
            return enumerable;
        }
    }
}
