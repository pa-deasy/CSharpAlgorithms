using NUnit.Framework;
using System.Collections.Generic;

namespace BreadthFirstSearchMangoSeller.Tests.Unit
{
    [TestFixture]
    public class PersonSearchOperationsTests
    {
        [Test]
        public void Given_NodesOfContacts_When_MangoSellerExists_Then_Returns_Closest()
        {
            Assert.AreEqual("thom", TestContacts().ClosestMangoSeller());
        }

        [Test]
        public void Given_NodesOfContacts_When_NoMangoSellerExists_Then_ReturnsEmptyString()
        {
            Assert.AreEqual(string.Empty, TestContactsWithNoSeller().ClosestMangoSeller());
        }

        private static Node TestContacts()
        {
            var thom = new Node 
            { 
                Value = new Person { Name = "thom", MangoSeller = true }, 
                Contacts = new List<Node>() 
            };

            var anuj = new Node
            {
                Value = new Person { Name = "anuj", MangoSeller = false },
                Contacts = new List<Node>()
            };

            var peggy = new Node
            {
                Value = new Person { Name = "Peggy", MangoSeller = false },
                Contacts = new List<Node>()
            };

            var bob = new Node
            {
                Value = new Person { Name = "Bob", MangoSeller = false },
                Contacts = new List<Node> { anuj, peggy }
            };

            var alice = new Node
            {
                Value = new Person { Name = "Alice", MangoSeller = false },
                Contacts = new List<Node> { peggy }
            };

            var jonny = new Node
            {
                Value = new Person { Name = "Jonny", MangoSeller = false },
                Contacts = new List<Node>()
            };

            var claire = new Node
            {
                Value = new Person { Name = "claire", MangoSeller = false },
                Contacts = new List<Node> { thom, jonny }
            };

            var you = new Node
            {
                Value = new Person { Name = "you", MangoSeller = false },
                Contacts = new List<Node> { bob, claire, alice }
            };

            return you;
        }

        private static Node TestContactsWithNoSeller()
        {
            var jonny = new Node
            {
                Value = new Person { Name = "Jonny", MangoSeller = false },
                Contacts = new List<Node>()
            };

            var claire = new Node
            {
                Value = new Person { Name = "claire", MangoSeller = false },
                Contacts = new List<Node> { jonny }
            };

            var you = new Node
            {
                Value = new Person { Name = "you", MangoSeller = false },
                Contacts = new List<Node> { claire }
            };

            return you;
        }
    }
}
