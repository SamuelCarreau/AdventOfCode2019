using AdventOfCode2019.Application.DayTwo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2019.Test.DayTwo
{
    [TestClass]
    public class DayTwoTest
    {

        private void CollectionComparer(List<int> expextedCol, List<int> testedCol)
        {
            for (int i = 0; i < expextedCol.Count; i++)
            {
                Assert.AreEqual(expextedCol[i], testedCol[i]);
            }
        }

        [TestMethod]
        public void TestOne()
        {
            string[] input = "1,0,0,0,99".Split(',');
            IntcodeManager intcodeManager = new IntcodeManager(input);
            List<int> ExpectedValue = IntcodeManager.ParseTextIntcode("2,0,0,0,99".Split(','));
            CollectionComparer(ExpectedValue, intcodeManager.Intcode);

        }
        [TestMethod]
        public void TestTwo()
        {
            var input = "2,3,0,3,99".Split(',');
            var intcodeManager = new IntcodeManager(input);
            List<int> ExpectedValue = IntcodeManager.ParseTextIntcode("2,3,0,6,99".Split(','));
            CollectionComparer(ExpectedValue, intcodeManager.Intcode);
        }
        [TestMethod]
        public void TestThree()
        {
            var input = "2,4,4,5,99,0".Split(',');
            var intcodeManager = new IntcodeManager(input);
            List<int> ExpectedValue = IntcodeManager.ParseTextIntcode("2,4,4,5,99,9801".Split(','));
            CollectionComparer(ExpectedValue, intcodeManager.Intcode);
        }
        [TestMethod]
        public void TestFour()
        {
            var input = "1,1,1,4,99,5,6,0,99".Split(',');
            var intcodeManager = new IntcodeManager(input);
            List<int> ExpectedValue = IntcodeManager.ParseTextIntcode("30,1,1,4,2,5,6,0,99".Split(','));
            CollectionComparer(ExpectedValue, intcodeManager.Intcode);
        }
    }
}
