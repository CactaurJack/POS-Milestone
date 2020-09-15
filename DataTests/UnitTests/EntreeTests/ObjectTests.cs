using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using BleakwindBuffet.DataTests;
using Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ObjectTests
    {
        [Fact]
        public void ShouldBeAssignableToAbstractEntreeClass()
        {
            Entree entree = new BriarheartBurger();
            Assert.IsAssignableFrom<IOrderItem>(entree);
            Assert.IsAssignableFrom<Entree>(entree);
            entree = new DoubleDraugr();
            Assert.IsAssignableFrom<IOrderItem>(entree);
            Assert.IsAssignableFrom<Entree>(entree);
            entree = new ThalmorTriple();
            Assert.IsAssignableFrom<IOrderItem>(entree);
            Assert.IsAssignableFrom<Entree>(entree);
            entree = new GardenOrcOmelette();
            Assert.IsAssignableFrom<IOrderItem>(entree);
            Assert.IsAssignableFrom<Entree>(entree);
            entree = new PhillyPoacher();
            Assert.IsAssignableFrom<IOrderItem>(entree);
            Assert.IsAssignableFrom<Entree>(entree);
            entree = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<IOrderItem>(entree);
            Assert.IsAssignableFrom<Entree>(entree);
            entree = new ThugsTBone();
            Assert.IsAssignableFrom<IOrderItem>(entree);
            Assert.IsAssignableFrom<Entree>(entree);
        }
        [Fact]
        public void ShouldBeAssignableToAbstractDrinkClass()
        {
            Drink drink = new AretinoAppleJuice();
            Assert.IsAssignableFrom<IOrderItem>(drink);
            Assert.IsAssignableFrom<Drink>(drink);
        }



    }
}
