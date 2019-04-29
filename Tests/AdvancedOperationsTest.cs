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
    public class AdvancedOperationsTests
    {
        private readonly ComplexBinomic n7 = new ComplexBinomic(1,1);
        private readonly ComplexBinomic ComplexWithAngle0 = new ComplexBinomic(4, 0);
        private readonly ComplexBinomic ComplexWithAngle90 = new ComplexBinomic(0, 2);
        private readonly ComplexBinomic ComplexWithAngle180 = new ComplexBinomic(-2, 0);
        private readonly ComplexBinomic ComplexWithAngle270 = new ComplexBinomic(0, -8);
        private ComplexPolar p3 = new ComplexPolar(1, Math.PI/2);
        private ComplexPolar p4 = new ComplexPolar(2, 3*Math.PI / 2);

        //-----------------Potencia en Binomico------------------------
        [TestMethod]
        public void theImaginaryPartOftheSquareOfN7Is2()
        {
            Assert.AreEqual(2, n7.Potencia(2).ImaginaryPart,5);
        }

        [TestMethod]
        public void theImaginaryPartOfComplexWithAngle0ToTheFifthPowerIs0()
        {
            Assert.AreEqual(0, ComplexWithAngle0.Potencia(5).ImaginaryPart);
        }

        [TestMethod]
        public void theImaginaryPartOfComplexWithAngle180ToTheSixthPowerIs64()
        {
            Assert.AreEqual(64,ComplexWithAngle180.Potencia(6).RealPart);
        }

        [TestMethod]
        public void theImaginaryPartOfTheSquareOfComplexWithAngle90Is0()
        {
            Assert.AreEqual(-4, ComplexWithAngle90.Potencia(2).RealPart);
        }

        //-----------------Potencia en Polar------------------------

        [TestMethod]
        public void theModulelPartOfP4ToTheSeventhPowerIs128()
        {
            Assert.AreEqual(128, p4.Potencia(7).ModulePart);
        }

        [TestMethod]
        public void theAngleOfTheSquareOfP3IsPi()
        {
            Assert.AreEqual(Math.PI, p3.Potencia(2).AnglePart);
        }

        [TestMethod]
        public void theAngleOfP4ToTheFifthPowerIs15PiDivided2()
        {
            Assert.AreEqual(15*Math.PI/2, p4.Potencia(5).AnglePart);
        }

    }
}
