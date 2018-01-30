using System;
using kaffe;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace kaffeTests
{
    [TestClass]
    public class CortadoTests
    {
        [TestMethod]
        public void CortadoPrisTest()
        {
            // Arrange
            Cortado co = new Cortado();
            // Act
            int pris = co.Pris();
            // Assert
            Assert.AreEqual(25, pris);
        }
    }
}
