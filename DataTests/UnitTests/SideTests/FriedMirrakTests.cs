/*
 * Author: Zachery Brunner
 * Class: FriedMiraakTests.cs
 * Purpose: Test the FriedMiraak.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class FriedMiraakTests
    {
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            Data.Sides.FriedMiraak side = new Data.Sides.FriedMiraak();
            Assert.True(side.Size == Size.Small);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            Data.Sides.FriedMiraak side = new Data.Sides.FriedMiraak();
            side.Size = Size.Medium;
            Assert.False(side.Size == Size.Small);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            Data.Sides.FriedMiraak side = new Data.Sides.FriedMiraak();
            Assert.Empty(side.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 1.78)]
        [InlineData(Size.Medium, 2.01)]
        [InlineData(Size.Large, 2.88)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            Data.Sides.FriedMiraak side = new Data.Sides.FriedMiraak();
            side.Size = size;
            Assert.True(size == side.Size);
            Assert.True(price == side.Price);
        }

        [Theory]
        [InlineData(Size.Small, 151)]
        [InlineData(Size.Medium, 236)]
        [InlineData(Size.Large, 306)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            Data.Sides.FriedMiraak side = new Data.Sides.FriedMiraak();
            side.Size = size;
            Assert.True(size == side.Size);
            Assert.True(calories == side.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Fried Miraak")]
        [InlineData(Size.Medium, "Medium Fried Miraak")]
        [InlineData(Size.Large, "Large Fried Miraak")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            Data.Sides.FriedMiraak side = new Data.Sides.FriedMiraak();
            side.Size = size;
            Assert.Equal(name, side.ToString());
        }
    }
}