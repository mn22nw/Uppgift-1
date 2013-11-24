using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace tri
{
    [TestClass]
    public class TriangleUnitTest
    {
        [TestMethod]
        public void CheckisIsosceles()
        {
            //Testar ifall trianglen är likbent
            Triangle tri = new Triangle(1.0, 0.5, 1.0);
            Assert.IsTrue(tri.isIsosceles()); // ger ett godkänt resultat om funktionen returnerar true
        }

        [TestMethod]
        public void CheckisScalene()
        {
            //Testar ifall trianglen är oliksidig
            Triangle tri = new Triangle(5.0, 6.5, 7.0);
            Assert.IsTrue(tri.isScalene()); // ger ett godkänt resultat om funktionen returnerar true
        }
        [TestMethod]
        public void CheckisEquilateral()
        {
            //Testar ifall trianglen är liksidig
            Triangle tri = new Triangle(5.0, 5.0, 5.0);
            Assert.IsTrue(tri.isEquilateral()); // ger ett godkänt resultat om funktionen returnerar true
        }
    // ** KOMMENTARER ** //
  /* Två av funktionerna (isEquilateral och isScalene) verkade från början vara fel uppbyggda då de i testerna 
     returnerade false*/
    }
}
