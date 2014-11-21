﻿using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathBarldTest
{
    /// <summary>
    /// Summary description for PremsTests
    /// </summary>
    [TestClass]
    public class PriemsTests
    {
        public PriemsTests()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void PriemsBelowTest()
        {
            MathBarld.Priems.GetAllPriemsBelow(100000);
        }

        /// <summary>
        /// deze test methode zou een stuk sneller zijn omdat de cijfers in cache worden gehouden
        /// </summary>
        [TestMethod]
        public void PriemsBelowTest2()
        {
            MathBarld.Priems.GetAllPriemsBelow(101000);
        }

        [TestMethod]
        public void PriemsBelow1000Parralel()
        {
            var priems = MathBarld.Priems.GetPriemsBelowParallel(4 * 1000 * 100);
            //MathBarld.Priems.GetAllPriemsBelow(1000);
        }
    }
}
