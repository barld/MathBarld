using System;
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

        [TestMethod]
        public void Problem11()
        {
            IProblem p11 = new Problem11();

            Assert.IsTrue(p11.GetAnswer() == 70600674);
        }

        [TestMethod]
        public void Problem12()
        {
            IProblem p12 = new Problem12();

            Assert.IsTrue(p12.GetAnswer() == 76576500);
        }

        [TestMethod]
        public void Problem13()
        {
            IProblem p13 = new Problem13();

            Assert.IsTrue(p13.GetAnswer() == 5537376230);
        }

        
        [TestMethod]
        public void Problem14()
        {
            IProblem p14 = new Problem14();

            Assert.IsTrue(p14.GetAnswer() == 837799);
        }

        [TestMethod]
        public void Problem15()
        {
            IProblem p15 = new Problem15();

            Assert.IsTrue(p15.GetAnswer() == 137846528820);
        }

        [TestMethod]
        public void Problem16()
        {
            IProblem p16 = new Problem16();

            Assert.IsTrue(p16.GetAnswer() == 1366);
        }

        [TestMethod]
        public void Problem18()
        {
            IProblem p18 = new Problem18();

            Assert.IsTrue(p18.GetAnswer() == 1074);
        }

        [TestMethod]
        public void Problem19()
        {
            IProblem p19 = new Problem19();

            Assert.IsTrue(p19.GetAnswer() == 171);
        }

        [TestMethod]
        public void Problem20()
        {
            IProblem p20 = new Problem20();

            Assert.IsTrue(p20.GetAnswer() == 648);
        }

        [TestMethod]
        public void Problem22()
        {
            IProblem p22 = new Problem22();

            Assert.IsTrue(p22.GetAnswer() == 871198282);
        }

        [TestMethod]
        public void Problem25()
        {
            IProblem p25 = new Problem25();

            Assert.IsTrue(p25.GetAnswer() == 4782);
        }
    }
}
