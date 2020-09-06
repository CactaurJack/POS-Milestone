/*
 * Author: Zachery Brunner
 * Class: BriarheartBurgerTests.cs
 * Purpose: Test the BriarheartBurger.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;


namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class BriarheartBurgerTests
    {
        
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            Data.Entrees.BriarheartBurger entree = new Data.Entrees.BriarheartBurger();
            Assert.True(entree.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            Data.Entrees.BriarheartBurger entree = new Data.Entrees.BriarheartBurger();
            Assert.True(entree.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            Data.Entrees.BriarheartBurger entree = new Data.Entrees.BriarheartBurger();
            Assert.True(entree.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            Data.Entrees.BriarheartBurger entree = new Data.Entrees.BriarheartBurger();
            Assert.True(entree.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            Data.Entrees.BriarheartBurger entree = new Data.Entrees.BriarheartBurger();
            Assert.True(entree.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            Data.Entrees.BriarheartBurger entree = new Data.Entrees.BriarheartBurger();
            entree.Bun = false;
            Assert.False(entree.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            Data.Entrees.BriarheartBurger entree = new Data.Entrees.BriarheartBurger();
            entree.Ketchup = false;
            Assert.False(entree.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            Data.Entrees.BriarheartBurger entree = new Data.Entrees.BriarheartBurger();
            entree.Mustard = false;
            Assert.False(entree.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            Data.Entrees.BriarheartBurger entree = new Data.Entrees.BriarheartBurger();
            entree.Pickle = false;
            Assert.False(entree.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            Data.Entrees.BriarheartBurger entree = new Data.Entrees.BriarheartBurger();
            entree.Cheese = false;
            Assert.False(entree.Cheese);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            Data.Entrees.BriarheartBurger entree = new Data.Entrees.BriarheartBurger();
            Assert.True(entree.Price == 6.32);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            Data.Entrees.BriarheartBurger entree = new Data.Entrees.BriarheartBurger();
            Assert.True(entree.Calories == 732);
        }

        [Theory]
        [InlineData(true, true, true, true, true)]
        [InlineData(false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese)
        {
            Data.Entrees.BriarheartBurger entree = new Data.Entrees.BriarheartBurger();
            entree.Bun = includeBun;
            entree.Ketchup = includeKetchup;
            entree.Mustard = includeMustard;
            entree.Pickle = includePickle;
            entree.Cheese = includeCheese;
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

        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            Data.Entrees.BriarheartBurger entree = new Data.Entrees.BriarheartBurger();
            Assert.Equal("Briarheart Burger", entree.ToString());
        }
    }
}