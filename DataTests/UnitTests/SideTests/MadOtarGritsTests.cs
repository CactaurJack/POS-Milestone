/*
 * Author: Zachery Brunner
 * Class: MadOtarGritsTests.cs
 * Purpose: Test the MadOtarGrits.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class MadOtarGritsTests
    {
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            Data.Sides.MadOtarGrits side = new Data.Sides.MadOtarGrits();
            Assert.True(side.Size == Size.Small);
        }
                
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            Data.Sides.MadOtarGrits side = new Data.Sides.MadOtarGrits();
            side.Size = Size.Medium;
            Assert.False(side.Size == Size.Small);
        }

        [Fact]
        public void ShouldReturnCorrectStringOnSpecialInstructions()
        {
            Data.Sides.MadOtarGrits side = new Data.Sides.MadOtarGrits();
            Assert.Empty(side.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 1.22)]
        [InlineData(Size.Medium, 1.58)]
        [InlineData(Size.Large, 1.93)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            Data.Sides.MadOtarGrits side = new Data.Sides.MadOtarGrits();
            side.Size = size;
            Assert.True(size == side.Size);
            Assert.True(price == side.Price);
        }

        [Theory]
        [InlineData(Size.Small, 105)]
        [InlineData(Size.Medium, 142)]
        [InlineData(Size.Large, 179)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            Data.Sides.MadOtarGrits side = new Data.Sides.MadOtarGrits();
            side.Size = size;
            Assert.True(size == side.Size);
            Assert.True(calories == side.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Mad Otar Grits")]
        [InlineData(Size.Medium, "Medium Mad Otar Grits")]
        [InlineData(Size.Large, "Large Mad Otar Grits")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            Data.Sides.MadOtarGrits side = new Data.Sides.MadOtarGrits();
            side.Size = size;
            Assert.Equal(name, side.ToString());
        }
    }
}