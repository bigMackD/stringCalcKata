using Microsoft.VisualStudio.TestTools.UnitTesting;
using stringCalcKata;
using System;

namespace stringCalcKata.Tests
{
    [TestClass]
    public class AddStringCalcTest
    {
        [TestMethod]
        public void add_getsEmptyString_returnsZero()
        {
            //arrange
            string input = "";
            StringCalc stringCalcTest = new StringCalc();

            //act
             var result = stringCalcTest.Add(input);
            //assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void add_getsEmptyString_returnsOneInt()
        {
            //arrange
            string input = "69";
            StringCalc stringCalcTest = new StringCalc();

            //act
            var result = stringCalcTest.Add(input);
            //assert
            Assert.AreEqual(69, result);
        }

        [TestMethod]
        public void add_getsEmptyString_returnsSum()
        {
            //arrange
            string input = "69,44";
            StringCalc stringCalcTest = new StringCalc();

            //act
            var result = stringCalcTest.Add(input);
            //assert
            Assert.AreEqual(113, result);
        }
        [TestMethod]
        public void add_getsIntegers_returnsSum()
        {
            //arrange
            string input = "69,44,77";
            StringCalc stringCalcTest = new StringCalc();

            //act
            var result = stringCalcTest.Add(input);
            //assert
            Assert.AreEqual(190, result);
        }
        [TestMethod]
        public void add_getsIntegersWithEscapeChar_returnsSum()
        {
            //arrange
            string input = "69\n44,77";
            StringCalc stringCalcTest = new StringCalc();

            //act
            var result = stringCalcTest.Add(input);
            //assert
            Assert.AreEqual(190, result);
        }
       
        [TestMethod]
        [ExpectedException(typeof(ArgumentException),"negatives not allowed!")]
        public void add_getsNegatives_throwsExeption()
        {
            //arrange
            string input = "-55,-11";
            StringCalc stringCalcTest = new StringCalc();

            //act
            var result = stringCalcTest.Add(input);
            //assert
          
        }
        [TestMethod]
        public void add_getsIntLargerThan1000_returnsSum()
        {
            //arrange
            string input = "1000,25";
            StringCalc stringCalcTest = new StringCalc();
            //act
            var result = stringCalcTest.Add(input);
            //assert
            Assert.AreEqual(25, result);
        }
        [TestMethod]
        public void add_getsLongSeparator_shouldReturnSum()
        {
            //arrange
            string input = "//[xxx]\n1xxx2xxx3";
            StringCalc stringCalcTest = new StringCalc();
            //act
            var result = stringCalcTest.Add(input);
            //assert
            Assert.AreEqual(6, result);
        }
    }
}