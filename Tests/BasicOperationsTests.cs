using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TpMatematicaSuperior.Model.ComplexNumbers;

namespace Tests
{
    [TestClass]
    public class BasicOperationsTests
    {
        private ComplexBinomic n1 = new ComplexBinomic(-1, 3);
        private ComplexBinomic n2 = new ComplexBinomic(2, -5);
        private ComplexBinomic ComplexWithAngle0 = new ComplexBinomic(4, 0);
        private ComplexBinomic ComplexWithAngle90 = new ComplexBinomic(0, 2);
        private ComplexBinomic ComplexWithAngle180 = new ComplexBinomic(-2, 0);
        private ComplexBinomic ComplexWithAngle270 = new ComplexBinomic(0 , -8);
        private ComplexBinomic ComplexWithAngle45 = new ComplexBinomic(1, 1);
        private ComplexBinomic ComplexWithAngle225 = new ComplexBinomic(-1, -1);
        private ComplexBinomic ComplexWithAngle315 = new ComplexBinomic(1, -1);
        private ComplexBinomic n3 = new ComplexBinomic(4, -3);

        private ComplexPolar p1 = new ComplexPolar(-1, 2);
        private ComplexPolar p2 = new ComplexPolar(2, 3);

        //-----------------tests Binomic to Polar------------------------

        [TestMethod]
        public void ModulePartFromN3convertToPolarEquals5() =>
            Assert.AreEqual(5, n3.ConvertToPolarForm().ModulePart);

        [TestMethod]
        public void ModulePartFromN1ConvertToPolarEqualsPow10()
        {
            const int raizCuadrada = 2;
            Assert.AreEqual(Math.Sqrt(10), n1.ConvertToPolarForm().ModulePart);
        }
        [TestMethod]
        public void AnglePartFromComplexWithAngle0ConvertToPolarEquals0() =>
           Assert.AreEqual(0, ComplexWithAngle0.ConvertToPolarForm().AnglePart);

        [TestMethod]
        public void AnglePartFromComplexWithAngle90ConvertToPolarEquals90() =>
           Assert.AreEqual(Math.PI/2, ComplexWithAngle90.ConvertToPolarForm().AnglePart);

        [TestMethod]
        public void AnglePartFromN1ConvertToPolarEquals3piOutOf4() =>
           Assert.AreEqual(Math.Atan(3 / (-1)) + Math.PI, n1.ConvertToPolarForm().AnglePart);


        //-----------------tests Binomic---------------------------------
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
        [TestMethod]
        public void anglePartFromP1MultipliedP2Equals5()
        {
            Assert.AreEqual(5, (p1 * p2).AnglePart);
        }
        [TestMethod]
        public void modulePartFromP1MultipliedP2EqualsMinus2()
        {
            Assert.AreEqual(-2, (p1 * p2).ModulePart);
        }
    }
}
