using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TpMatematicaSuperior.Model.ComplexNumbers;

namespace Tests
{
    [TestClass]
    public class BasicOperationsTests
    {
        private Complex n1 = new Complex(-1, 3);
        private Complex n2 = new Complex(2, -5);
        private Complex ComplexWithAngle0 = new Complex(4, 0);
        private Complex ComplexWithAngle90 = new Complex(0, 2);
        private Complex ComplexWithAngle180 = new Complex(-2, 0);
        private Complex ComplexWithAngle270 = new Complex(0 , -8);
        private Complex ComplexWithAngle45 = new Complex(1, 1);
        private Complex ComplexWithAngle225 = new Complex(-1, -1);
        private Complex ComplexWithAngle315 = new Complex(1, -1);
        private Complex n3 = new Complex(4, -3);

        [TestMethod]
        public void RealPartFromSumBetweenN1AndN2Equals1() {
            Assert.AreEqual(1, (n1 + n2).RealPart);
        }
        [TestMethod]
        public void ImaginaryPartFromSumBetweenN1AndN2EqualsMinus2() {
            Assert.AreEqual(-2, (n1 + n2).ImaginaryPart);
        }
        [TestMethod]
        public void RealPartFromN1MinusN2EqualsMinus3() {
            Assert.AreEqual(-3, (n1 - n2).RealPart);
        }
        [TestMethod]
        public void ImaginaryPartFromN1MinusN2Equals8() {
            Assert.AreEqual(8, (n1 - n2).ImaginaryPart);
        }
        [TestMethod]
        public void RealPartFromN1MultipliedN2EqualsMinus2() {
            Assert.AreEqual(-2, (n1 * n2).RealPart);
        }
        [TestMethod]
        public void ImaginaryPartFromN1MultipliedN2EqualsMinus15() {
            Assert.AreEqual(-15, (n1 * n2).ImaginaryPart);
        }
        [TestMethod]
        public void AngleFromComplexWithAngle0Is0()
        {
            Assert.AreEqual(0, ComplexWithAngle0.GetMyAlphaAngle());
        }
        [TestMethod]
        public void AngleFromComplexWithAngle90Is90()
        {
            Assert.AreEqual(Math.PI / 2, ComplexWithAngle90.GetMyAlphaAngle());
        }
        [TestMethod]
        public void AngleFromComplexWithAngle180Is180()
        {
            Assert.AreEqual(Math.PI, ComplexWithAngle180.GetMyAlphaAngle());
        }
        [TestMethod]
        public void AngleFromComplexWithAngle270Is270()
        {
            Assert.AreEqual(Math.PI * 3 / 2, ComplexWithAngle270.GetMyAlphaAngle());
        }
        [TestMethod]
        public void AngleFromComplexWithAngle45Is45()
        {
            Assert.AreEqual(Math.PI / 4, ComplexWithAngle45.GetMyAlphaAngle());
        }
        [TestMethod]
        public void AngleFromComplexWithAngle225Is225()
        {
            Assert.AreEqual(Math.PI * 5 / 4, ComplexWithAngle225.GetMyAlphaAngle());
        }
        [TestMethod]
        public void AngleFromComplexWithAngle315Is315()
        {
            Assert.AreEqual(Math.PI * 7 / 4, ComplexWithAngle315.GetMyAlphaAngle());
        }
        [TestMethod]
        public void ModuleFromN3Equals5()
        {
            Assert.AreEqual(5, n3.GetMymodule());
        }

    }
}
