/*
 * Author: Zachery Brunner
 * Class: SmokehouseSkeletonTests.cs
 * Purpose: Test the SmokehouseSkeleton.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class SmokehouseSkeletonTests
    {        
        [Fact]
        public void ShouldInlcudeSausageByDefault()
        {
            Data.Entrees.SmokehouseSkeleton entree = new Data.Entrees.SmokehouseSkeleton();
            Assert.True(entree.SausageLink);
        }

        [Fact]
        public void ShouldInlcudeEggByDefault()
        {
            Data.Entrees.SmokehouseSkeleton entree = new Data.Entrees.SmokehouseSkeleton();
            Assert.True(entree.Egg);
        }

        [Fact]
        public void ShouldInlcudeHashbrownsByDefault()
        {
            Data.Entrees.SmokehouseSkeleton entree = new Data.Entrees.SmokehouseSkeleton();
            Assert.True(entree.HashBrowns);
        }

        [Fact]
        public void ShouldInlcudePancakeByDefault()
        {
            Data.Entrees.SmokehouseSkeleton entree = new Data.Entrees.SmokehouseSkeleton();
            Assert.True(entree.Pancake);
        }

        [Fact]
        public void ShouldBeAbleToSetSausage()
        {
            Data.Entrees.SmokehouseSkeleton entree = new Data.Entrees.SmokehouseSkeleton();
            entree.SausageLink = false;
            Assert.False(entree.SausageLink);
        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            Data.Entrees.SmokehouseSkeleton entree = new Data.Entrees.SmokehouseSkeleton();
            entree.Egg = false;
            Assert.False(entree.Egg);
        }

        [Fact]
        public void ShouldBeAbleToSetHashbrowns()
        {
            Data.Entrees.SmokehouseSkeleton entree = new Data.Entrees.SmokehouseSkeleton();
            entree.HashBrowns = false;
            Assert.False(entree.HashBrowns);
        }

        [Fact]
        public void ShouldBeAbleToSetPancake()
        {
            Data.Entrees.SmokehouseSkeleton entree = new Data.Entrees.SmokehouseSkeleton();
            entree.Pancake = false;
            Assert.False(entree.Pancake);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            Data.Entrees.SmokehouseSkeleton entree = new Data.Entrees.SmokehouseSkeleton();
            Assert.True(entree.Price == 5.62);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            Data.Entrees.SmokehouseSkeleton entree = new Data.Entrees.SmokehouseSkeleton();
            Assert.True(entree.Calories == 602);
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSausage, bool includeEgg,
                                                            bool includeHashbrowns, bool includePancake)
        {
            Data.Entrees.SmokehouseSkeleton entree = new Data.Entrees.SmokehouseSkeleton();
            entree.SausageLink = includeSausage;
            entree.Egg = includeEgg;
            entree.HashBrowns = includeHashbrowns;
            entree.Pancake = includePancake;

            if (!entree.SausageLink)
            {
                Assert.Contains<string>("Hold sausage", entree.SpecialInstructions);
            }
            if (!entree.Egg)
            {
                Assert.Contains<string>("Hold eggs", entree.SpecialInstructions);
            }
            if (!entree.HashBrowns)
            {
                Assert.Contains<string>("Hold hashbrowns", entree.SpecialInstructions);
            }
            if (!entree.Pancake)
            {
                Assert.Contains<string>("Hold pancakes", entree.SpecialInstructions);
            }
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            Data.Entrees.SmokehouseSkeleton entree = new Data.Entrees.SmokehouseSkeleton();
            Assert.Equal("Smokehouse Skeleton", entree.ToString());
        }
    }
}