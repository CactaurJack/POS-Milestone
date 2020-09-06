/*
 * Author: Zachery Brunner
 * Class: CandlehearthCoffeeTests.cs
 * Purpose: Test the CandlehearthCoffee.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class CandlehearthCoffeeTests
    {
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            Data.Drinks.CandlehearthCoffee drink = new Data.Drinks.CandlehearthCoffee();
            Assert.False(drink.Ice);
        }

        [Fact]
        public void ShouldNotBeDecafByDefault()
        {
            Data.Drinks.CandlehearthCoffee drink = new Data.Drinks.CandlehearthCoffee();
            Assert.False(drink.Decaf);
        }

        [Fact]
        public void ShouldNotHaveRoomForCreamByDefault()
        {
            Data.Drinks.CandlehearthCoffee drink = new Data.Drinks.CandlehearthCoffee();
            Assert.False(drink.RoomForCream);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            Data.Drinks.CandlehearthCoffee drink = new Data.Drinks.CandlehearthCoffee();
            Assert.True(drink.Size == Size.Small);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            Data.Drinks.CandlehearthCoffee drink = new Data.Drinks.CandlehearthCoffee();
            drink.Ice = true;
            Assert.True(drink.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetDecaf()
        {
            Data.Drinks.CandlehearthCoffee drink = new Data.Drinks.CandlehearthCoffee();
            drink.Decaf = true;
            Assert.True(drink.Decaf);
        }

        [Fact]
        public void ShouldBeAbleToSetRoomForCream()
        {
            Data.Drinks.CandlehearthCoffee drink = new Data.Drinks.CandlehearthCoffee();
            drink.RoomForCream = true;
            Assert.True(drink.RoomForCream);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            Data.Drinks.CandlehearthCoffee drink = new Data.Drinks.CandlehearthCoffee();
            drink.Size = Size.Medium;
            Assert.False(drink.Size == Size.Small);
        }

        [Theory]
        [InlineData(Size.Small, 0.75)]
        [InlineData(Size.Medium, 1.25)]
        [InlineData(Size.Large, 1.75)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            Data.Drinks.CandlehearthCoffee drink = new Data.Drinks.CandlehearthCoffee();
            drink.Size = size;
            Assert.True(size == drink.Size);
            Assert.True(price == drink.Price);
        }

        [Theory]
        [InlineData(Size.Small, 7)]
        [InlineData(Size.Medium, 10)]
        [InlineData(Size.Large, 20)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            Data.Drinks.CandlehearthCoffee drink = new Data.Drinks.CandlehearthCoffee();
            drink.Size = size;
            Assert.True(size == drink.Size);
            Assert.True(cal == drink.Calories);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeCream)
        {
            Data.Drinks.CandlehearthCoffee drink = new Data.Drinks.CandlehearthCoffee();
            drink.Ice = includeIce;
            drink.RoomForCream = includeCream;
            if (drink.Ice)
            {
                Assert.Contains<string>("Add ice", drink.SpecialInstructions);
            }
            if (drink.RoomForCream)
            {
                Assert.Contains<string>("Add cream", drink.SpecialInstructions);
            }

        }

        [Theory]
        [InlineData(true, Size.Small, "Small Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Medium, "Medium Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Large, "Large Decaf Candlehearth Coffee")]
        [InlineData(false, Size.Small, "Small Candlehearth Coffee")]
        [InlineData(false, Size.Medium, "Medium Candlehearth Coffee")]
        [InlineData(false, Size.Large, "Large Candlehearth Coffee")]
        public void ShouldReturnCorrectToStringBasedOnSize(bool decaf, Size size, string name)
        {
            Data.Drinks.CandlehearthCoffee drink = new Data.Drinks.CandlehearthCoffee();
            drink.Size = size;
            drink.Decaf = decaf;
            Assert.Equal(drink.ToString(), name);
        }
    }
}
