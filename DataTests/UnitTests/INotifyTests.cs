using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xunit;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class INotifyTests
    {
        [Fact]
        public void IsCastableAsINotify()
        {
            AretinoAppleJuice APT = new AretinoAppleJuice();
            CandlehearthCoffee CHCT = new CandlehearthCoffee();
            MarkarthMilk MMT = new MarkarthMilk();
            SailorSoda SST = new SailorSoda();
            WarriorWater WWT = new WarriorWater();
        }

        [Fact]
        public void OrderImplimentsIOrderSupport()
        {
            BriarheartBurger BBT = new BriarheartBurger();
            Order OrderTest = new Order(0);
            OrderTest.Add(BBT);
            Assert.Equal(OrderTest.Calories, BBT.Calories);
            Assert.Equal(OrderTest.Subtotal, BBT.Price);
            SailorSoda SST = new SailorSoda();
            SST.Size = Data.Enums.Size.Large;
            OrderTest = new Order(0);
            OrderTest.Add(SST);
            Assert.Equal(OrderTest.Calories, SST.Calories);
            Assert.Equal(OrderTest.Subtotal, SST.Price);
        }

        [Fact]
        public void OrderCalculatesPriceCorrectly()
        {
            BriarheartBurger BBT = new BriarheartBurger();
            SailorSoda SST = new SailorSoda();
            Order OrderTest = new Order(0);
            OrderTest.Add(BBT);
            OrderTest.Add(SST);
            Assert.Equal(OrderTest.Subtotal, BBT.Price + SST.Price);
        }

        [Fact]
        public void OrderCalculatesCaloriesCorrectly()
        {
            BriarheartBurger BBT = new BriarheartBurger();
            SailorSoda SST = new SailorSoda();
            Order OrderTest = new Order(0);
            OrderTest.Add(BBT);
            OrderTest.Add(SST);
            Assert.Equal(OrderTest.Calories, BBT.Calories + SST.Calories);
        }
    }
}
