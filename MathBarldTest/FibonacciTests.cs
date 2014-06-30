using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathBarld;

namespace MathBarldTest
{
    /// <summary>
    /// Summary description for FibonacciTests
    /// </summary>
    [TestClass]
    public class FibonacciTests
    {
        public FibonacciTests()
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
        public void FiboncciNumbersRecursiceTest()
        {
            Assert.AreEqual(Fibonacci.GetFibonacciNumberRecursive(1), 1);
            Assert.AreEqual(Fibonacci.GetFibonacciNumberRecursive(2), 1);
            Assert.AreEqual(Fibonacci.GetFibonacciNumberRecursive(3), 2);
            Assert.AreEqual(Fibonacci.GetFibonacciNumberRecursive(4), 3);
            Assert.AreEqual(Fibonacci.GetFibonacciNumberRecursive(5), 5);
            Assert.AreEqual(Fibonacci.GetFibonacciNumberRecursive(6), 8);
            Assert.AreEqual(Fibonacci.GetFibonacciNumberRecursive(7), 13);
            Assert.AreEqual(Fibonacci.GetFibonacciNumberRecursive(8), 21);
            Assert.AreEqual(Fibonacci.GetFibonacciNumberRecursive(9), 34);
            Assert.AreEqual(Fibonacci.GetFibonacciNumberRecursive(10), 55);
            Assert.AreEqual(Fibonacci.GetFibonacciNumberRecursive(11), 89);
            Assert.AreEqual(Fibonacci.GetFibonacciNumberRecursive(12), 144);
            Assert.AreEqual(Fibonacci.GetFibonacciNumberRecursive(13), 233);
            Assert.AreEqual(Fibonacci.GetFibonacciNumberRecursive(14), 377);
            Assert.AreEqual(Fibonacci.GetFibonacciNumberRecursive(15), 610);
            Assert.AreEqual(Fibonacci.GetFibonacciNumberRecursive(16), 987);
            Assert.AreEqual(Fibonacci.GetFibonacciNumberRecursive(17), 1597);
            Assert.AreEqual(Fibonacci.GetFibonacciNumberRecursive(18), 2584);
            Assert.AreEqual(Fibonacci.GetFibonacciNumberRecursive(19), 4181);
            Assert.AreEqual(Fibonacci.GetFibonacciNumberRecursive(20), 6765);
        }

        [TestMethod]
        public void FiboncciNumbersIteratievTest()
        {
            Assert.AreEqual(Fibonacci.GetFibonacciNumberIterative(1), 1);
            Assert.AreEqual(Fibonacci.GetFibonacciNumberIterative(2), 1);
            Assert.AreEqual(Fibonacci.GetFibonacciNumberIterative(3), 2);
            Assert.AreEqual(Fibonacci.GetFibonacciNumberIterative(4), 3);
            Assert.AreEqual(Fibonacci.GetFibonacciNumberIterative(5), 5);
            Assert.AreEqual(Fibonacci.GetFibonacciNumberIterative(6), 8);
            Assert.AreEqual(Fibonacci.GetFibonacciNumberIterative(7), 13);
            Assert.AreEqual(Fibonacci.GetFibonacciNumberIterative(8), 21);
            Assert.AreEqual(Fibonacci.GetFibonacciNumberIterative(9), 34);
            Assert.AreEqual(Fibonacci.GetFibonacciNumberIterative(10), 55);
            Assert.AreEqual(Fibonacci.GetFibonacciNumberIterative(11), 89);
            Assert.AreEqual(Fibonacci.GetFibonacciNumberIterative(12), 144);
            Assert.AreEqual(Fibonacci.GetFibonacciNumberIterative(13), 233);
            Assert.AreEqual(Fibonacci.GetFibonacciNumberIterative(14), 377);
            Assert.AreEqual(Fibonacci.GetFibonacciNumberIterative(15), 610);
            Assert.AreEqual(Fibonacci.GetFibonacciNumberIterative(16), 987);
            Assert.AreEqual(Fibonacci.GetFibonacciNumberIterative(17), 1597);
            Assert.AreEqual(Fibonacci.GetFibonacciNumberIterative(18), 2584);
            Assert.AreEqual(Fibonacci.GetFibonacciNumberIterative(19), 4181);
            Assert.AreEqual(Fibonacci.GetFibonacciNumberIterative(20), 6765);
        }

        [TestMethod]
        public void RecursiveCacheTest()
        {
            for(int i = 1;i<20;i++)
            {
                Assert.AreEqual(Fibonacci.GetFibonacciNumberIterative(i), Fibonacci.RecursiveWithCache(i));
            }
        }

        [TestMethod]
        public void performanceRecursive35Test()
        {
            Fibonacci.GetFibonacciNumberRecursive(35);
        }

        [TestMethod]
        public void performanceIteratiev40Test()
        {
            Fibonacci.GetFibonacciNumberIterative(40);
        }

        [TestMethod]
        public void performanceIteratiev4000000Test()
        {
            Fibonacci.GetFibonacciNumberIterative(4000000);
            Fibonacci.GetFibonacciNumberIterative(4000001);
            Fibonacci.GetFibonacciNumberIterative(4000002);
        }

        [TestMethod]
        public void performanceRecursiveWithCache4000000Test()
        {
            /*Fibonacci.RecursiveWithCache(4000000);
            Fibonacci.RecursiveWithCache(4000001);
            Fibonacci.RecursiveWithCache(4000002);*/
            Fibonacci.RecursiveWithCache(21003);
        }


    }
}
