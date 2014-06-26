using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathBarldTest
{
    /// <summary>
    /// Summary description for FaculteitTests
    /// </summary>
    [TestClass]
    public class FaculteitTests
    {
        public FaculteitTests()
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
        public void TestFaculteit()
        {
            Assert.AreEqual(120, MathBarld.Faculteit.GetIteratiev(5));
            Assert.AreEqual(120, MathBarld.Faculteit.GetRecursive(5));
        }
    }
}
