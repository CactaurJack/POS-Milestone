/*
 * Author: Zachery Brunner
 * Class: DragonbornWaffleFriesTests.cs
 * Purpose: Test the DragonbornWaffleFries.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class DragonbornWaffleFriesTests
    {
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            Data.Sides.DragonbornWaffleFries side = new Data.Sides.DragonbornWaffleFries();
            Assert.True(side.Size == Size.Small);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            Data.Sides.DragonbornWaffleFries side = new Data.Sides.DragonbornWaffleFries();
            side.Size = Size.Medium;
            Assert.False(side.Size == Size.Small);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            Data.Sides.DragonbornWaffleFries side = new Data.Sides.DragonbornWaffleFries();
            Assert.Empty(side.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 0.42)]
        [InlineData(Size.Medium, 0.76)]
        [InlineData(Size.Large, 0.96)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            Data.Sides.DragonbornWaffleFries side = new Data.Sides.DragonbornWaffleFries();
            side.Size = size;
            Assert.True(size == side.Size);
            Assert.True(price == side.Price);
        }

        [Theory]
        [InlineData(Size.Small, 77)]
        [InlineData(Size.Medium, 89)]
        [InlineData(Size.Large, 100)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            Data.Sides.DragonbornWaffleFries side = new Data.Sides.DragonbornWaffleFries();
            side.Size = size;
            Assert.True(size == side.Size);
            Assert.True(calories == side.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Dragonborn Waffle Fries")]
        [InlineData(Size.Medium, "Medium Dragonborn Waffle Fries")]
        [InlineData(Size.Large, "Large Dragonborn Waffle Fries")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            Data.Sides.DragonbornWaffleFries side = new Data.Sides.DragonbornWaffleFries();
            side.Size = size;
            Assert.Equal(name, side.ToString());
        }
    }
}