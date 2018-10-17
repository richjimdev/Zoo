using System;
using Xunit;
using Zoo.Classes;

namespace ZooTest
{
    public class UnitTest1
    {
        /// <summary>
        /// Domain is a property derrived all the way 3 levels up from the top main class
        /// </summary>
        [Fact]
        public void InheritedPropertiesExistInChildren()
        {
            Lion simba = new Lion();

            Assert.Equal("Eukaryota", simba.Domain);
        }

        /// <summary>
        /// Check if abstract method has been overridden
        /// </summary>
        [Fact]
        public void AbstractMethodsHaveBeenOverridden()
        {
            Lion simba = new Lion();

            Assert.Equal("meat", simba.Nutrition());
        }

        /// <summary>
        /// check that non overridden virtual methods return default value, null
        /// </summary>
        [Fact]
        public void VirtualMethodsRetainVaueWhenNotOverridden()
        {
            Ostrich matilda = new Ostrich();

            Assert.Null(matilda.Sound());
        }

        /// <summary>
        /// Check that virtual methods, once overridden, return the overridden value
        /// </summary>
        [Fact]
        public void VirtualMethodsCanBeOverridden()
        {
            Eagle baldie = new Eagle();
            Assert.Equal("Screech!", baldie.Sound());
        }

        /// <summary>
        /// Prove that interfaces are being implemented properly
        /// </summary>
        [Fact]
        public void InterfacesAreImplementedProperly()
        {
            HoneyBee barry = new HoneyBee();

            Assert.True(barry.wings);
        }
    }
}
