/*
 * Author: Zachery Brunner
 * Class: ThalmorTripleTests.cs
 * Purpose: Test the ThalmorTriple.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThalmorTripleTests
    {
        [Fact]
        public void ShouldIncludeBunByDefault()
        {

            Data.Entrees.ThalmorTriple entree = new Data.Entrees.ThalmorTriple();
            Assert.True(entree.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            Data.Entrees.ThalmorTriple entree = new Data.Entrees.ThalmorTriple();
            Assert.True(entree.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            Data.Entrees.ThalmorTriple entree = new Data.Entrees.ThalmorTriple();
            Assert.True(entree.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            Data.Entrees.ThalmorTriple entree = new Data.Entrees.ThalmorTriple();
            Assert.True(entree.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            Data.Entrees.ThalmorTriple entree = new Data.Entrees.ThalmorTriple();
            Assert.True(entree.Cheese);
        }

        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            Data.Entrees.ThalmorTriple entree = new Data.Entrees.ThalmorTriple();
            Assert.True(entree.Cheese);
        }

        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            Data.Entrees.ThalmorTriple entree = new Data.Entrees.ThalmorTriple();
            Assert.True(entree.Cheese);
        }

        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            Data.Entrees.ThalmorTriple entree = new Data.Entrees.ThalmorTriple();
            Assert.True(entree.Cheese);
        }

        [Fact]
        public void ShouldIncludeBaconByDefault()
        {
            Data.Entrees.ThalmorTriple entree = new Data.Entrees.ThalmorTriple();
            Assert.True(entree.Bacon);
        }

        [Fact]
        public void ShouldIncludeEggByDefault()
        {
            Data.Entrees.ThalmorTriple entree = new Data.Entrees.ThalmorTriple();
            Assert.True(entree.Egg);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            Data.Entrees.ThalmorTriple entree = new Data.Entrees.ThalmorTriple();
            entree.Bun = false;
            Assert.False(entree.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            Data.Entrees.ThalmorTriple entree = new Data.Entrees.ThalmorTriple();
            entree.Ketchup = false;
            Assert.False(entree.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            Data.Entrees.ThalmorTriple entree = new Data.Entrees.ThalmorTriple();
            entree.Mustard = false;
            Assert.False(entree.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            Data.Entrees.ThalmorTriple entree = new Data.Entrees.ThalmorTriple();
            entree.Pickle = false;
            Assert.False(entree.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            Data.Entrees.ThalmorTriple entree = new Data.Entrees.ThalmorTriple();
            entree.Cheese = false;
            Assert.False(entree.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            Data.Entrees.ThalmorTriple entree = new Data.Entrees.ThalmorTriple();
            entree.Tomato = false;
            Assert.False(entree.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            Data.Entrees.ThalmorTriple entree = new Data.Entrees.ThalmorTriple();
            entree.Lettuce = false;
            Assert.False(entree.Lettuce);
        }

        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            Data.Entrees.ThalmorTriple entree = new Data.Entrees.ThalmorTriple();
            entree.Mayo = false;
            Assert.False(entree.Mayo);
        }

        [Fact]
        public void ShouldBeAbleToSetBacon()
        {
            Data.Entrees.ThalmorTriple entree = new Data.Entrees.ThalmorTriple();
            entree.Bacon = false;
            Assert.False(entree.Bacon);
        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            Data.Entrees.ThalmorTriple entree = new Data.Entrees.ThalmorTriple();
            entree.Egg = false;
            Assert.False(entree.Egg);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            Data.Entrees.ThalmorTriple entree = new Data.Entrees.ThalmorTriple();
            Assert.True(entree.Price == 8.32);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            Data.Entrees.ThalmorTriple entree = new Data.Entrees.ThalmorTriple();
            Assert.True(entree.Calories == 943);
        }

        [Theory]
        [InlineData(true, true, true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo,
                                                                    bool includeBacon, bool includeEgg)
        {
            Data.Entrees.ThalmorTriple entree = new Data.Entrees.ThalmorTriple();
            entree.Bun = includeBun;
            entree.Ketchup = includeKetchup;
            entree.Mustard = includeMustard;
            entree.Pickle = includePickle;
            entree.Cheese = includeCheese;
            entree.Tomato = includeTomato;
            entree.Lettuce = includeLettuce;
            entree.Mayo = includeMayo;
            entree.Bacon = includeBacon;
            entree.Egg = includeEgg;

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
            if (!entree.Bacon)
            {
                Assert.Contains<string>("Hold bacon", entree.SpecialInstructions);
            }
            if (!entree.Egg)
            {
                Assert.Contains<string>("Hold egg", entree.SpecialInstructions);
            }
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            Data.Entrees.ThalmorTriple entree = new Data.Entrees.ThalmorTriple();
            Assert.Equal("Thalmor Triple", entree.ToString());
        }
    }
}