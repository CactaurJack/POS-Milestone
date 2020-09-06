/*
 * Author: Zachery Brunner
 * Class: VokunSaladTests.cs
 * Purpose: Test the VokunSalad.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class VokunSaladTests
    {
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            Data.Sides.VokunSalad side = new Data.Sides.VokunSalad();
            Assert.True(side.Size == Size.Small);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            Data.Sides.VokunSalad side = new Data.Sides.VokunSalad();
            side.Size = Size.Medium;
            Assert.False(side.Size == Size.Small);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            Data.Sides.VokunSalad side = new Data.Sides.VokunSalad();
            Assert.Empty(side.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 0.93)]
        [InlineData(Size.Medium, 1.28)]
        [InlineData(Size.Large, 1.82)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            Data.Sides.VokunSalad side = new Data.Sides.VokunSalad();
            side.Size = size;
            Assert.True(size == side.Size);
            Assert.True(price == side.Price);
        }

        [Theory]
        [InlineData(Size.Small, 41)]
        [InlineData(Size.Medium, 52)]
        [InlineData(Size.Large, 73)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            Data.Sides.VokunSalad side = new Data.Sides.VokunSalad();
            side.Size = size;
            Assert.True(size == side.Size);
            Assert.True(calories == side.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Vokun Salad")]
        [InlineData(Size.Medium, "Medium Vokun Salad")]
        [InlineData(Size.Large, "Large Vokun Salad")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            Data.Sides.VokunSalad side = new Data.Sides.VokunSalad();
            side.Size = size;
            Assert.Equal(name, side.ToString());
        }
    }
}