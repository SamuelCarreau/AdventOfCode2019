using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventOfCode2019.Application.DayOne;

namespace AdventOfCode2019.Test.DayOne
{
    [TestClass]
    public class DayOneTest
    {
        [TestMethod]
        public void FuelCalculator_Give_2_ForMassOf_12()
        {
            Assert.AreEqual(2,FuelCalculator.GetFuelRequiredForMass(12)); 
        }

        [TestMethod]
        public void FuelCalculator_Give_2_ForMassOf_14()
        {
            Assert.AreEqual(2, FuelCalculator.GetFuelRequiredForMass(14));
        }

        [TestMethod]
        public void FuelCalculator_Give_654_ForMassOf_1969()
        {
            Assert.AreEqual(654, FuelCalculator.GetFuelRequiredForMass(1969));
        }

        [TestMethod]
        public void FuelCalculator_Give_33583_ForMassOf_100756()
        {
            Assert.AreEqual(33583, FuelCalculator.GetFuelRequiredForMass(100756));
        }

        [TestMethod]
        public void FuelCalculator_Give_2_ForMassOf_14_IncludingFuelMass()
        {
            Assert.AreEqual(2, FuelCalculator.GetFuelForMassIncludingFuelMass(14));
        }

        [TestMethod]
        public void FuelCalculator_Give_966_ForMassOf_1969_IncludingFuelMass()
        {
            Assert.AreEqual(966, FuelCalculator.GetFuelForMassIncludingFuelMass(1969));
        }

        [TestMethod]
        public void FuelCalculator_Give_50346_ForMassOf_100756_IncludingFuelMass()
        {
            Assert.AreEqual(50346, FuelCalculator.GetFuelForMassIncludingFuelMass(100756));
        }

    }

   
}
