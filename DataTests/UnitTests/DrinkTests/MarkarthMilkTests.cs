/*
 * Author: Zachery Brunner
 * Class: MarkarthMilkTests.cs
 * Purpose: Test the MarkarthMilk.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class MarkarthMilkTests
    {
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            Data.Drinks.MarkarthMilk drink = new Data.Drinks.MarkarthMilk();
            Assert.False(drink.Ice);
        }

        [Fact]
        public void ShouldBySmallByDefault()
        {
            Data.Drinks.MarkarthMilk drink = new Data.Drinks.MarkarthMilk();
            Assert.True(drink.Size == Size.Small);
        }

        [Fact]
        public void ShouldByAbleToSetIce()
        {
            Data.Drinks.MarkarthMilk drink = new Data.Drinks.MarkarthMilk();
            drink.Ice = true;
            Assert.True(drink.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            Data.Drinks.MarkarthMilk drink = new Data.Drinks.MarkarthMilk();
            drink.Size = Size.Medium;
            Assert.False(drink.Size == Size.Small);
        }

        [Theory]
        [InlineData(Size.Small, 1.05)]
        [InlineData(Size.Medium, 1.11)]
        [InlineData(Size.Large, 1.22)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            Data.Drinks.MarkarthMilk drink = new Data.Drinks.MarkarthMilk();
            drink.Size = size;
            Assert.True(size == drink.Size);
            Assert.True(price == drink.Price);
        }

        [Theory]
        [InlineData(Size.Small, 56)]
        [InlineData(Size.Medium, 72)]
        [InlineData(Size.Large, 93)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            Data.Drinks.MarkarthMilk drink = new Data.Drinks.MarkarthMilk();
            drink.Size = size;
            Assert.True(size == drink.Size);
            Assert.True(cal == drink.Calories);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            Data.Drinks.MarkarthMilk drink = new Data.Drinks.MarkarthMilk();
            drink.Ice = includeIce;
            if (drink.Ice)
            {
                Assert.Contains<string>("Add ice", drink.SpecialInstructions);
            }
        }

        [Theory]
        [InlineData(Size.Small, "Small Markarth Milk")]
        [InlineData(Size.Medium, "Medium Markarth Milk")]
        [InlineData(Size.Large, "Large Markarth Milk")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            Data.Drinks.MarkarthMilk drink = new Data.Drinks.MarkarthMilk();
            drink.Size = size;
            Assert.Equal(drink.ToString(), name);
        }
    }
}