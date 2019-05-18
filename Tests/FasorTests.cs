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
    public class FasorTests
    {
        [TestMethod]
        public void modulePartMinus1OfAPolarComlexThrowError()
        {
            Assert.ThrowsException<InvalidFasorException>(() => new Fasor(1,"arctg",5,Math.PI/2));
        }
    }
}
