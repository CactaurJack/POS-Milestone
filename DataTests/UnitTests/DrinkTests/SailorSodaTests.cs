/*
 * Author: Zachery Brunner
 * Class: SailorSodaTests.cs
 * Purpose: Test the SailorSoda.cs class in the Data library
 */
using System;

using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class SailorSodaTests
    {
        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            Data.Drinks.SailorSoda drink = new Data.Drinks.SailorSoda();
            Assert.True(drink.Ice);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            Data.Drinks.SailorSoda drink = new Data.Drinks.SailorSoda();
            Assert.True(drink.Size == Size.Small);
        }

        [Fact]
        public void FlavorShouldBeCherryByDefault()
        {
            Data.Drinks.SailorSoda drink = new Data.Drinks.SailorSoda();
            Assert.True(drink.Flavor == SodaFlavor.Cherry);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            Data.Drinks.SailorSoda drink = new Data.Drinks.SailorSoda();
            drink.Ice = true;
            Assert.True(drink.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            Data.Drinks.SailorSoda drink = new Data.Drinks.SailorSoda();
            drink.Size = Size.Medium;
            Assert.False(drink.Size == Size.Small);
        }

        [Fact]
        public void ShouldBeAbleToSetFlavor()
        {
            Data.Drinks.SailorSoda drink = new Data.Drinks.SailorSoda();
            drink.Flavor = SodaFlavor.Grapefruit;
            Assert.False(drink.Flavor == SodaFlavor.Cherry);
        }

        [Theory]
        [InlineData(Size.Small, 1.42)]
        [InlineData(Size.Medium, 1.74)]
        [InlineData(Size.Large, 2.07)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            Data.Drinks.SailorSoda drink = new Data.Drinks.SailorSoda();
            drink.Size = size;
            Assert.True(size == drink.Size);
            Assert.True(price == drink.Price);
        }

        [Theory]
        [InlineData(Size.Small, 117)]
        [InlineData(Size.Medium, 153)]
        [InlineData(Size.Large, 205)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            Data.Drinks.SailorSoda drink = new Data.Drinks.SailorSoda();
            drink.Size = size;
            Assert.True(size == drink.Size);
            Assert.True(cal == drink.Calories);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            Data.Drinks.SailorSoda drink = new Data.Drinks.SailorSoda();
            drink.Ice = includeIce;
            if (!drink.Ice)
            {
                Assert.Contains<string>("Hold ice", drink.SpecialInstructions);
            };
        }
        
        [Theory]
        [InlineData(SodaFlavor.Cherry, Size.Small, "Small Cherry Sailor Soda")]
        [InlineData(SodaFlavor.Cherry, Size.Medium, "Medium Cherry Sailor Soda")]
        [InlineData(SodaFlavor.Cherry, Size.Large, "Large Cherry Sailor Soda")]

        [InlineData(SodaFlavor.Blackberry, Size.Small, "Small Blackberry Sailor Soda")]
        [InlineData(SodaFlavor.Blackberry, Size.Medium, "Medium Blackberry Sailor Soda")]
        [InlineData(SodaFlavor.Blackberry, Size.Large, "Large Blackberry Sailor Soda")]

        [InlineData(SodaFlavor.Grapefruit, Size.Small, "Small Grapefruit Sailor Soda")]
        [InlineData(SodaFlavor.Grapefruit, Size.Medium, "Medium Grapefruit Sailor Soda")]
        [InlineData(SodaFlavor.Grapefruit, Size.Large, "Large Grapefruit Sailor Soda")]

        [InlineData(SodaFlavor.Lemon, Size.Small, "Small Lemon Sailor Soda")]
        [InlineData(SodaFlavor.Lemon, Size.Medium, "Medium Lemon Sailor Soda")]
        [InlineData(SodaFlavor.Lemon, Size.Large, "Large Lemon Sailor Soda")]

        [InlineData(SodaFlavor.Peach, Size.Small, "Small Peach Sailor Soda")]
        [InlineData(SodaFlavor.Peach, Size.Medium, "Medium Peach Sailor Soda")]
        [InlineData(SodaFlavor.Peach, Size.Large, "Large Peach Sailor Soda")]

        [InlineData(SodaFlavor.Watermelon, Size.Small, "Small Watermelon Sailor Soda")]
        [InlineData(SodaFlavor.Watermelon, Size.Medium, "Medium Watermelon Sailor Soda")]
        [InlineData(SodaFlavor.Watermelon, Size.Large, "Large Watermelon Sailor Soda")]
        public void ShouldHaveCorrectToStringBasedOnSizeAndFlavor(SodaFlavor flavor, Size size, string name)
        {
            Data.Drinks.SailorSoda drink = new Data.Drinks.SailorSoda();
            drink.Size = size;
            drink.Flavor = flavor;
            Assert.Equal(drink.ToString(), name);
        }
    }
}
