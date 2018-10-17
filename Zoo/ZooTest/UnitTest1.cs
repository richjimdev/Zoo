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
    }
}
