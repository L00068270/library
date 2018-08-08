﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace library.test
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Test_Divide_PositiveNumbers_ReturnsPositiveAnswer()
        {
            // Arrange
            // initialise objects to be passed to the Divide function being tested
            int expected = 6;
            int numerator = 18;
            int denominator = 3;

            // Act 
            // invoke functionto be tested
            // result will be stored in variable called 'Actual'
            int actual = MyClassesLibrary.Calculator.Divide(numerator, denominator);

            // Assert
            // verify if the function is acting as expected
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Divide_PositiveNumeratorAndNegativeDenominator_ReturnsNegativeAnswer()
        {
            // Arrange
            // initialise objects to be passed to the Divide function being tested
            int expected = -6;
            int numerator = 18;
            int denominator = -3;

            // Act 
            // invoke functionto be tested
            // result will be stored in variable called 'Actual'
            int actual = MyClassesLibrary.Calculator.Divide(numerator, denominator);

            // Assert
            // verify if the function is acting as expected
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Divide_NegativeNumeratorAndNegativeDenominator_ReturnsPositiveAnswer()
        {
            // Arrange
            // initialise objects to be passed to the Divide function being tested
            int expected = 6;
            int numerator = -18;
            int denominator = -3;

            // Act 
            // invoke functionto be tested
            // result will be stored in variable called 'Actual'
            int actual = MyClassesLibrary.Calculator.Divide(numerator, denominator);

            // Assert
            // verify if the function is acting as expected
            Assert.AreEqual(expected, actual);
        }
    }
}
