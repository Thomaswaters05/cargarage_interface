using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarGarage.cs;

namespace CarGarage.Tests
{
    [TestClass]
    public class GarageTests
    {
        [TestMethod]
        public void TestCreatingGarage()
        {
            var storage = new HouseGarage();
            var garage = new Garage(storage); //this is making a new garage instance
            Assert.IsNotNull(garage);
        }
        [TestMethod]
        public void TestStorageExists()
        {
            var storage = new HouseGarage();
            var garage = new Garage(storage); //this is making a new garage instance
            Assert.IsNotNull(garage.ParkingArea);
        }
    }
}
