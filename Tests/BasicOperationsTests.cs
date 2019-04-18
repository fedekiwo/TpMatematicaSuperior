using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TpMatematicaSuperior.Model.ComplexNumbers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass]
    public class BasicOperationsTests
    {
        private readonly Complex n1 = new Complex(-1, 3);
        private readonly Complex n2 = new Complex(2, -5);
        private readonly Complex ComplexWithAngle0 = new Complex(4, 0);
        private readonly Complex ComplexWithAngle90 = new Complex(0, 2);
        private readonly Complex ComplexWithAngle180 = new Complex(-2, 0);
        private readonly Complex ComplexWithAngle270 = new Complex(0, -8);
        private readonly Complex ComplexWithAngle45 = new Complex(1, 1);
        private readonly Complex ComplexWithAngle225 = new Complex(-1, -1);
        private readonly Complex ComplexWithAngle315 = new Complex(1, -1);
        private readonly Complex n3 = new Complex(4, -3);
        private readonly Complex n4 = new Complex(0, 4);
        private readonly Complex n5 = new Complex(-2, 0);
        private readonly Complex n6 = new Complex(-60, 80);
        [TestMethod]
        public void RealPartFromN6DividedByN3Equals()
        {
            Assert.AreEqual(-19.2 , (n6 / n3).RealPart);
        }
        [TestMethod]
        public void ImaginaryPartFromN6DividedByN3Equals()
        {
            Assert.AreEqual(5.6, (n6 / n3).ImaginaryPart, 0.0000000000001);
        }
        [TestMethod]
        public void AngleFromN6DividedByN3Equals270Deg()
        {
            Assert.AreEqual(2.85779854438147, (n6 / n3).GetMyAlphaAngle(), 0.000000000001);
        }
        [TestMethod]
        public void ModuleFromN6DividedByN3Equals20()
        {
            Assert.AreEqual(20, (n6 / n3).GetMymodule());
        }
        [TestMethod]
        public void RealPartFromN4DividedByN5Equals0()
        {
            Assert.AreEqual(0, (n4 / n5).RealPart);
        }
        [TestMethod]
        public void ImaginaryPartFromN4DividedByN5EqualsMinus2()
        {
            Assert.AreEqual(-2, (n4 / n5).ImaginaryPart);
        }
        [TestMethod]
        public void AngleFromN4DividedByN5Equals270Deg()
        {
            Assert.AreEqual(Math.PI * 3/2 , (n4 / n5).GetMyAlphaAngle());
        }
        [TestMethod]
        public void ModuleFromN4DividedByN5Equals2()
        {
            Assert.AreEqual(2, (n4 / n5).GetMymodule());
        }
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
        public void RealPartFromN2Multiplied7Equals14()
        {
            Assert.AreEqual(14, (n2 * 7).RealPart);
        }
        [TestMethod]
        public void ImaginaryPartFromN1MultipliedN2EqualsMinus15() {
            Assert.AreEqual(-15, (n1 * n2).ImaginaryPart);
        }
        [TestMethod]
        public void ImaginaryPartFromN1MultipliedByScalar3Equals9()
        {
            Assert.AreEqual(9, (3 * n1).ImaginaryPart);
        }
        [TestMethod]
        public void ImaginaryPartFrom3MultipliedN1Equals9()
        {
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
