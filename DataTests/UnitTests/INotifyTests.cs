using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
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
            Assert.IsType<INotifyPropertyChanged>(APT);
            Assert.IsType<INotifyPropertyChanged>(CHCT);
            Assert.IsType<INotifyPropertyChanged>(MMT);
            Assert.IsType<INotifyPropertyChanged>(SST);
            Assert.IsType<INotifyPropertyChanged>(WWT);
        }
    }
}
