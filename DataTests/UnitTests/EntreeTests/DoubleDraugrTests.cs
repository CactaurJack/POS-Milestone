/*
 * Author: Zachery Brunner
 * Class: DoubleDraugrTests.cs
 * Purpose: Test the DoubleDraugr.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class DoubleDraugrTests
    {   
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            
            Data.Entrees.DoubleDraugr entree = new Data.Entrees.DoubleDraugr();
            Assert.True(entree.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            Data.Entrees.DoubleDraugr entree = new Data.Entrees.DoubleDraugr();
            Assert.True(entree.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            Data.Entrees.DoubleDraugr entree = new Data.Entrees.DoubleDraugr();
            Assert.True(entree.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            Data.Entrees.DoubleDraugr entree = new Data.Entrees.DoubleDraugr();
            Assert.True(entree.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            Data.Entrees.DoubleDraugr entree = new Data.Entrees.DoubleDraugr();
            Assert.True(entree.Cheese);
        }

        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            Data.Entrees.DoubleDraugr entree = new Data.Entrees.DoubleDraugr();
            Assert.True(entree.Cheese);
        }

        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            Data.Entrees.DoubleDraugr entree = new Data.Entrees.DoubleDraugr();
            Assert.True(entree.Cheese);
        }

        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            Data.Entrees.DoubleDraugr entree = new Data.Entrees.DoubleDraugr();
            Assert.True(entree.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            Data.Entrees.DoubleDraugr entree = new Data.Entrees.DoubleDraugr();
            entree.Bun = false;
            Assert.False(entree.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            Data.Entrees.DoubleDraugr entree = new Data.Entrees.DoubleDraugr();
            entree.Ketchup = false;
            Assert.False(entree.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            Data.Entrees.DoubleDraugr entree = new Data.Entrees.DoubleDraugr();
            entree.Mustard = false;
            Assert.False(entree.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            Data.Entrees.DoubleDraugr entree = new Data.Entrees.DoubleDraugr();
            entree.Pickle = false;
            Assert.False(entree.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            Data.Entrees.DoubleDraugr entree = new Data.Entrees.DoubleDraugr();
            entree.Cheese = false;
            Assert.False(entree.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            Data.Entrees.DoubleDraugr entree = new Data.Entrees.DoubleDraugr();
            entree.Tomato = false;
            Assert.False(entree.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            Data.Entrees.DoubleDraugr entree = new Data.Entrees.DoubleDraugr();
            entree.Lettuce = false;
            Assert.False(entree.Lettuce);
        }

        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            Data.Entrees.DoubleDraugr entree = new Data.Entrees.DoubleDraugr();
            entree.Mayo = false;
            Assert.False(entree.Mayo);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            Data.Entrees.DoubleDraugr entree = new Data.Entrees.DoubleDraugr();
            Assert.True(entree.Price == 7.32);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            Data.Entrees.DoubleDraugr entree = new Data.Entrees.DoubleDraugr();
            Assert.True(entree.Calories == 843);
        }

        [Theory]
        [InlineData(true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo)
        {
            Data.Entrees.DoubleDraugr entree = new Data.Entrees.DoubleDraugr();
            entree.Bun = includeBun;
            entree.Ketchup = includeKetchup;
            entree.Mustard = includeMustard;
            entree.Pickle = includePickle;
            entree.Cheese = includeCheese;
            entree.Tomato = includeTomato;
            entree.Lettuce = includeLettuce;
            entree.Mayo = includeMayo;

            if (!entree.Bun)
            {
                Assert.Contains<string>("Hold bun", entree.SpecialInstructions);
            }
            if (!entree.Ketchup)
            {
                Assert.Contains<string>("Hold ketchup", entree.SpecialInstructions);
            }
            if (!entree.Mustard)
            {
                Assert.Contains<string>("Hold mustard", entree.SpecialInstructions);
            }
            if (!entree.Pickle)
            {
                Assert.Contains<string>("Hold pickle", entree.SpecialInstructions);
            }
            if (!entree.Cheese)
            {
                Assert.Contains<string>("Hold cheese", entree.SpecialInstructions);
            }
            if (!entree.Tomato)
            {
                Assert.Contains<string>("Hold tomato", entree.SpecialInstructions);
            }
            if (!entree.Lettuce)
            {
                Assert.Contains<string>("Hold lettuce", entree.SpecialInstructions);
            }
            if (!entree.Mayo)
            {
                Assert.Contains<string>("Hold mayo", entree.SpecialInstructions);
            }
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            Data.Entrees.DoubleDraugr entree = new Data.Entrees.DoubleDraugr();
            Assert.Equal("Double Draugr", entree.ToString());
        }
    }
}