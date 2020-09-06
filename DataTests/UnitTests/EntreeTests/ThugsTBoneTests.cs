/*
 * Author: Zachery Brunner
 * Class: ThugsTBoneTests.cs
 * Purpose: Test the ThugsTBone.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThugsTBoneTests
    {
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            Data.Entrees.ThugsTBone entree = new Data.Entrees.ThugsTBone();
            Assert.True(entree.Price == 6.44);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            Data.Entrees.ThugsTBone entree = new Data.Entrees.ThugsTBone();
            Assert.True(entree.Calories == 982);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            Data.Entrees.ThugsTBone entree = new Data.Entrees.ThugsTBone();
            Assert.Empty(entree.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            Data.Entrees.ThugsTBone entree = new Data.Entrees.ThugsTBone();
            Assert.Equal("Thugs T-Bone", entree.ToString());
        }
    }
}