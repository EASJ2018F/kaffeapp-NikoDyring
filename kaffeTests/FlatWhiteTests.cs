using System;
using kaffe;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace kaffeTests
{
    [TestClass]
    public class FlatWhiteTests
    {
        [TestMethod]
        public void testStyrkeIFlatWhite()
        {
            // Arrange
            FlatWhite fw = new FlatWhite();

            // Act
            string styrke = fw.Styrke();

            //Assert
            Assert.AreEqual("Mild", styrke);
        }

        [TestMethod]
        public void testPrisIFlatWhite()
        {
            // Arrange
            FlatWhite fw = new FlatWhite();

            // Act
            int pris = fw.Pris();

            // Assert
            Assert.AreEqual(45, pris);
        }
    }
}
