/*
 * Author: Zachery Brunner
 * Class: GardenOrcOmeletteTests.cs
 * Purpose: Test the GardenOrcOmelette.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class GardenOrcOmeletteTests
    {
        [Fact]
        public void ShouldInlcudeBroccoliByDefault()
        {
            Data.Entrees.GardenOrcOmelette entree = new Data.Entrees.GardenOrcOmelette();
            Assert.True(entree.Broccoli);
        }

        [Fact]
        public void ShouldInlcudeMushroomsByDefault()
        {
            Data.Entrees.GardenOrcOmelette entree = new Data.Entrees.GardenOrcOmelette();
            Assert.True(entree.Mushrooms);
        }

        [Fact]
        public void ShouldInlcudeTomatoByDefault()
        {
            Data.Entrees.GardenOrcOmelette entree = new Data.Entrees.GardenOrcOmelette();
            Assert.True(entree.Tomato);
        }

        [Fact]
        public void ShouldInlcudeCheddarByDefault()
        {
            Data.Entrees.GardenOrcOmelette entree = new Data.Entrees.GardenOrcOmelette();
            Assert.True(entree.Cheddar);
        }

        [Fact]
        public void ShouldBeAbleToSetBroccoli()
        {
            Data.Entrees.GardenOrcOmelette entree = new Data.Entrees.GardenOrcOmelette();
            entree.Broccoli = false;
            Assert.False(entree.Broccoli);
        }

        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
            Data.Entrees.GardenOrcOmelette entree = new Data.Entrees.GardenOrcOmelette();
            entree.Mushrooms = false;
            Assert.False(entree.Mushrooms);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            Data.Entrees.GardenOrcOmelette entree = new Data.Entrees.GardenOrcOmelette();
            entree.Tomato = false;
            Assert.False(entree.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetCheddar()
        {
            Data.Entrees.GardenOrcOmelette entree = new Data.Entrees.GardenOrcOmelette();
            entree.Cheddar = false;
            Assert.False(entree.Cheddar);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            Data.Entrees.GardenOrcOmelette entree = new Data.Entrees.GardenOrcOmelette();
            Assert.True(entree.Price == 4.57);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            Data.Entrees.GardenOrcOmelette entree = new Data.Entrees.GardenOrcOmelette();
            Assert.True(entree.Calories == 404);
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBroccoli, bool includeMushrooms,
                                                            bool includeTomato, bool includeCheddar)
        {
            Data.Entrees.GardenOrcOmelette entree = new Data.Entrees.GardenOrcOmelette();
            entree.Broccoli = includeBroccoli;
            entree.Mushrooms = includeMushrooms;
            entree.Tomato = includeTomato;
            entree.Cheddar = includeCheddar;

            if (!entree.Broccoli)
            {
                Assert.Contains<string>("Hold broccoli", entree.SpecialInstructions);
            }
            if (!entree.Mushrooms)
            {
                Assert.Contains<string>("Hold mushrooms", entree.SpecialInstructions);
            }
            if (!entree.Tomato)
            {
                Assert.Contains<string>("Hold tomato", entree.SpecialInstructions);
            }
            if (!entree.Cheddar)
            {
                Assert.Contains<string>("Hold cheddar", entree.SpecialInstructions);
            }

        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            Data.Entrees.GardenOrcOmelette entree = new Data.Entrees.GardenOrcOmelette();
            Assert.Equal("Garden Orc Omelette", entree.ToString());
        }
    }
}