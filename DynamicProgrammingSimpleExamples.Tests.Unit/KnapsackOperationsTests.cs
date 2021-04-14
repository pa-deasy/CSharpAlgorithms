using FluentAssertions;
using NUnit.Framework;
using System.Collections.Generic;

namespace DynamicProgrammingSimpleExamples.Tests.Unit
{
    [TestFixture]
    public class KnapsackOperationsTests
    {
        [Test]
        public void Given_ItemsToSteal_When_BagHasLimitedCapacity_Then_TakesTheMostValuableItems()
        {
            var stealableItems = new List<StealableItem>
            {
                new StealableItem { Name = "Guitar", Value = 1500, Weight = 1 },
                new StealableItem { Name = "Stereo", Value = 3000, Weight = 4 },
                new StealableItem { Name = "Laptop", Value = 2000, Weight = 3 }
            };

            stealableItems.MaxWorthInBagSizeOf(4).Should().Be(3500);

            stealableItems.Add(new StealableItem { Name = "Iphone", Value = 2000, Weight = 1 });
            
            stealableItems.MaxWorthInBagSizeOf(4).Should().Be(4000);
            
            stealableItems.Add(new StealableItem { Name = "Mp3", Value = 1000, Weight = 1 });
            
            stealableItems.MaxWorthInBagSizeOf(4).Should().Be(4500);
        }
    }
}
