﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using MathBarld.ProjectEuler;

namespace MathBarldTest
{
    [TestClass]
    public class ProjectEulerTests
    {
        [TestMethod]
        public void Problem1()
        {
            IProblem p1 = new Problem1();

            Assert.IsTrue(p1.GetAnswer() == 233168);
        }

        [TestMethod]
        public void Problem2()
        {
            IProblem p2 = new Problem2();

            Assert.IsTrue(p2.GetAnswer() == 4613732);
        }

        [TestMethod]
        public void Problem3()
        {
            IProblem p3 = new Problem3();

            Assert.IsTrue(p3.GetAnswer() == 6857);
        }

        [TestMethod]
        public void Problem4()
        {
            IProblem p4 = new Problem4();

            Assert.IsTrue(p4.GetAnswer() == 906609);
        }

        [TestMethod]
        public void Problem5()
        {
            IProblem p5 = new Problem5();

            Assert.IsTrue(p5.GetAnswer() == 232792560);
        }

        [TestMethod]
        public void Problem6()
        {
            IProblem p6 = new Problem6();

            Assert.IsTrue(p6.GetAnswer() == 25164150);
        }

        [TestMethod]
        public void Problem7()
        {
            IProblem p7 = new Problem7();

            Assert.IsTrue(p7.GetAnswer() == 104743);
        }

        [TestMethod]
        public void Problem8()
        {
            IProblem p8 = new Problem8();

            Assert.IsTrue(p8.GetAnswer() == 23514624000);
        }

        [TestMethod]
        public void Problem9()
        {
            IProblem p9 = new Problem9();

            Assert.IsTrue(p9.GetAnswer() == 31875000);
        }

        [TestMethod]
        public void Problem10()
        {
            IProblem p10 = new Problem10();

            Assert.IsTrue(p10.GetAnswer() == 142913828922);
        }
    }
}
