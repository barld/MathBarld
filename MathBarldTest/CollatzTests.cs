using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathBarldTest
{
    [TestClass]
    public class CollatzTests
    {
        [TestMethod]
        public void CollectionOf13Test()
        {
            var c = MathBarld.Collatz.GetCollectionCountRecursief(13);

            Assert.AreEqual<int>(c, 10);
        }
    }
}
